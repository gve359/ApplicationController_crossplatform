using System;

namespace Project.Framework.ViewPage1 
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class WidgetPage1 : Gtk.Bin, INavigationNode_Page1
	{
		public event Action PressedForward = delegate {};

		public WidgetPage1 ()
		{
			this.Build ();
		}

		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			this.PressedForward ();
		}

	}
}

