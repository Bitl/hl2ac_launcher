/*
 * Created by SharpDevelop.
 * User: Michael
 * Date: 10/31/2013
 * Time: 4:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace hl2ac_launcher
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
			string hl2ac_version = "1.2.1";
			label7.Text = hl2ac_version;
		}
		
		void Button6Click(object sender, System.EventArgs e)
		{
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");
            string hostsText = File.ReadAllText(path);
            if (hostsText.Contains("bg3test.cg.taito.co.jp"))
            {
            	label6.Text = "You already did the host redirection!";
            	label6.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
            	StreamWriter writer = new StreamWriter(path, true);
            	writer.Write(Environment.NewLine);
            	writer.Write("##Survivor host redirection");
            	writer.Write(Environment.NewLine);
            	if (checkBox4.Checked == false)
				{
            		writer.Write("127.0.0.1    bg3test.cg.taito.co.jp");
            	}
            	else
            	{
            		writer.Write(textBox5.Text + "    bg3test.cg.taito.co.jp");
            	}
            	writer.Dispose();
            	label6.Text = "Host redirection completed!";
            	label6.ForeColor = System.Drawing.Color.Lime;
            }
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if (checkBox1.Checked == false)
			{
				System.Diagnostics.Process.Start("hl2.exe", "-sw -game hl2mp -width " + textBox2.Text + " -height " + textBox3.Text + " -ac -english");
			}
			else if (checkBox2.Checked == false)
			{
				System.Diagnostics.Process.Start("hl2.exe", "-sw -game hl2mp -heapsize " + textBox1.Text + " -width " + textBox2.Text + " -height " + textBox3.Text + " -english");
			}
			else if (checkBox3.Checked == false)
			{
				System.Diagnostics.Process.Start("hl2.exe", "-sw -game hl2mp -heapsize " + textBox1.Text + " -width " + textBox2.Text + " -height " + textBox3.Text + " -ac -english");
			}
			else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked == false)
			{
				System.Diagnostics.Process.Start("hl2.exe", "-sw -game hl2mp -width " + textBox2.Text + " -height " + textBox3.Text + " -english");
			}
			else
			{
				System.Diagnostics.Process.Start("hl2.exe", "-sw -game hl2mp -heapsize " + textBox1.Text + " -width " + textBox2.Text + " -height " + textBox3.Text + " -ac -english " + textBox4.Text);
			}
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == false)
			{
				textBox1.Enabled = false;
			}
			else
			{
				textBox1.Enabled = true;
			}
		}
		
		void CheckBox3CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3.Checked == false)
			{
				textBox4.Enabled = false;
			}
			else
			{
				textBox4.Enabled = true;
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string line1, line2, line3, line4, line5;

			using(StreamReader reader = new StreamReader("hl2ac_config.txt")) 
			{
    			line1 = reader.ReadLine();
    			line2 = reader.ReadLine();
    			line3 = reader.ReadLine();
    			line4 = reader.ReadLine();
    			line5 = reader.ReadLine();
			}
			
			textBox1.Text = line1;
			textBox2.Text = line2;
			textBox3.Text = line3;
			textBox4.Text = line4;
			textBox5.Text = line5;
			
			MessageBox.Show("Configuration Loaded.");
		}
		
		void Button2Click(object sender, EventArgs e)
		{ 
        	string[] lines = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text };
        	System.IO.File.WriteAllLines("hl2ac_config.txt", lines);
			MessageBox.Show("Configuration Saved.");
		}
		
		void CheckBox4CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox4.Checked == false)
			{
				textBox5.Enabled = false;
			}
			else
			{
				textBox5.Enabled = true;
			}
		}
	}
}
