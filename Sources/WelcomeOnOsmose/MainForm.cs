/*
 * Created by SharpDevelop.
 * User: Etienne.MARTIN
 * Date: 29/09/2016
 * Time: 10:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WelcomeOnOsmose
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private TextBox tbxTest = new System.Windows.Forms.TextBox();
		private ListBox lbxTest = new ListBox();

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			// Set name to main window
			this.Text = "Osmose";

			// create textbox
			//TextBox tbxTest = new System.Windows.Forms.TextBox();
			// Specify default text to be displayed inside TextBox
			tbxTest.Text="Welcome on Osmose";
			// specify its location
			tbxTest.Location = new System.Drawing.Point(25, 25);
			//Attach TextBox to the Form
			this.Controls.Add(tbxTest);
			
			//create an instance of the button with call
			Button btnTest = new Button();
			// specify the button size with
			btnTest.Size = new System.Drawing.Size(100,25);
			// Give the button a name
			btnTest.Text = "Action";
			// specify its location
			btnTest.Location = new System.Drawing.Point(25, 75);
			// Set action on click
			btnTest.Click += btnTest_Click;
			this.Controls.Add(btnTest);
			
			// create ListBox
			//ListBox lbxTest = new ListBox();
			// Specify its size
			lbxTest.Size = new Size(100, 50);
			// specify its location
			lbxTest.Location = new System.Drawing.Point(25, 125);
			//Attach TextBox to the Form
			this.Controls.Add(lbxTest);
		}

		void btnTest_Click(object sender, EventArgs e)
		{
			// 2016-09-28 : EAZOU - hotfix - Show textbox text
			MessageBox.Show(tbxTest.Text);
			lbxTest.Items.Add(tbxTest.Text);
		}
	}
}
