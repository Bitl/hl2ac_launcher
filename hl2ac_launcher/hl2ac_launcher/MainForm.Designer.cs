/*
 * Created by SharpDevelop.
 * User: Michael
 * Date: 10/31/2013
 * Time: 4:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
namespace hl2ac_launcher
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(20, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(425, 167);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 298);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 27);
			this.label2.TabIndex = 9;
			this.label2.Text = "Heapsize";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(310, 185);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(135, 34);
			this.button5.TabIndex = 10;
			this.button5.Text = "Launch";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(118, 328);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(89, 20);
			this.textBox2.TabIndex = 13;
			this.textBox2.Text = "1360";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(213, 328);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(89, 20);
			this.textBox3.TabIndex = 14;
			this.textBox3.Text = "768";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(118, 298);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 27);
			this.label4.TabIndex = 15;
			this.label4.Text = "Width";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(213, 298);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 27);
			this.label5.TabIndex = 16;
			this.label5.Text = "Height";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(13, 185);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(289, 26);
			this.button6.TabIndex = 17;
			this.button6.Text = "NESYS Host Redirection";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 215);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(289, 26);
			this.label6.TabIndex = 18;
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 328);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(89, 20);
			this.textBox1.TabIndex = 19;
			this.textBox1.Text = "512000";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(314, 227);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(123, 16);
			this.checkBox1.TabIndex = 20;
			this.checkBox1.Text = "Enable Heapsize";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(314, 249);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(131, 17);
			this.checkBox2.TabIndex = 21;
			this.checkBox2.Text = "Enable Arcade Menu";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			this.textBox4.Enabled = false;
			this.textBox4.Location = new System.Drawing.Point(12, 383);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(289, 20);
			this.textBox4.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 357);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(288, 23);
			this.label1.TabIndex = 23;
			this.label1.Text = "Custom Launch Options";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(314, 272);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(139, 21);
			this.checkBox3.TabIndex = 24;
			this.checkBox3.Text = "Enable Launch Options";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(312, 366);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 21);
			this.button1.TabIndex = 26;
			this.button1.Text = "Load Configuration";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(312, 393);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(139, 21);
			this.button2.TabIndex = 27;
			this.button2.Text = "Save Configuration";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(90, 250);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 15);
			this.label3.TabIndex = 28;
			this.label3.Text = "Custom NESYS Host IP";
			// 
			// textBox5
			// 
			this.textBox5.Enabled = false;
			this.textBox5.Location = new System.Drawing.Point(12, 273);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(289, 20);
			this.textBox5.TabIndex = 29;
			// 
			// checkBox4
			// 
			this.checkBox4.Location = new System.Drawing.Point(314, 291);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(137, 34);
			this.checkBox4.TabIndex = 30;
			this.checkBox4.Text = "Enable Custom NESYS Host IP";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4CheckedChanged);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(312, 417);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(141, 22);
			this.label7.TabIndex = 31;
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 418);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(139, 42);
			this.button3.TabIndex = 32;
			this.button3.Text = "Launcher Instructions";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(157, 418);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(139, 42);
			this.button4.TabIndex = 33;
			this.button4.Text = "Game Instructions";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// checkBox5
			// 
			this.checkBox5.Location = new System.Drawing.Point(314, 328);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(131, 30);
			this.checkBox5.TabIndex = 34;
			this.checkBox5.Text = "Close the launcher when the game loads";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(310, 439);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(141, 22);
			this.label8.TabIndex = 35;
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 472);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
