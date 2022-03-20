using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;


namespace LicenseQuery
{
	public static class CSVHandler
	{
		public static List<CSVSheet> Sheets { get; private set; } = new List<CSVSheet>();
		public static void AddCSVSheetAtPath(string path, string key = "LicenseID")
		{
			if (File.Exists(path))
			{
				int foundIndex = -1;
				for (int i = 0; i != Sheets.Count; ++i)
					if (Sheets[i].Name == Path.GetFileNameWithoutExtension(path))
					{
						foundIndex = i;
						break;
					}

				if (foundIndex != -1)
					Sheets.RemoveAt(foundIndex);

				Sheets.Add(new CSVSheet(path, key));
			}
		}
		public static void FindAllCSVsInPath(string path, string key = "LicenseID")
		{
			Sheets.Clear();

			string[] csvFiles = Directory.GetFiles(Path.GetDirectoryName(path), "*.csv");
			for (int i = 0; i != csvFiles.Length; ++i)
				Sheets.Add(new CSVSheet(csvFiles[i], key));
		}
		public static int GetSheetIndexByName(string sheetName)
		{
			for (int i = 0; i != Sheets.Count; ++i)
				if (Sheets[i].Name == sheetName)
					return i;

			return -1;
		}
		public static Dictionary<string, License> GetEnabledCustomerRecords(int sheetIndex)
		{
			return CSVSheet.GetFilteredLicenses(
				Sheets[sheetIndex],
				new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("Enabled", "True")}
			);
		}
		public static Dictionary<string, License> GetDisabledCustomerRecords(int sheetIndex)
		{
			return CSVSheet.GetFilteredLicenses(
				Sheets[sheetIndex],
				new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("Enabled", "False") }
			);
		}
		public static Dictionary<string, License> GetMissingFirstNameRecords(int sheetIndex)
		{
			return CSVSheet.GetFilteredLicenses(
				Sheets[sheetIndex],
				new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("FirstName", "") }
			);
		}
		public static Dictionary<string, License> GetMissingLastNameRecords(int sheetIndex)
		{
			return CSVSheet.GetFilteredLicenses(
				Sheets[sheetIndex],
				new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("LastName", "") }
			);
		}
		public static Dictionary<string, License> GetMissingEmailRecords(int sheetIndex)
		{
			return CSVSheet.GetFilteredLicenses(
				Sheets[sheetIndex],
				new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("EMail", "") }
			);
		}
		public static Dictionary<string, License> GetDomainEmailRecords(int sheetIndex)
		{
			return CSVSheet.GetFilteredLicenses(
				Sheets[sheetIndex],
				new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("EMail", string.Format("*@{0}", EnvironmentVars.DOMAIN_EMAIL)) }
			);
		}
		public static Dictionary<string, License> GetNonDomainEmailRecords(int sheetIndex)
		{
			return CSVSheet.GetFilteredLicenses(
				Sheets[sheetIndex],
				new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("EMail", string.Format("-@{0}", EnvironmentVars.DOMAIN_EMAIL)) }
			);
		}
		public static Dictionary<string, License> GetEnabledCustomerRecordsWithDomainEmail(int sheetIndex)
		{
			return CSVSheet.GetFilteredLicenses(
				Sheets[sheetIndex],
				new List<KeyValuePair<string, string>>()
				{
					new KeyValuePair<string, string>("Enabled", "True"),
					new KeyValuePair<string, string>("EMail", string.Format("*@{0}", EnvironmentVars.DOMAIN_EMAIL))
				}
			);
		}
		public static ConcurrentDictionary<string, License> GetEnabledCustomerRecordsWithDomainEmailAsync(int sheetIndex)
		{
			return CSVSheet.GetFilteredLicensesAsync(
				Sheets[sheetIndex],
				new List<KeyValuePair<string, string>>()
				{
					new KeyValuePair<string, string>("Enabled", "True"),
					new KeyValuePair<string, string>("EMail", string.Format("*@{0}", EnvironmentVars.DOMAIN_EMAIL))
				}
			);
		}
		public static Dictionary<string, License> GetLicensesByEmail(int sheetIndex, string email)
		{
			return CSVSheet.GetFilteredLicenses(
				Sheets[sheetIndex],
				new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("EMail", email) }
			);
		}
	}
}
