/*
 * Created by SharpDevelop.
 * User: HP
 * Date: Rab, 02 Mar 2022
 * Time: 14.37.24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PV_4_ButtonMessageBox
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
		
		void ButtonKirimClick(object sender, EventArgs e)
		{
			MessageBox.Show("Nama Anda " + this.textBoxNama.Text +
			                ", dengan NIM " + this.textBoxNIM.Text +
			                "\nAnda berada di kelas " + this.textBoxKelas.Text +
			                " dan mengambil mata kuliah " + this.textBoxMatkul.Text);
		}
	}
}
