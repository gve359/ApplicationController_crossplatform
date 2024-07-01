using System;

namespace Project.Framework.ViewPage2
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class WidgetPage2 : Gtk.Bin, INavigationNode_Page2
	{
		public event Action PressedForward = delegate{};
		public event Action PressedBack = delegate{};

		public WidgetPage2 ()
		{
			this.Build ();
		}

		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			this.PressedBack ();
		}

		protected void OnButton1Clicked (object sender, EventArgs e)
		{
			this.PressedForward ();
		}
	}
}

