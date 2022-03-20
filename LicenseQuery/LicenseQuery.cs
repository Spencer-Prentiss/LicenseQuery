using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;


namespace LicenseQuery
{
	public partial class LicenseQuery : Form
	{
		private Timer checkConnectionTimer = new Timer() { Interval = 5000 };
		private Timer containerCheckTimer = new Timer() { Interval = 200 };
		private bool isConnected = false;
		private bool runOnce = true;
		private bool reportedDisconnect = false;
		private int currentSheet = -1;
		private HashSet<string> userExceptions = new HashSet<string>() { string.Format("Enter_Any_Exception_Emails_Here@{0}", EnvironmentVars.DOMAIN_EMAIL) };

		public LicenseQuery()
		{
			InitializeComponent();
			
			FormControlHandler.ChangeText(WorkDirText, Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
			FormControlHandler.ChangeTextAndForeColor(ConnectedText, "Checking...", Color.Gold);
			ConsoleText.AppendText("Validating connection to domain..." + Environment.NewLine);

			GetFilesInWorkDir();

			FormControlHandler.Disable(ChangeWorkDirButton);
			FormControlHandler.Disable(QueryCSVButton);
			FormControlHandler.Disable(ClearOutputButton);
			FormControlHandler.Disable(CSVDropDown);

			checkConnectionTimer.Tick += CheckConnectionTimer_Tick;
			checkConnectionTimer.Start();

			containerCheckTimer.Tick += ContainerCheckTimer_Tick;
		}

		private void CheckConnectionTimer_Tick(object sender, EventArgs e)
		{
			checkConnectionTimer.Stop();

			string nl = Environment.NewLine;
			if (runOnce)
			{
				nl = string.Empty;
				runOnce = false;
				checkConnectionTimer.Interval = 1000;
				FormControlHandler.Enable(ChangeWorkDirButton);
				FormControlHandler.Enable(ClearOutputButton);
				FormControlHandler.Enable(CSVDropDown);
			}

			if (ADHandler.Connected == ConnectionState.Connected)
			{
				reportedDisconnect = false;
				if (!isConnected)
				{
					ConsoleText.AppendText(nl + "Domain connection validated" + Environment.NewLine + Environment.NewLine);
					isConnected = true;
					if (!ADHandler.TasksActive)
					{
						FormControlHandler.ChangeTextAndForeColor(TotalUsersText, string.Empty, Color.Gainsboro);
						FormControlHandler.ChangeTextAndForeColor(EnabledUsersText, string.Empty, Color.Gainsboro);
						FormControlHandler.ChangeTextAndForeColor(DisabledUsersText, string.Empty, Color.Gainsboro);
						FormControlHandler.ChangeTextAndForeColor(StatusText, "Idle", Color.DeepSkyBlue);
						FormControlHandler.SetProgressValue(UserCheckProgress, 0);
					}
				}
				FormControlHandler.ChangeTextAndForeColor(ConnectedText, "Connected", Color.ForestGreen);
			}
			else
			{
				isConnected = false;
				if (!reportedDisconnect)
				{
					reportedDisconnect = true;
					ConsoleText.AppendText("Domain unreachable, will keep trying until available..." + Environment.NewLine + Environment.NewLine);
				}
				FormControlHandler.ChangeTextAndForeColor(ConnectedText, "Unreachable", Color.OrangeRed);
				FormControlHandler.ChangeTextAndForeColor(TotalUsersText, "N/A", Color.OrangeRed);
				FormControlHandler.ChangeTextAndForeColor(EnabledUsersText, "N/A", Color.OrangeRed);
				FormControlHandler.ChangeTextAndForeColor(DisabledUsersText, "N/A", Color.OrangeRed);
				FormControlHandler.ChangeTextAndForeColor(StatusText, "N/A", Color.OrangeRed);
			}

			checkConnectionTimer.Start();
		}

		private void ContainerCheckTimer_Tick(object sender, EventArgs e)
		{
			if (ADHandler.Connected != ConnectionState.Connected || !ADHandler.TasksActive)
			{
				containerCheckTimer.Stop();

				FormControlHandler.ChangeText(EnabledUsersText, ADHandler.EnabledUsers.Count.ToString());
				FormControlHandler.ChangeText(DisabledUsersText, ADHandler.DisabledUsers.Count.ToString());
				FormControlHandler.ChangeTextAndForeColor(StatusText, "Completed", Color.ForestGreen);
				FormControlHandler.Enable(ChangeWorkDirButton);
				FormControlHandler.Enable(CSVDropDown);
				FormControlHandler.Enable(QueryCSVButton);
				FormControlHandler.Enable(ClearOutputButton);

				if (ADHandler.Connected != ConnectionState.Connected)
				{
					ConsoleText.AppendText("Error connecting to domain, please try again..." + Environment.NewLine + Environment.NewLine);
					FormControlHandler.ChangeTextAndForeColor(StatusText, "N/A", Color.OrangeRed);
				}
				else
				{
					ConsoleText.AppendText(Environment.NewLine);

					ConsoleText.AppendText(ADHandler.EnabledUsers.Count.ToString() + " enabled user" + Plural(ADHandler.EnabledUsers.Count) + " found" + Environment.NewLine);
					ConsoleText.AppendText(ADHandler.DisabledUsers.Count.ToString() + " disabled user" + Plural(ADHandler.DisabledUsers.Count) + " found" + Environment.NewLine + Environment.NewLine);
					if (ADHandler.DisabledUsers.Count > 0)
					{
						int i = 1;
						foreach (User disabledUser in ADHandler.DisabledUsers)
						{
							Dictionary<string, License> userLicenses = CSVHandler.GetLicensesByEmail(currentSheet, disabledUser.EmailAddress);
							ConsoleText.AppendText("User " + i.ToString() + ":   " + disabledUser.EmailAddress + Environment.NewLine);
							LicenseLines(userLicenses, new List<string>());
							ConsoleText.AppendText(Environment.NewLine);
							++i;
						}
						ConsoleText.AppendText(Environment.NewLine);
					}
				}

				currentSheet = -1;
			}
			else
			{
				FormControlHandler.ChangeText(EnabledUsersText, ADHandler.EnabledUsers.Count.ToString());
				FormControlHandler.ChangeText(DisabledUsersText, ADHandler.DisabledUsers.Count.ToString());
				FormControlHandler.SetProgressValue(UserCheckProgress, ADHandler.EnabledUsers.Count + ADHandler.DisabledUsers.Count);
			}
		}

		private void GetFilesInWorkDir()
		{
			FormControlHandler.Disable(QueryCSVButton);
			FormControlHandler.Disable(CSVDropDown);
			CSVDropDown.Items.Clear();
			string[] files = Directory.GetFiles(WorkDirText.Text, "*.csv");
			for (int i = 0; i != files.Length; ++i)
				CSVDropDown.Items.Add(Path.GetFileName(files[i]));
			FormControlHandler.Enable(CSVDropDown);
		}

		private string Plural(int p)
		{
			if (p == 1)
				return "";
			return "s";
		}

		private void LicenseLines(Dictionary<string, License> licenses, List<string> props)
		{
			foreach (License l in licenses.Values)
			{
				string line = "   LicenseID:   " + l.LicenseID + "          CustomerID:   " + l.CustomerID;
				for (int i = 0; i != props.Count; ++i)
					line += "          " + props[i] + ":   " + l[props[i]];
				ConsoleText.AppendText(line + Environment.NewLine);
			}
		}

		private void ChangeWorkDirButton_Click(object sender, EventArgs e)
		{
			try
			{
				using (CommonOpenFileDialog openFolderDialog = new CommonOpenFileDialog() { IsFolderPicker = true })
				{
					if (openFolderDialog.ShowDialog() == CommonFileDialogResult.Ok)
					{
						FormControlHandler.ChangeText(WorkDirText, openFolderDialog.FileName);
						FormControlHandler.ChangeText(LicenseCountText, string.Empty);
						FormControlHandler.ChangeText(EnabledCustomersText, string.Empty);
						FormControlHandler.ChangeText(DisabledCustomersText, string.Empty);
						FormControlHandler.ChangeText(MissingFirstNameText, string.Empty);
						FormControlHandler.ChangeText(MissingLastNameText, string.Empty);
						FormControlHandler.ChangeText(MissingEmailText, string.Empty);
						FormControlHandler.ChangeText(DomainEmailText, string.Empty);
						FormControlHandler.ChangeText(NonDomainEmailText, string.Empty);
						if (ADHandler.Connected == ConnectionState.Connected)
						{
							FormControlHandler.ChangeText(TotalUsersText, string.Empty);
							FormControlHandler.ChangeText(EnabledUsersText, string.Empty);
							FormControlHandler.ChangeText(DisabledUsersText, string.Empty);
						}
						GetFilesInWorkDir();
						CSVDropDown.Select();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\r\nIn LicenseQuery.btnChangeWorkDir_Click", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CSVDropDown_SelectedIndexChanged(object sender, EventArgs e)
		{
			FormControlHandler.ChangeText(LicenseCountText, string.Empty);
			FormControlHandler.ChangeText(EnabledCustomersText, string.Empty);
			FormControlHandler.ChangeText(DisabledCustomersText, string.Empty);
			FormControlHandler.ChangeText(MissingFirstNameText, string.Empty);
			FormControlHandler.ChangeText(MissingLastNameText, string.Empty);
			FormControlHandler.ChangeText(MissingEmailText, string.Empty);
			FormControlHandler.ChangeText(DomainEmailText, string.Empty);
			FormControlHandler.ChangeText(NonDomainEmailText, string.Empty);
			if (ADHandler.Connected == ConnectionState.Connected)
			{
				FormControlHandler.ChangeText(TotalUsersText, string.Empty);
				FormControlHandler.ChangeText(EnabledUsersText, string.Empty);
				FormControlHandler.ChangeText(DisabledUsersText, string.Empty);
			}
				
			FormControlHandler.Enable(QueryCSVButton);
			QueryCSVButton.Select();
		}

		private void QueryCSVButton_Click(object sender, EventArgs e)
		{
			FormControlHandler.Disable(QueryCSVButton);
			FormControlHandler.Disable(ChangeWorkDirButton);
			FormControlHandler.Disable(ClearOutputButton);
			FormControlHandler.Disable(CSVDropDown);
			FormControlHandler.SetProgressValue(UserCheckProgress, 0);

			string selectedCSV = CSVDropDown.SelectedItem.ToString();
			ConsoleText.AppendText("Querying CSV file \"" + selectedCSV + "\", please wait..." + Environment.NewLine);

			CSVHandler.AddCSVSheetAtPath(WorkDirText.Text + "\\" + selectedCSV);
			Dictionary<string, Dictionary<string, License>> records = new Dictionary<string, Dictionary<string, License>>();
			int licenseCount;

			currentSheet = CSVHandler.GetSheetIndexByName(Path.GetFileNameWithoutExtension(CSVDropDown.SelectedItem.ToString()));
			if (currentSheet != -1)
			{
				licenseCount = CSVHandler.Sheets[currentSheet].Rows.Count;

				records.Add("EnabledCustomers", CSVHandler.GetEnabledCustomerRecords(currentSheet));
				records.Add("DisabledCustomers", CSVHandler.GetDisabledCustomerRecords(currentSheet));
				records.Add("MissingFirstName", CSVHandler.GetMissingFirstNameRecords(currentSheet));
				records.Add("MissingLastName", CSVHandler.GetMissingLastNameRecords(currentSheet));
				records.Add("MissingEmail", CSVHandler.GetMissingEmailRecords(currentSheet));
				records.Add("DomainEmail", CSVHandler.GetDomainEmailRecords(currentSheet));
				records.Add("NonDomainEmail", CSVHandler.GetNonDomainEmailRecords(currentSheet));

				FormControlHandler.ChangeText(LicenseCountText, licenseCount.ToString());
				FormControlHandler.ChangeText(EnabledCustomersText, records["EnabledCustomers"].Count.ToString());
				FormControlHandler.ChangeText(DisabledCustomersText, records["DisabledCustomers"].Count.ToString());
				FormControlHandler.ChangeText(MissingFirstNameText, records["MissingFirstName"].Count.ToString());
				FormControlHandler.ChangeText(MissingLastNameText, records["MissingLastName"].Count.ToString());
				FormControlHandler.ChangeText(MissingEmailText, records["MissingEmail"].Count.ToString());
				FormControlHandler.ChangeText(DomainEmailText, records["DomainEmail"].Count.ToString());
				FormControlHandler.ChangeText(NonDomainEmailText, records["NonDomainEmail"].Count.ToString());

				ConsoleText.AppendText(licenseCount.ToString() + " total license" + Plural(licenseCount) + Environment.NewLine);
				ConsoleText.AppendText(records["EnabledCustomers"].Count.ToString() + " enabled customer" + Plural(records["EnabledCustomers"].Count) + Environment.NewLine);

				ConsoleText.AppendText(records["DisabledCustomers"].Count.ToString() + " disabled customer" + Plural(records["DisabledCustomers"].Count) + Environment.NewLine);
				LicenseLines(records["DisabledCustomers"], new List<string>() { "ContactName" });

				ConsoleText.AppendText(records["MissingFirstName"].Count.ToString() + " customer" + Plural(records["MissingFirstName"].Count) + " missing first name" + Environment.NewLine);
				LicenseLines(records["MissingFirstName"], new List<string>() { "EMail" });

				ConsoleText.AppendText(records["MissingLastName"].Count.ToString() + " customer" + Plural(records["MissingLastName"].Count) + " missing last name" + Environment.NewLine);
				LicenseLines(records["MissingLastName"], new List<string>() { "EMail" });

				ConsoleText.AppendText(records["MissingEmail"].Count.ToString() + " customer" + Plural(records["MissingEmail"].Count) + " missing email" + Environment.NewLine);
				LicenseLines(records["MissingEmail"], new List<string>() { "ContactName" });

				ConsoleText.AppendText(records["DomainEmail"].Count.ToString() + " customer" + Plural(records["DomainEmail"].Count) + " with domain email" + Environment.NewLine);

				ConsoleText.AppendText(records["NonDomainEmail"].Count.ToString() + " customer" + Plural(records["NonDomainEmail"].Count) + " with non-domain email" + Environment.NewLine);
				LicenseLines(records["NonDomainEmail"], new List<string>() { "EMail" });

				ConsoleText.AppendText(Environment.NewLine);

				if (ADHandler.Connected == ConnectionState.Connected)
				{
					ADHandler.ClearConcurrentCollections();

					FormControlHandler.ChangeText(EnabledUsersText, "0");
					FormControlHandler.ChangeText(DisabledUsersText, "0");

					Dictionary<string, License> usersToCheck = CSVHandler.GetEnabledCustomerRecordsWithDomainEmail(currentSheet);
					HashSet<string> uniqueUsersToCheck = new HashSet<string>();

					foreach (License l in usersToCheck.Values)
						if (!uniqueUsersToCheck.Contains(l.EMail) && !userExceptions.Contains(l.EMail))
							uniqueUsersToCheck.Add(l.EMail);

					FormControlHandler.ChangeTextAndForeColor(StatusText, "Searching...", Color.Gold);
					FormControlHandler.SetProgressMax(UserCheckProgress, uniqueUsersToCheck.Count);

					int i = 0;
					foreach (string u in uniqueUsersToCheck)
					{
						ADHandler.Searchers[i % ADHandler.Searchers.Length].Users.Enqueue(new User() { EmailAddress = u, Enabled = "False" });
						++i;
					}

					FormControlHandler.ChangeText(TotalUsersText, uniqueUsersToCheck.Count.ToString());

					ConsoleText.AppendText("Checking for disabled users in Active Directory based on email" + Environment.NewLine);
					ConsoleText.AppendText(uniqueUsersToCheck.Count.ToString() + " users to check, please wait, this may take a while..." + Environment.NewLine);

					ADHandler.ProcessUsers();
					containerCheckTimer.Start();
				}
			}

			FormControlHandler.Enable(QueryCSVButton);
			FormControlHandler.Enable(ChangeWorkDirButton);
			FormControlHandler.Enable(ClearOutputButton);
			FormControlHandler.Enable(CSVDropDown);
		}

		private void ClearOutputButton_Click(object sender, EventArgs e)
		{
			ConsoleText.Clear();
		}
	}
}
