
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Project.Framework.ViewPage3
{
	public partial class Control3 : UserControl, INavigationNode_Page3
	{
		public event Action PressedBack = delegate{};
		
		public Control3()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.PressedBack();
		}
	}
}
