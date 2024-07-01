using System;
using System.IO;
using Gtk;

namespace Project.Infrastructure
{
	public class ApplicationGTK : IGLApplication
	{
		public ApplicationGTK ()
		{
			// без этого, программа использующая GTK и скомпелированная на MonoDevelop на Linux,
			// не запуститься на Windows c установленым GTK. (по крайней мере у меня)
			File.Copy("DllBackup/Mono.Posix.dll", "Mono.Posix.dll", true); 

			Application.Init ();
		}
			
		public void StartProgram()
		{
			Application.Run ();
		}

		public void FinishProgram()
		{
			Application.Quit ();
		}
	}
}

