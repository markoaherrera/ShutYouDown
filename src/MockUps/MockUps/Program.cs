using System;
using System.Threading;
using System.Threading.Tasks;

namespace MockUps
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			int waitTime = 0;
			if (args.Length > 0 && !Int32.TryParse (args [0], out waitTime)) {
				Console.WriteLine ("{0} is not a integer", args[0]);
				return;
			}

			Wait (waitTime);

			ShellExecuter.ExecuteCommand ("poweroff");


		}

		public static void Wait(int waitTime)
		{
			TimeSpan minute = new TimeSpan (0, 1, 0);
			for (int i = 1; i <= waitTime; i++) {
				Console.WriteLine ("Minute {0}", i);
				Thread.Sleep (minute);
				//await Task.Delay(minute);
			}
		}
	}
}
