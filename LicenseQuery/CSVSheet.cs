using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;


namespace LicenseQuery
{
	public class CSVSheet
	{
		public string Name { get; private set; }
		public FileInfo FileInfo { get; private set; }
		public List<string> Headers { get; private set; }
		public string Key { get; private set; }
		public int KeyIndex { get; private set; }
		public Dictionary<string, License> Rows { get; private set; }
		public bool IsValid
		{
			get { return FileInfo != null; }
			private set { }
		}

		private CSVSheet() { }

		public CSVSheet(string csvPath, string key)
		{
			if (csvPath.ToLower().EndsWith(".csv") && File.Exists(csvPath))
			{
				FileInfo = new FileInfo(csvPath);
				Name = Path.GetFileNameWithoutExtension(FileInfo.Name);

				using (TextFieldParser csvParser = new TextFieldParser(FileInfo.FullName))
				{
					csvParser.CommentTokens = new string[] { "#" };
					csvParser.SetDelimiters(new string[] { "," });
					csvParser.HasFieldsEnclosedInQuotes = true;

					Headers = csvParser.ReadFields().ToList<string>();
					bool foundKey = false;
					for (int i = 0; i != Headers.Count; ++i)
					{
						if (Headers[i] == key)
						{
							foundKey = true;
							Key = key;
							KeyIndex = i;
							break;
						}
					}

					if (foundKey)
					{
						//	Check which columns are present in License object
						List<int> cols = new List<int>();
						for (int i = 0; i != Headers.Count; ++i)
							if (License.HasProperty(Headers[i]))
								cols.Add(i);

						Rows = new Dictionary<string, License>();
						while (!csvParser.EndOfData)
						{
							string[] row = csvParser.ReadFields();
							License license = new License();
							for (int i = 0; i != row.Length; ++i)
								if (cols.Contains(i))   //	Column is present as a property in License
									license.SetProperty(Headers[i], row[i]);
							Rows.Add(license[Key], license);
						}
					}
				}
			}
		}

		public static Dictionary<string, License> GetFilteredLicenses(CSVSheet csvSheet, List<KeyValuePair<string, string>> filterProps)
		{
			Dictionary<string, License> filteredList = new Dictionary<string, License>();

			foreach (License license in csvSheet.Rows.Values)
			{
				bool found = true;
				for (int i = 0; i != filterProps.Count; ++i)
				{
					if (filterProps[i].Value.StartsWith("*"))
					{
						string wild = filterProps[i].Value.Replace("*", "").ToLower();
						if (!license[filterProps[i].Key].ToLower().Contains(wild))
						{
							found = false;
							break;
						}
					}
					else if (filterProps[i].Value.StartsWith("-"))
					{
						string wild = filterProps[i].Value.Replace("-", "").ToLower();
						if (license[filterProps[i].Key].ToLower().Contains(wild))
						{
							found = false;
							break;
						}
					}
					else
					{
						if (license[filterProps[i].Key] != filterProps[i].Value)
						{
							found = false;
							break;
						}
					}
				}

				if (found)
					filteredList.Add(license.LicenseID, license);
			}

			return filteredList;
		}

		public static ConcurrentDictionary<string, License> GetFilteredLicensesAsync(CSVSheet csvSheet, List<KeyValuePair<string, string>> filterProps)
		{
			ConcurrentDictionary<string, License> filteredList = new ConcurrentDictionary<string, License>();

			foreach (License license in csvSheet.Rows.Values)
			{
				bool found = true;
				for (int i = 0; i != filterProps.Count; ++i)
				{
					if (filterProps[i].Value.StartsWith("*"))
					{
						string wild = filterProps[i].Value.Replace("*", "").ToLower();
						if (!license[filterProps[i].Key].ToLower().Contains(wild))
						{
							found = false;
							break;
						}
					}
					else if (filterProps[i].Value.StartsWith("-"))
					{
						string wild = filterProps[i].Value.Replace("-", "").ToLower();
						if (license[filterProps[i].Key].ToLower().Contains(wild))
						{
							found = false;
							break;
						}
					}
					else
					{
						if (license[filterProps[i].Key] != filterProps[i].Value)
						{
							found = false;
							break;
						}
					}
				}

				if (found)
					filteredList.TryAdd(license.LicenseID, license);
			}

			return filteredList;
		}
	}
}
