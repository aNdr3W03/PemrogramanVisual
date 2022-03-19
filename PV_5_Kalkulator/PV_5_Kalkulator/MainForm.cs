/*
 * Created by SharpDevelop.
 * User: HP
 * Date: Sab, 19 Mar 2022
 * Time: 11.26.14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PV_5_Kalkulator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ButtonPlusClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxAngka1.Text) || string.IsNullOrEmpty(textBoxAngka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 Tidak Boleh Kosong");
			}
			else
			{
				int a,b,c;
				a = int.Parse(this.textBoxAngka1.Text);
				b = int.Parse(this.textBoxAngka2.Text);
				c = a + b;
				this.labelViewHasil.Text = c.ToString();
			}
		}
		
		void ButtonMinClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxAngka1.Text) || string.IsNullOrEmpty(textBoxAngka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 Tidak Boleh Kosong");
			}
			else
			{
				int a,b,c;
				a = int.Parse(this.textBoxAngka1.Text);
				b = int.Parse(this.textBoxAngka2.Text);
				c = a - b;
				this.labelViewHasil.Text = c.ToString();
			}
		}
		
		void ButtonMultiClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxAngka1.Text) || string.IsNullOrEmpty(textBoxAngka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 Tidak Boleh Kosong");
			}
			else
			{
				int a,b,c;
				a = int.Parse(this.textBoxAngka1.Text);
				b = int.Parse(this.textBoxAngka2.Text);
				c = a * b;
				this.labelViewHasil.Text = c.ToString();
			}
		}
		
		void ButtonDivClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxAngka1.Text) || string.IsNullOrEmpty(textBoxAngka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 Tidak Boleh Kosong");
			}
			else
			{
				int a,b,c;
				a = int.Parse(this.textBoxAngka1.Text);
				b = int.Parse(this.textBoxAngka2.Text);
				c = a / b;
				this.labelViewHasil.Text = c.ToString();
			}
		}
		
		void ButtonCClick(object sender, EventArgs e)
		{
			textBoxAngka1.Clear();
			textBoxAngka2.Clear();
			labelViewHasil.Text = "";
		}
	}
}
