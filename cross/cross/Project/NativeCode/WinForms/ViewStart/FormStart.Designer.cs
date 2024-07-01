
namespace Project.Framework.ViewStart
{
	partial class FormStart
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(33, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 84);
			this.label1.TabIndex = 0;
			this.label1.Text = "В первом окне может находится например отображение хода загрузки или проверка на " +
	"лицензионность.";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(79, 134);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 35);
			this.button1.TabIndex = 1;
			this.button1.Text = "Перейти на главное окно";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// FormStart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(305, 227);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "FormStart";
			this.Text = "FormStart";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStartFormClosed);
			this.ResumeLayout(false);

		}
	}
}
