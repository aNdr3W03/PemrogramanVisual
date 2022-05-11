/*
 * Created by SharpDevelop.
 * User: HP
 * Date: Rab, 02 Mar 2022
 * Time: 14.37.24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV_4_ButtonMessageBox
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelNIM = new System.Windows.Forms.Label();
			this.labelKelas = new System.Windows.Forms.Label();
			this.labelMatkul = new System.Windows.Forms.Label();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.textBoxNIM = new System.Windows.Forms.TextBox();
			this.textBoxKelas = new System.Windows.Forms.TextBox();
			this.textBoxMatkul = new System.Windows.Forms.TextBox();
			this.buttonKirim = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(12, 12);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(260, 24);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Input Data Mahasiswa";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelName
			// 
			this.labelName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(12, 50);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 22);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Nama";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelNIM
			// 
			this.labelNIM.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNIM.Location = new System.Drawing.Point(12, 80);
			this.labelNIM.Name = "labelNIM";
			this.labelNIM.Size = new System.Drawing.Size(100, 22);
			this.labelNIM.TabIndex = 2;
			this.labelNIM.Text = "NIM";
			this.labelNIM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelKelas
			// 
			this.labelKelas.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelKelas.Location = new System.Drawing.Point(12, 110);
			this.labelKelas.Name = "labelKelas";
			this.labelKelas.Size = new System.Drawing.Size(100, 22);
			this.labelKelas.TabIndex = 3;
			this.labelKelas.Text = "Kelas";
			this.labelKelas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelMatkul
			// 
			this.labelMatkul.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMatkul.Location = new System.Drawing.Point(12, 140);
			this.labelMatkul.Name = "labelMatkul";
			this.labelMatkul.Size = new System.Drawing.Size(100, 22);
			this.labelMatkul.TabIndex = 4;
			this.labelMatkul.Text = "Mata Kuliah";
			this.labelMatkul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxNama
			// 
			this.textBoxNama.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNama.Location = new System.Drawing.Point(118, 50);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(154, 22);
			this.textBoxNama.TabIndex = 5;
			// 
			// textBoxNIM
			// 
			this.textBoxNIM.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNIM.Location = new System.Drawing.Point(118, 80);
			this.textBoxNIM.Name = "textBoxNIM";
			this.textBoxNIM.Size = new System.Drawing.Size(154, 22);
			this.textBoxNIM.TabIndex = 6;
			// 
			// textBoxKelas
			// 
			this.textBoxKelas.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxKelas.Location = new System.Drawing.Point(118, 110);
			this.textBoxKelas.Name = "textBoxKelas";
			this.textBoxKelas.Size = new System.Drawing.Size(154, 22);
			this.textBoxKelas.TabIndex = 7;
			// 
			// textBoxMatkul
			// 
			this.textBoxMatkul.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMatkul.Location = new System.Drawing.Point(118, 140);
			this.textBoxMatkul.Name = "textBoxMatkul";
			this.textBoxMatkul.Size = new System.Drawing.Size(154, 22);
			this.textBoxMatkul.TabIndex = 8;
			// 
			// buttonKirim
			// 
			this.buttonKirim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.buttonKirim.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKirim.Location = new System.Drawing.Point(92, 198);
			this.buttonKirim.Name = "buttonKirim";
			this.buttonKirim.Size = new System.Drawing.Size(100, 30);
			this.buttonKirim.TabIndex = 9;
			this.buttonKirim.Text = "Kirim";
			this.buttonKirim.UseVisualStyleBackColor = false;
			this.buttonKirim.Click += new System.EventHandler(this.ButtonKirimClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.buttonKirim);
			this.Controls.Add(this.textBoxMatkul);
			this.Controls.Add(this.textBoxKelas);
			this.Controls.Add(this.textBoxNIM);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.labelMatkul);
			this.Controls.Add(this.labelKelas);
			this.Controls.Add(this.labelNIM);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelTitle);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Data Mahasiswa";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonKirim;
		private System.Windows.Forms.TextBox textBoxMatkul;
		private System.Windows.Forms.TextBox textBoxKelas;
		private System.Windows.Forms.TextBox textBoxNIM;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.Label labelMatkul;
		private System.Windows.Forms.Label labelKelas;
		private System.Windows.Forms.Label labelNIM;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelTitle;
	}
}
