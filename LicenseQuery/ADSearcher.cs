using System;
using System.Collections.Concurrent;
using System.DirectoryServices;
using System.Threading.Tasks;


namespace LicenseQuery
{
	public class ADSearcher
	{
		public ConcurrentQueue<User> Users { get; set; }
		public DirectorySearcher Searcher { get; set; }
		public TimeSpan Timeout { get; set; }
		public Task Task { get; set; }
		public string SearchRoot { get; set; }

		public ADSearcher(string searchRoot)
		{
			Users = new ConcurrentQueue<User>();
			Timeout = TimeSpan.FromSeconds(10);
			SearchRoot = searchRoot;
			Searcher = new DirectorySearcher(searchRoot);
			Searcher.PropertiesToLoad.Add(User.PropMapping(UserProp.SamAccountName));
			Searcher.PropertiesToLoad.Add(User.PropMapping(UserProp.DistinguishedName));
			Searcher.PropertiesToLoad.Add(User.PropMapping(UserProp.FirstName));
			Searcher.PropertiesToLoad.Add(User.PropMapping(UserProp.LastName));
			Searcher.PropertiesToLoad.Add(User.PropMapping(UserProp.EmailAddress));
			Searcher.PropertiesToLoad.Add(User.PropMapping(UserProp.Enabled));
			Searcher.PropertiesToLoad.Add(User.PropMapping(UserProp.Title));
			Searcher.PropertiesToLoad.Add(User.PropMapping(UserProp.City));
			Searcher.PropertiesToLoad.Add(User.PropMapping(UserProp.State));
			Searcher.PropertiesToLoad.Add(User.PropMapping(UserProp.Country));
			Searcher.ClientTimeout = Timeout;
		}

		public void Search()
		{
			while (Users.TryDequeue(out User user) && ADHandler.Connected == ConnectionState.Connected)
			{
				user = ADHandler.GetUser(user, Searcher);
				if (user.Enabled == "True")
					ADHandler.EnabledUsers.Enqueue(user);
				else
					ADHandler.DisabledUsers.Enqueue(user);
			}
		}
	}
}
