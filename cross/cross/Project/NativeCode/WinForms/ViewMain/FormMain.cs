
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Project.Framework.ViewPage1;

namespace Project.Framework.ViewMain
{
	public partial class FormMain : Form, IViewMain
	{
		public event Action IWindowShowed = delegate{};
		public event Action IWindowClosed = delegate{};		
		
		public FormMain()
		{
			InitializeComponent();
		}				
		
		public void SetContent(Object content)
		{
			UserControl _content = content as UserControl;
			this.Controls.Clear();						
			this.Controls.Add(_content);
		}
		
		
		public void IWindowShow()
		{
			this.Show();
		}
		public void IWindowClose()
		{
			this.Close();
		}
		public void IWindowHide()
		{
			this.Hide();
		}
		void FormMainFormClosed(object sender, FormClosedEventArgs e)
		{
			this.IWindowClosed();
		}
	}
}
