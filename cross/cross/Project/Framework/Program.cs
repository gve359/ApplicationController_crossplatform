using System;

using Project.Framework;

namespace cross
{
	internal sealed class MainClass
	{		
		[STAThread]
		public static void Main (string[] args)
		{
			PlatformID os = Environment.OSVersion.Platform;
			IFactoryGUI factoryGUI = (os == PlatformID.Win32NT || os == PlatformID.Win32S || os == PlatformID.Win32Windows || os == PlatformID.WinCE)
  								     ? (IFactoryGUI)new FactoryWinForms()
									 : (IFactoryGUI)new FactoryGUI_GTK();									 		
									 			
			new ApplicationController(factoryGUI.GetIGLApplication(), 
									  factoryGUI.GetViewStart(), factoryGUI.GetViewMain(),
									  factoryGUI.GetViewPage1(), factoryGUI.GetViewPage2(), factoryGUI.GetViewPage3()).Run();
		}
	}
}
