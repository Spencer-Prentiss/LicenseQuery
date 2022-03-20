using System;
using System.Windows.Forms;


namespace LicenseQuery
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			ADHandler.Initialize();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LicenseQuery());
		}
	}
}
