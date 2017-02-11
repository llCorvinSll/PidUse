using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PidUse
{
	class Program
	{
		static void Main(string[] args)
		{
			Process proc = Process.GetProcessById(5728);

			Console.WriteLine($"{proc.ProcessName}");

			var files = Win32Processes.GetFilesLockedBy(proc);

			foreach(var file in files)
			{
				Console.WriteLine(file);
			}

			Console.WriteLine("FIN");
			Console.ReadKey();

		}
	}
}
