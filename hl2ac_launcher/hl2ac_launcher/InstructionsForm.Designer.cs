/*
 * Created by SharpDevelop.
 * User: Michael
 * Date: 11/10/2013
 * Time: 7:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace hl2ac_launcher
{
	partial class InstructionsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionsForm));
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 499);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(446, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(446, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Launcher Instructions:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(446, 33);
			this.label2.TabIndex = 2;
			this.label2.Text = "Using this launcher is as quick and easy as just pressing the launch button, howe" +
			"ver there is a lot more things you can do with this than just play the game!";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(446, 33);
			this.label3.TabIndex = 3;
			this.label3.Text = "First of all, make sure you have this launcher where your Half-Life 2 Survivor Ve" +
			"r2.0 directory is. This allows you to launch Half-Life 2 Survivor Ver2.0.";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(446, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "Let\'s go over every feature of the launcher.";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(446, 75);
			this.label5.TabIndex = 5;
			this.label5.Text = resources.GetString("label5.Text");
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 245);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(446, 47);
			this.label6.TabIndex = 6;
			this.label6.Text = resources.GetString("label6.Text");
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 304);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(446, 60);
			this.label7.TabIndex = 7;
			this.label7.Text = resources.GetString("label7.Text");
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 429);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(446, 57);
			this.label8.TabIndex = 8;
			this.label8.Text = resources.GetString("label8.Text");
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 379);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(446, 33);
			this.label9.TabIndex = 9;
			this.label9.Text = "You can allow the launcher to close by itself when the game launches by checking " +
			"the \"Close the launcher when the game loads\" checkbox.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// InstructionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 534);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "InstructionsForm";
			this.Text = "Half-Life 2 Survivor Ver2.0 Launcher - Launcher Instructions";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}