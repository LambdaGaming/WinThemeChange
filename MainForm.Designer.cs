namespace WinThemeChange
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Button1
			// 
			this.Button1.Location = new System.Drawing.Point(12, 12);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(128, 34);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Hide Watermark";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Button2
			// 
			this.Button2.Location = new System.Drawing.Point(147, 12);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(128, 34);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Enable System Dark Mode";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// colorDialog
			// 
			this.colorDialog.AnyColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(281, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 34);
			this.button3.TabIndex = 2;
			this.button3.Text = "Enable System Light Mode";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 52);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(128, 33);
			this.button4.TabIndex = 3;
			this.button4.Text = "Enable App Dark Mode";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(147, 52);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(128, 33);
			this.button5.TabIndex = 4;
			this.button5.Text = "Enable App Light Mode";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(281, 52);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(128, 34);
			this.button6.TabIndex = 5;
			this.button6.Text = "Auto Pick Theme Colors From Wallpaper";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(12, 91);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(128, 34);
			this.button8.TabIndex = 7;
			this.button8.Text = "Set Custom Theme Color";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(12, 131);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(128, 34);
			this.button9.TabIndex = 8;
			this.button9.Text = "Enable Transparency Effects";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(146, 131);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(128, 34);
			this.button10.TabIndex = 9;
			this.button10.Text = "Disable Transparency Effects";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(281, 92);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(128, 34);
			this.button11.TabIndex = 10;
			this.button11.Text = "Disable Custom Theme Colors";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(281, 132);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(128, 34);
			this.button12.TabIndex = 11;
			this.button12.Text = "Force Restart Explorer";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(146, 91);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(128, 34);
			this.button7.TabIndex = 12;
			this.button7.Text = "Set Custom Theme Color (Taskbar Only)";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(421, 178);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WinThemeChange v2.0.0";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button7;
		internal System.Windows.Forms.ColorDialog colorDialog;
	}
}

