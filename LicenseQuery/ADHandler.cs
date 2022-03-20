using System;
using System.Collections.Concurrent;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.Protocols;
using System.Threading.Tasks;
using System.Timers;


namespace LicenseQuery
{
	public enum ConnectionState
	{
		Pending,
		Connected,
		Disconnected
	}

	public static class ADHandler
	{
		private static LdapConnection connection;
		private static SearchRequest connectionRequest;
		private static TimeSpan timeout;
		private static Timer timer;
		private static bool runOnce = true;

		public static ADSearcher[] Searchers { get; set; }
		public static ConcurrentQueue<User> EnabledUsers { get; set; }
		public static ConcurrentQueue<User> DisabledUsers { get; set; }
		public static ConnectionState Connected { get; set; }
		public static bool TasksActive
		{
			get
			{
				bool active = false;
				for (int i = 0; i != Searchers.Length; ++i)
					if (Searchers[i].Task != null && !(active = !Searchers[i].Task.IsCompleted))
					{
						Searchers[i].Task.Dispose();
						Searchers[i].Task = null;
					}

				return active;
			}
		}
		
		static ADHandler()
		{
			Connected = ConnectionState.Pending;

			connection = new LdapConnection(EnvironmentVars.DOMAIN_CONTROLLER);
			timeout = TimeSpan.FromSeconds(10);

			Searchers = new ADSearcher[10] {
				new ADSearcher(EnvironmentVars.DOMAIN_USERS_OU_ROOT),
				new ADSearcher(EnvironmentVars.DOMAIN_USERS_OU_ROOT),
				new ADSearcher(EnvironmentVars.DOMAIN_USERS_OU_ROOT),
				new ADSearcher(EnvironmentVars.DOMAIN_USERS_OU_ROOT),
				new ADSearcher(EnvironmentVars.DOMAIN_USERS_OU_ROOT),
				new ADSearcher(EnvironmentVars.DOMAIN_USERS_OU_ROOT),
				new ADSearcher(EnvironmentVars.DOMAIN_USERS_OU_ROOT),
				new ADSearcher(EnvironmentVars.DOMAIN_USERS_OU_ROOT),
				new ADSearcher(EnvironmentVars.DOMAIN_USERS_OU_ROOT),
				new ADSearcher(EnvironmentVars.DOMAIN_USERS_OU_ROOT)
			};

			timer = new Timer();
			timer.Interval = 1;
			timer.Elapsed += Timer_Elapsed;
			timer.Start();

			EnabledUsers = new ConcurrentQueue<User>();
			DisabledUsers = new ConcurrentQueue<User>();
		}

		public static void Initialize()
		{

		}

		private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			timer.Stop();

			if (connectionRequest == null)
				connectionRequest = new SearchRequest() { DistinguishedName = GetLoggedOnUserDistinguishedName() };

			if (runOnce)
			{
				runOnce = false;
				timer.Interval = 10000;
			}

			try
			{
				connection.SendRequest(connectionRequest, timeout);

				Connected = ConnectionState.Connected;
			}
			catch (Exception)
			{
				Connected = ConnectionState.Disconnected;
			}

			timer.Start();
		}

		public static string GetLoggedOnUserDistinguishedName()
		{
			string distName = UserPrincipal.Current.DistinguishedName;
			return distName != null ? distName : "N/A";
		}

		private static string GetProperty(SearchResult result, string prop)
		{
			if (result.Properties.Contains(prop) && result.Properties[prop].Count > 0 && result.Properties[prop][0].ToString() != string.Empty)
				if (prop == User.PropMapping(UserProp.Enabled))
					return "True";
				else
					return result.Properties[prop][0].ToString();

			return "N/A";
		}

		public static User GetUser(string email, DirectorySearcher searcher)
		{
			return GetUser(new User() { EmailAddress = email, Enabled = "False" }, searcher);
		}

		public static User GetUser(User user, DirectorySearcher searcher)
		{
			if (user.EmailAddress != string.Empty)
			{
				try
				{
					searcher.Filter = "(&(objectClass=user)(objectCategory=person)(mail=" + user.EmailAddress + ")(!userAccountControl:1.2.840.113556.1.4.803:=2))";
					SearchResultCollection results = searcher.FindAll();
					if (results != null && results.Count > 0)
					{
						user.SamAccountName = GetProperty(results[0], User.PropMapping(UserProp.SamAccountName));
						user.DistinguishedName = GetProperty(results[0], User.PropMapping(UserProp.DistinguishedName));
						user.FirstName = GetProperty(results[0], User.PropMapping(UserProp.FirstName));
						user.LastName = GetProperty(results[0], User.PropMapping(UserProp.LastName));
						user.EmailAddress = GetProperty(results[0], User.PropMapping(UserProp.EmailAddress));
						user.Enabled = GetProperty(results[0], User.PropMapping(UserProp.Enabled));
						user.Title = GetProperty(results[0], User.PropMapping(UserProp.Title));
						user.City = GetProperty(results[0], User.PropMapping(UserProp.City));
						user.State = GetProperty(results[0], User.PropMapping(UserProp.State));
						user.Country = GetProperty(results[0], User.PropMapping(UserProp.Country));
					}
					else
					{
						//	User not found, bad email, or user disabled
					}
				}
				catch (Exception)
				{
					Connected = ConnectionState.Disconnected;
				}
			}

			return user;
		}

		public static void ClearConcurrentCollections()
		{
			for (int i = 0; i != Searchers.Length; ++i)
				while (Searchers[i].Users.Count > 0)
					Searchers[i].Users.TryDequeue(out User u);

			while (EnabledUsers.Count > 0)
				EnabledUsers.TryDequeue(out User u);

			while (DisabledUsers.Count > 0)
				DisabledUsers.TryDequeue(out User u);
		}

		public static void ProcessUsers()
		{
			for (int i = 0; i != Searchers.Length; ++i)
				Searchers[i].Task = Task.Factory.StartNew(Searchers[i].Search);
		}
	}
}
