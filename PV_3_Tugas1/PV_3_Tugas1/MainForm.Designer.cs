/*
 * Created by SharpDevelop.
 * User: AndrewBenedictus
 * Date: Rab, 23 Feb 2022
 * Time: 16.12.01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV_3_Tugas1
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
			this.listName = new System.Windows.Forms.ListBox();
			this.title = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listName
			// 
			this.listName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listName.FormattingEnabled = true;
			this.listName.ItemHeight = 18;
			this.listName.Location = new System.Drawing.Point(12, 86);
			this.listName.Name = "listName";
			this.listName.Size = new System.Drawing.Size(180, 184);
			this.listName.TabIndex = 1;
			this.listName.UseWaitCursor = true;
			// 
			// title
			// 
			this.title.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.Location = new System.Drawing.Point(12, 9);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(310, 24);
			this.title.TabIndex = 2;
			this.title.Text = "Daftar Nama Mahasiswa";
			this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.title.UseWaitCursor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnDelete.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(212, 146);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 38);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Hapus";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.UseWaitCursor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxName.Location = new System.Drawing.Point(72, 51);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(250, 23);
			this.textBoxName.TabIndex = 5;
			this.textBoxName.UseWaitCursor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnAdd.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(212, 100);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 38);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Tambah";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.UseWaitCursor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(12, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Nama:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.UseWaitCursor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 281);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.title);
			this.Controls.Add(this.listName);
			this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Daftar Nama Mahasiswa";
			this.UseWaitCursor = true;
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.ListBox listName;
	}
}
