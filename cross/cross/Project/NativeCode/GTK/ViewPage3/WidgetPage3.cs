using System;

namespace Project.Framework.ViewPage3
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class WidgetPage3 : Gtk.Bin, INavigationNode_Page3
	{
		public event Action PressedBack = delegate{};

		public WidgetPage3 ()
		{
			this.Build ();
		}

		protected void OnButton1Clicked (object sender, EventArgs e)
		{
			this.PressedBack ();
		}
	}
}

