using System;
using System.Diagnostics;


namespace LicenseQuery
{
	public static class ConnectionHelper
	{
		public static bool IsReachable(string address)
		{
			ProcessStartInfo pingInfo = new ProcessStartInfo(fileName: "ping.exe");
			pingInfo.Arguments = address + " -4 -n 1";
			pingInfo.WorkingDirectory = Environment.GetEnvironmentVariable("SystemRoot") + "\\System32";
			pingInfo.CreateNoWindow = true;
			pingInfo.RedirectStandardOutput = true;
			pingInfo.RedirectStandardError = true;
			pingInfo.WindowStyle = ProcessWindowStyle.Hidden;
			pingInfo.UseShellExecute = false;

			Process ping = new Process();
			ping.StartInfo = pingInfo;
			ping.Start();

			while (!ping.HasExited) { }

			string pingResults = ping.StandardOutput.ReadToEnd();

			ping.Close();

			if (pingResults.Contains("Destination host unreachable") ||
				pingResults.Contains("Ping request could not find host") ||
				pingResults.Contains("PING: transmit failed") ||
				pingResults.Contains("Request timed out") ||
				pingResults.Contains("100% loss"))
				return false;

			return true;
		}
	}
}
