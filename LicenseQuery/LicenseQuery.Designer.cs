namespace LicenseQuery
{
	partial class LicenseQuery
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseQuery));
            this.lblWorkDir = new System.Windows.Forms.Label();
            this.lblCSVDropdown = new System.Windows.Forms.Label();
            this.CSVDropDown = new System.Windows.Forms.ComboBox();
            this.ChangeWorkDirButton = new System.Windows.Forms.Button();
            this.QueryCSVButton = new System.Windows.Forms.Button();
            this.LicenseCountLabel = new System.Windows.Forms.Label();
            this.EnabledCustomersLabel = new System.Windows.Forms.Label();
            this.DisabledCustomersLabel = new System.Windows.Forms.Label();
            this.DisabledUsersLabel = new System.Windows.Forms.Label();
            this.ClearOutputButton = new System.Windows.Forms.Button();
            this.ConsoleText = new System.Windows.Forms.TextBox();
            this.csvGroup = new System.Windows.Forms.GroupBox();
            this.DomainEmailLabel = new System.Windows.Forms.Label();
            this.DomainEmailText = new System.Windows.Forms.Label();
            this.NonDomainEmailLabel = new System.Windows.Forms.Label();
            this.MissingEmailLabel = new System.Windows.Forms.Label();
            this.MissingLastNameLabel = new System.Windows.Forms.Label();
            this.MissingFirstNameLabel = new System.Windows.Forms.Label();
            this.NonDomainEmailText = new System.Windows.Forms.Label();
            this.MissingEmailText = new System.Windows.Forms.Label();
            this.MissingLastNameText = new System.Windows.Forms.Label();
            this.MissingFirstNameText = new System.Windows.Forms.Label();
            this.DisabledCustomersText = new System.Windows.Forms.Label();
            this.EnabledCustomersText = new System.Windows.Forms.Label();
            this.LicenseCountText = new System.Windows.Forms.Label();
            this.domainGroup = new System.Windows.Forms.GroupBox();
            this.StatusText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserCheckProgress = new System.Windows.Forms.ProgressBar();
            this.TotalUsersLabel = new System.Windows.Forms.Label();
            this.TotalUsersText = new System.Windows.Forms.Label();
            this.EnabledUsersLabel = new System.Windows.Forms.Label();
            this.EnabledUsersText = new System.Windows.Forms.Label();
            this.DisabledUsersText = new System.Windows.Forms.Label();
            this.ConnectedText = new System.Windows.Forms.Label();
            this.ConnectedLabel = new System.Windows.Forms.Label();
            this.WorkDirText = new System.Windows.Forms.Label();
            this.csvGroup.SuspendLayout();
            this.domainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWorkDir
            // 
            this.lblWorkDir.AutoSize = true;
            this.lblWorkDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblWorkDir.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblWorkDir.Location = new System.Drawing.Point(16, 16);
            this.lblWorkDir.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWorkDir.MinimumSize = new System.Drawing.Size(0, 24);
            this.lblWorkDir.Name = "lblWorkDir";
            this.lblWorkDir.Size = new System.Drawing.Size(129, 24);
            this.lblWorkDir.TabIndex = 0;
            this.lblWorkDir.Text = "Working Directory:";
            this.lblWorkDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCSVDropdown
            // 
            this.lblCSVDropdown.AutoSize = true;
            this.lblCSVDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblCSVDropdown.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCSVDropdown.Location = new System.Drawing.Point(35, 48);
            this.lblCSVDropdown.MinimumSize = new System.Drawing.Size(0, 24);
            this.lblCSVDropdown.Name = "lblCSVDropdown";
            this.lblCSVDropdown.Size = new System.Drawing.Size(111, 24);
            this.lblCSVDropdown.TabIndex = 2;
            this.lblCSVDropdown.Text = "Select CSV File:";
            this.lblCSVDropdown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CSVDropDown
            // 
            this.CSVDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CSVDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CSVDropDown.ForeColor = System.Drawing.Color.Gainsboro;
            this.CSVDropDown.FormattingEnabled = true;
            this.CSVDropDown.Location = new System.Drawing.Point(157, 47);
            this.CSVDropDown.MaximumSize = new System.Drawing.Size(800, 0);
            this.CSVDropDown.MinimumSize = new System.Drawing.Size(800, 0);
            this.CSVDropDown.Name = "CSVDropDown";
            this.CSVDropDown.Size = new System.Drawing.Size(800, 23);
            this.CSVDropDown.Sorted = true;
            this.CSVDropDown.TabIndex = 1;
            this.CSVDropDown.SelectedIndexChanged += new System.EventHandler(this.CSVDropDown_SelectedIndexChanged);
            // 
            // ChangeWorkDirButton
            // 
            this.ChangeWorkDirButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ChangeWorkDirButton.Location = new System.Drawing.Point(968, 15);
            this.ChangeWorkDirButton.Name = "ChangeWorkDirButton";
            this.ChangeWorkDirButton.Size = new System.Drawing.Size(200, 25);
            this.ChangeWorkDirButton.TabIndex = 0;
            this.ChangeWorkDirButton.Text = "Change Working Directory";
            this.ChangeWorkDirButton.UseVisualStyleBackColor = true;
            this.ChangeWorkDirButton.Click += new System.EventHandler(this.ChangeWorkDirButton_Click);
            // 
            // QueryCSVButton
            // 
            this.QueryCSVButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.QueryCSVButton.Location = new System.Drawing.Point(968, 46);
            this.QueryCSVButton.Name = "QueryCSVButton";
            this.QueryCSVButton.Size = new System.Drawing.Size(200, 25);
            this.QueryCSVButton.TabIndex = 2;
            this.QueryCSVButton.Text = "Query Selected CSV";
            this.QueryCSVButton.UseVisualStyleBackColor = true;
            this.QueryCSVButton.Click += new System.EventHandler(this.QueryCSVButton_Click);
            // 
            // LicenseCountLabel
            // 
            this.LicenseCountLabel.AutoSize = true;
            this.LicenseCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LicenseCountLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.LicenseCountLabel.Location = new System.Drawing.Point(50, 24);
            this.LicenseCountLabel.MinimumSize = new System.Drawing.Size(0, 24);
            this.LicenseCountLabel.Name = "LicenseCountLabel";
            this.LicenseCountLabel.Size = new System.Drawing.Size(105, 24);
            this.LicenseCountLabel.TabIndex = 4;
            this.LicenseCountLabel.Text = "Total Licenses:";
            this.LicenseCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnabledCustomersLabel
            // 
            this.EnabledCustomersLabel.AutoSize = true;
            this.EnabledCustomersLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EnabledCustomersLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.EnabledCustomersLabel.Location = new System.Drawing.Point(17, 52);
            this.EnabledCustomersLabel.MinimumSize = new System.Drawing.Size(0, 24);
            this.EnabledCustomersLabel.Name = "EnabledCustomersLabel";
            this.EnabledCustomersLabel.Size = new System.Drawing.Size(138, 24);
            this.EnabledCustomersLabel.TabIndex = 7;
            this.EnabledCustomersLabel.Text = "Enabled Customers:";
            this.EnabledCustomersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DisabledCustomersLabel
            // 
            this.DisabledCustomersLabel.AutoSize = true;
            this.DisabledCustomersLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DisabledCustomersLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.DisabledCustomersLabel.Location = new System.Drawing.Point(13, 80);
            this.DisabledCustomersLabel.MinimumSize = new System.Drawing.Size(0, 24);
            this.DisabledCustomersLabel.Name = "DisabledCustomersLabel";
            this.DisabledCustomersLabel.Size = new System.Drawing.Size(142, 24);
            this.DisabledCustomersLabel.TabIndex = 8;
            this.DisabledCustomersLabel.Text = "Disabled Customers:";
            this.DisabledCustomersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DisabledUsersLabel
            // 
            this.DisabledUsersLabel.AutoSize = true;
            this.DisabledUsersLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DisabledUsersLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.DisabledUsersLabel.Location = new System.Drawing.Point(46, 108);
            this.DisabledUsersLabel.MinimumSize = new System.Drawing.Size(0, 24);
            this.DisabledUsersLabel.Name = "DisabledUsersLabel";
            this.DisabledUsersLabel.Size = new System.Drawing.Size(109, 24);
            this.DisabledUsersLabel.TabIndex = 9;
            this.DisabledUsersLabel.Text = "Disabled Users:";
            this.DisabledUsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClearOutputButton
            // 
            this.ClearOutputButton.Location = new System.Drawing.Point(19, 591);
            this.ClearOutputButton.Name = "ClearOutputButton";
            this.ClearOutputButton.Size = new System.Drawing.Size(280, 25);
            this.ClearOutputButton.TabIndex = 5;
            this.ClearOutputButton.Text = "Clear Console Output";
            this.ClearOutputButton.UseVisualStyleBackColor = true;
            this.ClearOutputButton.Click += new System.EventHandler(this.ClearOutputButton_Click);
            // 
            // ConsoleText
            // 
            this.ConsoleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ConsoleText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleText.ForeColor = System.Drawing.Color.Gainsboro;
            this.ConsoleText.Location = new System.Drawing.Point(316, 93);
            this.ConsoleText.Multiline = true;
            this.ConsoleText.Name = "ConsoleText";
            this.ConsoleText.ReadOnly = true;
            this.ConsoleText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleText.Size = new System.Drawing.Size(850, 523);
            this.ConsoleText.TabIndex = 17;
            this.ConsoleText.TabStop = false;
            // 
            // csvGroup
            // 
            this.csvGroup.Controls.Add(this.DomainEmailLabel);
            this.csvGroup.Controls.Add(this.DomainEmailText);
            this.csvGroup.Controls.Add(this.NonDomainEmailLabel);
            this.csvGroup.Controls.Add(this.MissingEmailLabel);
            this.csvGroup.Controls.Add(this.MissingLastNameLabel);
            this.csvGroup.Controls.Add(this.MissingFirstNameLabel);
            this.csvGroup.Controls.Add(this.NonDomainEmailText);
            this.csvGroup.Controls.Add(this.MissingEmailText);
            this.csvGroup.Controls.Add(this.MissingLastNameText);
            this.csvGroup.Controls.Add(this.MissingFirstNameText);
            this.csvGroup.Controls.Add(this.DisabledCustomersText);
            this.csvGroup.Controls.Add(this.EnabledCustomersText);
            this.csvGroup.Controls.Add(this.LicenseCountText);
            this.csvGroup.Controls.Add(this.LicenseCountLabel);
            this.csvGroup.Controls.Add(this.EnabledCustomersLabel);
            this.csvGroup.Controls.Add(this.DisabledCustomersLabel);
            this.csvGroup.ForeColor = System.Drawing.Color.Gray;
            this.csvGroup.Location = new System.Drawing.Point(19, 85);
            this.csvGroup.Name = "csvGroup";
            this.csvGroup.Size = new System.Drawing.Size(280, 264);
            this.csvGroup.TabIndex = 18;
            this.csvGroup.TabStop = false;
            this.csvGroup.Text = "CSV Information";
            // 
            // DomainEmailLabel
            // 
            this.DomainEmailLabel.AutoSize = true;
            this.DomainEmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DomainEmailLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.DomainEmailLabel.Location = new System.Drawing.Point(83, 192);
            this.DomainEmailLabel.MinimumSize = new System.Drawing.Size(0, 24);
            this.DomainEmailLabel.Name = "DomainEmailLabel";
            this.DomainEmailLabel.Size = new System.Drawing.Size(72, 24);
            this.DomainEmailLabel.TabIndex = 21;
            this.DomainEmailLabel.Text = "Domain Email:";
            this.DomainEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DomainEmailText
            // 
            this.DomainEmailText.AutoSize = true;
            this.DomainEmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.DomainEmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DomainEmailText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DomainEmailText.ForeColor = System.Drawing.Color.Gainsboro;
            this.DomainEmailText.Location = new System.Drawing.Point(164, 192);
            this.DomainEmailText.MaximumSize = new System.Drawing.Size(100, 25);
            this.DomainEmailText.MinimumSize = new System.Drawing.Size(100, 25);
            this.DomainEmailText.Name = "DomainEmailText";
            this.DomainEmailText.Padding = new System.Windows.Forms.Padding(0, 0, 29, 0);
            this.DomainEmailText.Size = new System.Drawing.Size(100, 25);
            this.DomainEmailText.TabIndex = 20;
            this.DomainEmailText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NonDomainEmailLabel
            // 
            this.NonDomainEmailLabel.AutoSize = true;
            this.NonDomainEmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NonDomainEmailLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.NonDomainEmailLabel.Location = new System.Drawing.Point(53, 220);
            this.NonDomainEmailLabel.MinimumSize = new System.Drawing.Size(0, 24);
            this.NonDomainEmailLabel.Name = "NonDomainEmailLabel";
            this.NonDomainEmailLabel.Size = new System.Drawing.Size(102, 24);
            this.NonDomainEmailLabel.TabIndex = 19;
            this.NonDomainEmailLabel.Text = "Non-Domain Email:";
            this.NonDomainEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MissingEmailLabel
            // 
            this.MissingEmailLabel.AutoSize = true;
            this.MissingEmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MissingEmailLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.MissingEmailLabel.Location = new System.Drawing.Point(55, 164);
            this.MissingEmailLabel.MinimumSize = new System.Drawing.Size(0, 24);
            this.MissingEmailLabel.Name = "MissingEmailLabel";
            this.MissingEmailLabel.Size = new System.Drawing.Size(100, 24);
            this.MissingEmailLabel.TabIndex = 18;
            this.MissingEmailLabel.Text = "Missing Email:";
            this.MissingEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MissingLastNameLabel
            // 
            this.MissingLastNameLabel.AutoSize = true;
            this.MissingLastNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MissingLastNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.MissingLastNameLabel.Location = new System.Drawing.Point(23, 136);
            this.MissingLastNameLabel.MinimumSize = new System.Drawing.Size(0, 24);
            this.MissingLastNameLabel.Name = "MissingLastNameLabel";
            this.MissingLastNameLabel.Size = new System.Drawing.Size(132, 24);
            this.MissingLastNameLabel.TabIndex = 17;
            this.MissingLastNameLabel.Text = "Missing Last Name:";
            this.MissingLastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MissingFirstNameLabel
            // 
            this.MissingFirstNameLabel.AutoSize = true;
            this.MissingFirstNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MissingFirstNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.MissingFirstNameLabel.Location = new System.Drawing.Point(21, 108);
            this.MissingFirstNameLabel.MinimumSize = new System.Drawing.Size(0, 24);
            this.MissingFirstNameLabel.Name = "MissingFirstNameLabel";
            this.MissingFirstNameLabel.Size = new System.Drawing.Size(134, 24);
            this.MissingFirstNameLabel.TabIndex = 16;
            this.MissingFirstNameLabel.Text = "Missing First Name:";
            this.MissingFirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NonDomainEmailText
            // 
            this.NonDomainEmailText.AutoSize = true;
            this.NonDomainEmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.NonDomainEmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NonDomainEmailText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NonDomainEmailText.ForeColor = System.Drawing.Color.Gainsboro;
            this.NonDomainEmailText.Location = new System.Drawing.Point(164, 220);
            this.NonDomainEmailText.MaximumSize = new System.Drawing.Size(100, 25);
            this.NonDomainEmailText.MinimumSize = new System.Drawing.Size(100, 25);
            this.NonDomainEmailText.Name = "NonDomainEmailText";
            this.NonDomainEmailText.Padding = new System.Windows.Forms.Padding(0, 0, 29, 0);
            this.NonDomainEmailText.Size = new System.Drawing.Size(100, 25);
            this.NonDomainEmailText.TabIndex = 15;
            this.NonDomainEmailText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MissingEmailText
            // 
            this.MissingEmailText.AutoSize = true;
            this.MissingEmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.MissingEmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MissingEmailText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MissingEmailText.ForeColor = System.Drawing.Color.Gainsboro;
            this.MissingEmailText.Location = new System.Drawing.Point(164, 164);
            this.MissingEmailText.MaximumSize = new System.Drawing.Size(100, 25);
            this.MissingEmailText.MinimumSize = new System.Drawing.Size(100, 25);
            this.MissingEmailText.Name = "MissingEmailText";
            this.MissingEmailText.Padding = new System.Windows.Forms.Padding(0, 0, 29, 0);
            this.MissingEmailText.Size = new System.Drawing.Size(100, 25);
            this.MissingEmailText.TabIndex = 14;
            this.MissingEmailText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MissingLastNameText
            // 
            this.MissingLastNameText.AutoSize = true;
            this.MissingLastNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.MissingLastNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MissingLastNameText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MissingLastNameText.ForeColor = System.Drawing.Color.Gainsboro;
            this.MissingLastNameText.Location = new System.Drawing.Point(164, 136);
            this.MissingLastNameText.MaximumSize = new System.Drawing.Size(100, 25);
            this.MissingLastNameText.MinimumSize = new System.Drawing.Size(100, 25);
            this.MissingLastNameText.Name = "MissingLastNameText";
            this.MissingLastNameText.Padding = new System.Windows.Forms.Padding(0, 0, 29, 0);
            this.MissingLastNameText.Size = new System.Drawing.Size(100, 25);
            this.MissingLastNameText.TabIndex = 13;
            this.MissingLastNameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MissingFirstNameText
            // 
            this.MissingFirstNameText.AutoSize = true;
            this.MissingFirstNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.MissingFirstNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MissingFirstNameText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MissingFirstNameText.ForeColor = System.Drawing.Color.Gainsboro;
            this.MissingFirstNameText.Location = new System.Drawing.Point(164, 108);
            this.MissingFirstNameText.MaximumSize = new System.Drawing.Size(100, 25);
            this.MissingFirstNameText.MinimumSize = new System.Drawing.Size(100, 25);
            this.MissingFirstNameText.Name = "MissingFirstNameText";
            this.MissingFirstNameText.Padding = new System.Windows.Forms.Padding(0, 0, 29, 0);
            this.MissingFirstNameText.Size = new System.Drawing.Size(100, 25);
            this.MissingFirstNameText.TabIndex = 12;
            this.MissingFirstNameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DisabledCustomersText
            // 
            this.DisabledCustomersText.AutoSize = true;
            this.DisabledCustomersText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.DisabledCustomersText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisabledCustomersText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisabledCustomersText.ForeColor = System.Drawing.Color.Gainsboro;
            this.DisabledCustomersText.Location = new System.Drawing.Point(164, 80);
            this.DisabledCustomersText.MaximumSize = new System.Drawing.Size(100, 25);
            this.DisabledCustomersText.MinimumSize = new System.Drawing.Size(100, 25);
            this.DisabledCustomersText.Name = "DisabledCustomersText";
            this.DisabledCustomersText.Padding = new System.Windows.Forms.Padding(0, 0, 29, 0);
            this.DisabledCustomersText.Size = new System.Drawing.Size(100, 25);
            this.DisabledCustomersText.TabIndex = 11;
            this.DisabledCustomersText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnabledCustomersText
            // 
            this.EnabledCustomersText.AutoSize = true;
            this.EnabledCustomersText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.EnabledCustomersText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnabledCustomersText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnabledCustomersText.ForeColor = System.Drawing.Color.Gainsboro;
            this.EnabledCustomersText.Location = new System.Drawing.Point(164, 52);
            this.EnabledCustomersText.MaximumSize = new System.Drawing.Size(100, 25);
            this.EnabledCustomersText.MinimumSize = new System.Drawing.Size(100, 25);
            this.EnabledCustomersText.Name = "EnabledCustomersText";
            this.EnabledCustomersText.Padding = new System.Windows.Forms.Padding(0, 0, 29, 0);
            this.EnabledCustomersText.Size = new System.Drawing.Size(100, 25);
            this.EnabledCustomersText.TabIndex = 10;
            this.EnabledCustomersText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LicenseCountText
            // 
            this.LicenseCountText.AutoSize = true;
            this.LicenseCountText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.LicenseCountText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LicenseCountText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LicenseCountText.ForeColor = System.Drawing.Color.Gainsboro;
            this.LicenseCountText.Location = new System.Drawing.Point(164, 24);
            this.LicenseCountText.MaximumSize = new System.Drawing.Size(100, 25);
            this.LicenseCountText.MinimumSize = new System.Drawing.Size(100, 25);
            this.LicenseCountText.Name = "LicenseCountText";
            this.LicenseCountText.Padding = new System.Windows.Forms.Padding(0, 0, 29, 0);
            this.LicenseCountText.Size = new System.Drawing.Size(100, 25);
            this.LicenseCountText.TabIndex = 9;
            this.LicenseCountText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // domainGroup
            // 
            this.domainGroup.Controls.Add(this.StatusText);
            this.domainGroup.Controls.Add(this.label2);
            this.domainGroup.Controls.Add(this.UserCheckProgress);
            this.domainGroup.Controls.Add(this.TotalUsersLabel);
            this.domainGroup.Controls.Add(this.TotalUsersText);
            this.domainGroup.Controls.Add(this.EnabledUsersLabel);
            this.domainGroup.Controls.Add(this.EnabledUsersText);
            this.domainGroup.Controls.Add(this.DisabledUsersText);
            this.domainGroup.Controls.Add(this.ConnectedText);
            this.domainGroup.Controls.Add(this.ConnectedLabel);
            this.domainGroup.Controls.Add(this.DisabledUsersLabel);
            this.domainGroup.ForeColor = System.Drawing.Color.Gray;
            this.domainGroup.Location = new System.Drawing.Point(19, 357);
            this.domainGroup.Name = "domainGroup";
            this.domainGroup.Size = new System.Drawing.Size(280, 217);
            this.domainGroup.TabIndex = 19;
            this.domainGroup.TabStop = false;
            this.domainGroup.Text = "Domain Information";
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.StatusText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusText.ForeColor = System.Drawing.Color.Gainsboro;
            this.StatusText.Location = new System.Drawing.Point(164, 136);
            this.StatusText.MaximumSize = new System.Drawing.Size(100, 25);
            this.StatusText.MinimumSize = new System.Drawing.Size(100, 25);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(100, 25);
            this.StatusText.TabIndex = 24;
            this.StatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(102, 136);
            this.label2.MinimumSize = new System.Drawing.Size(0, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserCheckProgress
            // 
            this.UserCheckProgress.Location = new System.Drawing.Point(17, 176);
            this.UserCheckProgress.Name = "UserCheckProgress";
            this.UserCheckProgress.Size = new System.Drawing.Size(246, 23);
            this.UserCheckProgress.TabIndex = 22;
            // 
            // TotalUsersLabel
            // 
            this.TotalUsersLabel.AutoSize = true;
            this.TotalUsersLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.TotalUsersLabel.Location = new System.Drawing.Point(70, 52);
            this.TotalUsersLabel.MinimumSize = new System.Drawing.Size(0, 24);
            this.TotalUsersLabel.Name = "TotalUsersLabel";
            this.TotalUsersLabel.Size = new System.Drawing.Size(85, 24);
            this.TotalUsersLabel.TabIndex = 21;
            this.TotalUsersLabel.Text = "Total Users:";
            this.TotalUsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalUsersText
            // 
            this.TotalUsersText.AutoSize = true;
            this.TotalUsersText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.TotalUsersText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalUsersText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalUsersText.ForeColor = System.Drawing.Color.Gainsboro;
            this.TotalUsersText.Location = new System.Drawing.Point(164, 52);
            this.TotalUsersText.MaximumSize = new System.Drawing.Size(100, 25);
            this.TotalUsersText.MinimumSize = new System.Drawing.Size(100, 25);
            this.TotalUsersText.Name = "TotalUsersText";
            this.TotalUsersText.Padding = new System.Windows.Forms.Padding(0, 0, 29, 0);
            this.TotalUsersText.Size = new System.Drawing.Size(100, 25);
            this.TotalUsersText.TabIndex = 20;
            this.TotalUsersText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnabledUsersLabel
            // 
            this.EnabledUsersLabel.AutoSize = true;
            this.EnabledUsersLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.EnabledUsersLabel.Location = new System.Drawing.Point(50, 80);
            this.EnabledUsersLabel.MinimumSize = new System.Drawing.Size(0, 24);
            this.EnabledUsersLabel.Name = "EnabledUsersLabel";
            this.EnabledUsersLabel.Size = new System.Drawing.Size(105, 24);
            this.EnabledUsersLabel.TabIndex = 19;
            this.EnabledUsersLabel.Text = "Enabled Users:";
            this.EnabledUsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnabledUsersText
            // 
            this.EnabledUsersText.AutoSize = true;
            this.EnabledUsersText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.EnabledUsersText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnabledUsersText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnabledUsersText.ForeColor = System.Drawing.Color.Gainsboro;
            this.EnabledUsersText.Location = new System.Drawing.Point(164, 80);
            this.EnabledUsersText.MaximumSize = new System.Drawing.Size(100, 25);
            this.EnabledUsersText.MinimumSize = new System.Drawing.Size(100, 25);
            this.EnabledUsersText.Name = "EnabledUsersText";
            this.EnabledUsersText.Padding = new System.Windows.Forms.Padding(0, 0, 29, 0);
            this.EnabledUsersText.Size = new System.Drawing.Size(100, 25);
            this.EnabledUsersText.TabIndex = 18;
            this.EnabledUsersText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DisabledUsersText
            // 
            this.DisabledUsersText.AutoSize = true;
            this.DisabledUsersText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.DisabledUsersText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisabledUsersText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisabledUsersText.ForeColor = System.Drawing.Color.Gainsboro;
            this.DisabledUsersText.Location = new System.Drawing.Point(164, 108);
            this.DisabledUsersText.MaximumSize = new System.Drawing.Size(100, 25);
            this.DisabledUsersText.MinimumSize = new System.Drawing.Size(100, 25);
            this.DisabledUsersText.Name = "DisabledUsersText";
            this.DisabledUsersText.Padding = new System.Windows.Forms.Padding(0, 0, 29, 0);
            this.DisabledUsersText.Size = new System.Drawing.Size(100, 25);
            this.DisabledUsersText.TabIndex = 17;
            this.DisabledUsersText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConnectedText
            // 
            this.ConnectedText.AutoSize = true;
            this.ConnectedText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ConnectedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectedText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectedText.ForeColor = System.Drawing.Color.Gainsboro;
            this.ConnectedText.Location = new System.Drawing.Point(164, 24);
            this.ConnectedText.MaximumSize = new System.Drawing.Size(100, 25);
            this.ConnectedText.MinimumSize = new System.Drawing.Size(100, 25);
            this.ConnectedText.Name = "ConnectedText";
            this.ConnectedText.Size = new System.Drawing.Size(100, 25);
            this.ConnectedText.TabIndex = 12;
            this.ConnectedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectedLabel
            // 
            this.ConnectedLabel.AutoSize = true;
            this.ConnectedLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ConnectedLabel.Location = new System.Drawing.Point(20, 24);
            this.ConnectedLabel.MinimumSize = new System.Drawing.Size(0, 24);
            this.ConnectedLabel.Name = "ConnectedLabel";
            this.ConnectedLabel.Size = new System.Drawing.Size(135, 24);
            this.ConnectedLabel.TabIndex = 16;
            this.ConnectedLabel.Text = "Domain Connected:";
            this.ConnectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkDirText
            // 
            this.WorkDirText.AutoSize = true;
            this.WorkDirText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.WorkDirText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkDirText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkDirText.ForeColor = System.Drawing.Color.Gainsboro;
            this.WorkDirText.Location = new System.Drawing.Point(157, 15);
            this.WorkDirText.MinimumSize = new System.Drawing.Size(800, 25);
            this.WorkDirText.Name = "WorkDirText";
            this.WorkDirText.Size = new System.Drawing.Size(800, 25);
            this.WorkDirText.TabIndex = 20;
            this.WorkDirText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LicenseQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.WorkDirText);
            this.Controls.Add(this.domainGroup);
            this.Controls.Add(this.csvGroup);
            this.Controls.Add(this.ConsoleText);
            this.Controls.Add(this.ClearOutputButton);
            this.Controls.Add(this.QueryCSVButton);
            this.Controls.Add(this.ChangeWorkDirButton);
            this.Controls.Add(this.CSVDropDown);
            this.Controls.Add(this.lblCSVDropdown);
            this.Controls.Add(this.lblWorkDir);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "LicenseQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Query";
            this.csvGroup.ResumeLayout(false);
            this.csvGroup.PerformLayout();
            this.domainGroup.ResumeLayout(false);
            this.domainGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblWorkDir;
		private System.Windows.Forms.Label lblCSVDropdown;
		private System.Windows.Forms.ComboBox CSVDropDown;
		private System.Windows.Forms.Button ChangeWorkDirButton;
		private System.Windows.Forms.Button QueryCSVButton;
		private System.Windows.Forms.Label LicenseCountLabel;
		private System.Windows.Forms.Label EnabledCustomersLabel;
		private System.Windows.Forms.Label DisabledCustomersLabel;
		private System.Windows.Forms.Label DisabledUsersLabel;
		private System.Windows.Forms.Button ClearOutputButton;
		private System.Windows.Forms.TextBox ConsoleText;
		private System.Windows.Forms.GroupBox csvGroup;
		private System.Windows.Forms.GroupBox domainGroup;
		private System.Windows.Forms.Label ConnectedLabel;
		private System.Windows.Forms.Label WorkDirText;
		private System.Windows.Forms.Label DisabledCustomersText;
		private System.Windows.Forms.Label EnabledCustomersText;
		private System.Windows.Forms.Label LicenseCountText;
		private System.Windows.Forms.Label DisabledUsersText;
		private System.Windows.Forms.Label ConnectedText;
		private System.Windows.Forms.Label MissingEmailText;
		private System.Windows.Forms.Label MissingLastNameText;
		private System.Windows.Forms.Label MissingFirstNameText;
		private System.Windows.Forms.Label MissingFirstNameLabel;
		private System.Windows.Forms.Label NonDomainEmailText;
		private System.Windows.Forms.Label NonDomainEmailLabel;
		private System.Windows.Forms.Label MissingEmailLabel;
		private System.Windows.Forms.Label MissingLastNameLabel;
		private System.Windows.Forms.Label DomainEmailLabel;
		private System.Windows.Forms.Label DomainEmailText;
		private System.Windows.Forms.Label EnabledUsersLabel;
		private System.Windows.Forms.Label EnabledUsersText;
		private System.Windows.Forms.Label TotalUsersLabel;
		private System.Windows.Forms.Label TotalUsersText;
		private System.Windows.Forms.ProgressBar UserCheckProgress;
		private System.Windows.Forms.Label StatusText;
		private System.Windows.Forms.Label label2;
	}
}

