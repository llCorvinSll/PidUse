using System;
using System.Diagnostics;

namespace PidUse
{
	class Program
	{
		static void Main(string[] args)
		{
			Process[] proc = Process.GetProcessesByName(@"Skype"); //uTorrent

			Console.WriteLine($"{proc[0].ProcessName}");

			var task = Win32Processes.GetFilesLockedBy(proc[0]);
			
			task.Wait();

			var files = task.Result;

			foreach(var file in files)
			{
				Console.WriteLine(file);
			}

			Console.WriteLine("FIN");
			Console.ReadKey();

		}
	}
}
