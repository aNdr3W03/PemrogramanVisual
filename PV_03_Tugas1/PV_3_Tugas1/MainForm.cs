/*
 * Created by SharpDevelop.
 * User: AndrewBenedictus
 * Date: Rab, 23 Feb 2022
 * Time: 16.12.01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PV_3_Tugas1
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
		
		void BtnAddClick(object sender, EventArgs e)
		{
			listName.Items.Add(textBoxName.Text);
			textBoxName.Clear();
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			listName.Items.RemoveAt(listName.SelectedIndex);
		}
	}
}
