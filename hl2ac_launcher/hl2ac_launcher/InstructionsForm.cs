/*
 * Created by SharpDevelop.
 * User: Michael
 * Date: 11/10/2013
 * Time: 7:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace hl2ac_launcher
{
	/// <summary>
	/// Description of InstructionsForm.
	/// </summary>
	public partial class InstructionsForm : Form
	{
		public InstructionsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
