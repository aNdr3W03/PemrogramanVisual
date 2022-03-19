/*
 * Created by SharpDevelop.
 * User: HP
 * Date: Rab, 02 Mar 2022
 * Time: 14.56.59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PV_4_ButtonNama
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
		
		void ButtonKlikClick(object sender, EventArgs e)
		{
			MessageBox.Show("Hello World " + this.textBoxNama.Text);
		}
	}
}
