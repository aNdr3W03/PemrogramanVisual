/*
 * Created by SharpDevelop.
 * User: HP
 * Date: Rab, 02 Mar 2022
 * Time: 14.56.59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV_4_ButtonNama
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.labelNama = new System.Windows.Forms.Label();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.buttonKlik = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelNama
			// 
			this.labelNama.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelNama.Location = new System.Drawing.Point(12, 40);
			this.labelNama.Name = "labelNama";
			this.labelNama.Size = new System.Drawing.Size(90, 22);
			this.labelNama.TabIndex = 0;
			this.labelNama.Text = "Nama Anda";
			this.labelNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxNama
			// 
			this.textBoxNama.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNama.Location = new System.Drawing.Point(108, 40);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(164, 22);
			this.textBoxNama.TabIndex = 1;
			// 
			// buttonKlik
			// 
			this.buttonKlik.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKlik.Location = new System.Drawing.Point(90, 140);
			this.buttonKlik.Name = "buttonKlik";
			this.buttonKlik.Size = new System.Drawing.Size(100, 26);
			this.buttonKlik.TabIndex = 2;
			this.buttonKlik.Text = "Klik Saya";
			this.buttonKlik.UseVisualStyleBackColor = true;
			this.buttonKlik.Click += new System.EventHandler(this.ButtonKlikClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.buttonKlik);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.labelNama);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Input Nama";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonKlik;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.Label labelNama;
	}
}
