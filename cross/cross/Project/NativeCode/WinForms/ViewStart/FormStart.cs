
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project.Framework.ViewStart
{
	public partial class FormStart : Form, IViewStart
	{
		public event Action PressedContinue = delegate{};
		public event Action IWindowShowed = delegate{};
		public event Action IWindowClosed = delegate{};
				
		public FormStart()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{	
			this.PressedContinue();
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
		void FormStartFormClosed(object sender, FormClosedEventArgs e)
		{
			this.IWindowClosed();
		}		
	}
}
