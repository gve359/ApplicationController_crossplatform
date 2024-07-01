using System;

using Project.Infrastructure;

namespace Project.Framework.ViewMain
{
	public partial class WindowMain : Gtk.Window, IViewMain
	{		
		public event Action IWindowShowed = delegate {};
		public event Action IWindowClosed = delegate {};

		public WindowMain () : base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		public void SetContent(Object content)
		{
			Gtk.Widget _content = content as Gtk.Widget;

			foreach(Gtk.Widget widget in this.AllChildren)
			{
				this.Remove (widget);
			}

			this.Add (_content);
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


	}
}

