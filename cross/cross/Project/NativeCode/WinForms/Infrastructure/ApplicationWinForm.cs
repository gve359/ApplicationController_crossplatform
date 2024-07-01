using System;
using System.Windows.Forms;

namespace Project.Infrastructure
{
	public class ApplicationWinForm : IGLApplication
	{		
		public ApplicationWinForm()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
		}
		
		public void StartProgram()
		{
			Application.Run();
		}
		public void FinishProgram()
		{
			Application.Exit();
		}
	}
}
