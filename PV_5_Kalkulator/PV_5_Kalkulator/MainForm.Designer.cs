/*
 * Created by SharpDevelop.
 * User: HP
 * Date: Sab, 19 Mar 2022
 * Time: 11.26.14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV_5_Kalkulator
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
			this.labelAngka1 = new System.Windows.Forms.Label();
			this.labelAngka2 = new System.Windows.Forms.Label();
			this.textBoxAngka1 = new System.Windows.Forms.TextBox();
			this.labelHasil = new System.Windows.Forms.Label();
			this.textBoxAngka2 = new System.Windows.Forms.TextBox();
			this.labelViewHasil = new System.Windows.Forms.Label();
			this.buttonPlus = new System.Windows.Forms.Button();
			this.buttonMin = new System.Windows.Forms.Button();
			this.buttonMulti = new System.Windows.Forms.Button();
			this.buttonDiv = new System.Windows.Forms.Button();
			this.buttonC = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelAngka1
			// 
			this.labelAngka1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAngka1.Location = new System.Drawing.Point(30, 30);
			this.labelAngka1.Name = "labelAngka1";
			this.labelAngka1.Size = new System.Drawing.Size(70, 23);
			this.labelAngka1.TabIndex = 0;
			this.labelAngka1.Text = "Angka 1";
			this.labelAngka1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelAngka2
			// 
			this.labelAngka2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAngka2.Location = new System.Drawing.Point(30, 70);
			this.labelAngka2.Name = "labelAngka2";
			this.labelAngka2.Size = new System.Drawing.Size(70, 23);
			this.labelAngka2.TabIndex = 1;
			this.labelAngka2.Text = "Angka 2";
			this.labelAngka2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxAngka1
			// 
			this.textBoxAngka1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAngka1.Location = new System.Drawing.Point(106, 30);
			this.textBoxAngka1.Name = "textBoxAngka1";
			this.textBoxAngka1.Size = new System.Drawing.Size(140, 23);
			this.textBoxAngka1.TabIndex = 2;
			// 
			// labelHasil
			// 
			this.labelHasil.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHasil.Location = new System.Drawing.Point(30, 110);
			this.labelHasil.Name = "labelHasil";
			this.labelHasil.Size = new System.Drawing.Size(70, 23);
			this.labelHasil.TabIndex = 3;
			this.labelHasil.Text = "Hasil";
			this.labelHasil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxAngka2
			// 
			this.textBoxAngka2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAngka2.Location = new System.Drawing.Point(106, 70);
			this.textBoxAngka2.Name = "textBoxAngka2";
			this.textBoxAngka2.Size = new System.Drawing.Size(140, 23);
			this.textBoxAngka2.TabIndex = 4;
			// 
			// labelViewHasil
			// 
			this.labelViewHasil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelViewHasil.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelViewHasil.Location = new System.Drawing.Point(106, 110);
			this.labelViewHasil.Name = "labelViewHasil";
			this.labelViewHasil.Size = new System.Drawing.Size(140, 23);
			this.labelViewHasil.TabIndex = 5;
			this.labelViewHasil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonPlus
			// 
			this.buttonPlus.BackColor = System.Drawing.Color.Silver;
			this.buttonPlus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonPlus.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPlus.Location = new System.Drawing.Point(30, 160);
			this.buttonPlus.Name = "buttonPlus";
			this.buttonPlus.Size = new System.Drawing.Size(60, 30);
			this.buttonPlus.TabIndex = 6;
			this.buttonPlus.Text = "+";
			this.buttonPlus.UseVisualStyleBackColor = false;
			this.buttonPlus.Click += new System.EventHandler(this.ButtonPlusClick);
			// 
			// buttonMin
			// 
			this.buttonMin.BackColor = System.Drawing.Color.Silver;
			this.buttonMin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonMin.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMin.Location = new System.Drawing.Point(106, 160);
			this.buttonMin.Name = "buttonMin";
			this.buttonMin.Size = new System.Drawing.Size(60, 30);
			this.buttonMin.TabIndex = 7;
			this.buttonMin.Text = "–";
			this.buttonMin.UseVisualStyleBackColor = false;
			this.buttonMin.Click += new System.EventHandler(this.ButtonMinClick);
			// 
			// buttonMulti
			// 
			this.buttonMulti.BackColor = System.Drawing.Color.Silver;
			this.buttonMulti.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonMulti.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMulti.Location = new System.Drawing.Point(30, 200);
			this.buttonMulti.Name = "buttonMulti";
			this.buttonMulti.Size = new System.Drawing.Size(60, 30);
			this.buttonMulti.TabIndex = 8;
			this.buttonMulti.Text = "*";
			this.buttonMulti.UseVisualStyleBackColor = false;
			this.buttonMulti.Click += new System.EventHandler(this.ButtonMultiClick);
			// 
			// buttonDiv
			// 
			this.buttonDiv.BackColor = System.Drawing.Color.Silver;
			this.buttonDiv.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonDiv.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDiv.Location = new System.Drawing.Point(106, 200);
			this.buttonDiv.Name = "buttonDiv";
			this.buttonDiv.Size = new System.Drawing.Size(60, 30);
			this.buttonDiv.TabIndex = 9;
			this.buttonDiv.Text = "/";
			this.buttonDiv.UseVisualStyleBackColor = false;
			this.buttonDiv.Click += new System.EventHandler(this.ButtonDivClick);
			// 
			// buttonC
			// 
			this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonC.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonC.Location = new System.Drawing.Point(186, 160);
			this.buttonC.Name = "buttonC";
			this.buttonC.Size = new System.Drawing.Size(60, 70);
			this.buttonC.TabIndex = 10;
			this.buttonC.Text = "C";
			this.buttonC.UseVisualStyleBackColor = false;
			this.buttonC.Click += new System.EventHandler(this.ButtonCClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.buttonC);
			this.Controls.Add(this.buttonDiv);
			this.Controls.Add(this.buttonMulti);
			this.Controls.Add(this.buttonMin);
			this.Controls.Add(this.buttonPlus);
			this.Controls.Add(this.labelViewHasil);
			this.Controls.Add(this.textBoxAngka2);
			this.Controls.Add(this.labelHasil);
			this.Controls.Add(this.textBoxAngka1);
			this.Controls.Add(this.labelAngka2);
			this.Controls.Add(this.labelAngka1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kalkulator";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonC;
		private System.Windows.Forms.Button buttonDiv;
		private System.Windows.Forms.Button buttonMulti;
		private System.Windows.Forms.Button buttonMin;
		private System.Windows.Forms.Button buttonPlus;
		private System.Windows.Forms.Label labelViewHasil;
		private System.Windows.Forms.TextBox textBoxAngka2;
		private System.Windows.Forms.Label labelHasil;
		private System.Windows.Forms.TextBox textBoxAngka1;
		private System.Windows.Forms.Label labelAngka2;
		private System.Windows.Forms.Label labelAngka1;
	}
}
