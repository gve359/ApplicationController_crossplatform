
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Project.Framework.ViewPage2
{
	public partial class Control2 : UserControl, INavigationNode_Page2
	{
		public event Action PressedForward = delegate{};
		public event Action PressedBack = delegate{};
		
		public Control2()
		{
			InitializeComponent();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.PressedBack();
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.PressedForward();
		}
	}
}
