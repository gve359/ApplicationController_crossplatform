
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;



namespace Project.Framework.ViewPage1
{
	public partial class Control1 : UserControl, INavigationNode_Page1
	{
		public event Action PressedForward = delegate{};
		
		public Control1()
		{
			InitializeComponent();			
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.PressedForward();
		}
	}
}
