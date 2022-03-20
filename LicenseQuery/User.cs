namespace LicenseQuery
{
	public enum UserProp
	{
		Unknown,
		SamAccountName,
		DistinguishedName,
		FirstName,
		LastName,
		EmailAddress,
		Enabled,
		Title,
		Department,
		City,
		State,
		Country
	}

	public class User
	{
		public string SamAccountName { get; set; }
		public string DistinguishedName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public string Enabled { get; set; }
		public string Title { get; set; }
		public string Department { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }

		public static string PropMapping(UserProp prop)
		{
			switch (prop)
			{
				case UserProp.SamAccountName:
					return "samAccountName";
				case UserProp.DistinguishedName:
					return "distinguishedName";
				case UserProp.FirstName:
					return "givenName";
				case UserProp.LastName:
					return "sn";
				case UserProp.EmailAddress:
					return "mail";
				case UserProp.Enabled:
					return "userAccountControl";
				case UserProp.Title:
					return "title";
				case UserProp.Department:
					return "department";
				case UserProp.City:
					return "l";
				case UserProp.State:
					return "st";
				case UserProp.Country:
					return "co";
				default:
					return "N/A";
			}
		}
	}
}
