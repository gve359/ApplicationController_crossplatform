using System;

namespace Project.Framework.ViewStart
{
	public partial class WindowStart : Gtk.Window, IViewStart
	{
		public event Action PressedContinue = delegate {};
		public event Action IWindowShowed = delegate {};
		public event Action IWindowClosed = delegate {};

		public WindowStart () : base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
			
		public void IWindowShow()
		{
			this.Show();
		}
		public void IWindowClose()
		{
			this.Destroy();
		}
		public void IWindowHide()
		{
			this.Hide();
		}

		public void OnDeleteEvent(object o, Gtk.DeleteEventArgs args)
		{
			this.IWindowClosed();		
		}			

		protected void OnButton1Clicked (object sender, EventArgs e)
		{
			this.PressedContinue ();
		}
	}
}

