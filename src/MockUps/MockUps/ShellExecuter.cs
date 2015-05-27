using System;
using System.Diagnostics;

namespace MockUps
{
	public class ShellExecuter
	{
		public ShellExecuter ()
		{
		}

		public static void ExecuteCommand(string command)
		{
			Process proc = new Process ();
			proc.StartInfo.FileName = command;
			// proc.StartInfo.Arguments = "";
			proc.StartInfo.UseShellExecute = false;
			proc.StartInfo.RedirectStandardError = true;
			proc.StartInfo.RedirectStandardInput = true;
			proc.StartInfo.RedirectStandardOutput = true;
			proc.Start ();
			var output = proc.StandardOutput.ReadToEnd ();
			Console.WriteLine (output);
		}
	}
}

