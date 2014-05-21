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
			string hl2ac_version = "missingno";
			
			if (System.Diagnostics.Debugger.IsAttached)
			{
				hl2ac_version = "Test Version";
			}
			else
			{
				hl2ac_version = "1.4";
			}
			
			string hl2ac_buildnumber = Application.ProductVersion;
			
			if (System.Diagnostics.Debugger.IsAttached)
			{
				if (File.Exists("hl2ac_version_debug.txt"))
				{
        			string line1;
					using(StreamReader reader = new StreamReader("hl2ac_version_debug.txt")) 
					{
    					line1 = reader.ReadLine();
					}
					hl2ac_version = line1;
				}
				else
				{
					string[] lines = { hl2ac_version };
        			File.WriteAllLines("hl2ac_version_debug.txt", lines);
        			string line1;
					using(StreamReader reader = new StreamReader("hl2ac_version_debug.txt")) 
					{
    					line1 = reader.ReadLine();
					}
					hl2ac_version = line1;
				}
			}
			else
			{
				if (File.Exists("hl2ac_version.txt"))
				{
					string line1;
					using(StreamReader reader = new StreamReader("hl2ac_version.txt")) 
					{
    					line1 = reader.ReadLine();
					}
					hl2ac_version = line1;
				}
				else
				{
					string[] lines = { hl2ac_version };
        			File.WriteAllLines("hl2ac_version.txt", lines);
        			string line1;
					using(StreamReader reader = new StreamReader("hl2ac_version.txt")) 
					{
    					line1 = reader.ReadLine();
					}
					hl2ac_version = line1;
				}
			}
			
			label7.Text = "Launcher Version: " + hl2ac_version;
			label8.Text = "Build Number: " + hl2ac_buildnumber;
			this.Text = "Half-Life 2 Survivor Ver2.0 Launcher - Version: " + hl2ac_version;
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
			
			if (checkBox5.Checked == true)
			{
				this.Close();
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
			using (var ofd = new OpenFileDialog())
        	{
				ofd.Filter = "Text files (*.txt)|*.txt";
            	ofd.FilterIndex = 2;
            	ofd.FileName = "hl2ac_config.txt";
            	ofd.Title = "Load Configuration";
            	
            	if (ofd.ShowDialog() == DialogResult.OK)
            	{
					string line1, line2, line3, line4, line5, line6, line7, line8, line9, line10;

					using(StreamReader reader = new StreamReader(ofd.FileName)) 
					{
    					line1 = reader.ReadLine();
    					line2 = reader.ReadLine();
    					line3 = reader.ReadLine();
    					line4 = reader.ReadLine();
    					line5 = reader.ReadLine();
    					line6 = reader.ReadLine();
    					line7 = reader.ReadLine();
    					line8 = reader.ReadLine();
    					line9 = reader.ReadLine();
    					line10 = reader.ReadLine();
					}
					
					Boolean bline6 = bool.Parse(line6);
					Boolean bline7 = bool.Parse(line7);
					Boolean bline8 = bool.Parse(line8);
					Boolean bline9 = bool.Parse(line9);
					Boolean bline10 = bool.Parse(line10);
			
					textBox1.Text = line1;
					textBox2.Text = line2;
					textBox3.Text = line3;
					textBox4.Text = line4;
					textBox5.Text = line5;
					checkBox1.Checked = bline6;
					checkBox2.Checked = bline7;
					checkBox3.Checked = bline8;
					checkBox4.Checked = bline9;
					checkBox5.Checked = bline10;
			
					MessageBox.Show("Configuration Loaded.");
            	}
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{ 
			using (var sfd = new SaveFileDialog())
        	{
            	sfd.Filter = "Text files (*.txt)|*.txt";
            	sfd.FilterIndex = 2;
            	sfd.FileName = "hl2ac_config.txt";
            	sfd.Title = "Save Configuration";

            	if (sfd.ShowDialog() == DialogResult.OK)
            	{
                	string[] lines = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, checkBox1.Checked.ToString(), checkBox2.Checked.ToString(), checkBox3.Checked.ToString(), checkBox4.Checked.ToString(), checkBox5.Checked.ToString() };
        			File.WriteAllLines(sfd.FileName, lines);
					MessageBox.Show("Configuration Saved.");
            	}     
        	}
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
		
		void Button3Click(object sender, EventArgs e)
		{
        	InstructionsForm btnFm1 = new InstructionsForm();
			btnFm1.Show();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			InstructionsGameForm btnFm2 = new InstructionsGameForm();
			btnFm2.Show();
		}
	}
}
