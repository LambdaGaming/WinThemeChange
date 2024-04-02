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
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.ExperimentalButton = new System.Windows.Forms.Button();
			this.TaskbarButton = new System.Windows.Forms.Button();
			this.StartButton = new System.Windows.Forms.Button();
			this.FontsButton = new System.Windows.Forms.Button();
			this.ThemesButton = new System.Windows.Forms.Button();
			this.LockScreenButton = new System.Windows.Forms.Button();
			this.ColorsButton = new System.Windows.Forms.Button();
			this.BackgroundButton = new System.Windows.Forms.Button();
			this.ExperimentalPanel = new System.Windows.Forms.Panel();
			this.DisableWatermarkButton = new System.Windows.Forms.Button();
			this.TaskbarPanel = new System.Windows.Forms.Panel();
			this.StartPanel = new System.Windows.Forms.Panel();
			this.FontsPanel = new System.Windows.Forms.Panel();
			this.ThemesPanel = new System.Windows.Forms.Panel();
			this.LockScreenPanel = new System.Windows.Forms.Panel();
			this.ColorsPanel = new System.Windows.Forms.Panel();
			this.BackgroundPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.ExperimentalPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// colorDialog
			// 
			this.colorDialog.AnyColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.ExperimentalButton);
			this.splitContainer1.Panel1.Controls.Add(this.TaskbarButton);
			this.splitContainer1.Panel1.Controls.Add(this.StartButton);
			this.splitContainer1.Panel1.Controls.Add(this.FontsButton);
			this.splitContainer1.Panel1.Controls.Add(this.ThemesButton);
			this.splitContainer1.Panel1.Controls.Add(this.LockScreenButton);
			this.splitContainer1.Panel1.Controls.Add(this.ColorsButton);
			this.splitContainer1.Panel1.Controls.Add(this.BackgroundButton);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.ExperimentalPanel);
			this.splitContainer1.Panel2.Controls.Add(this.FontsPanel);
			this.splitContainer1.Panel2.Controls.Add(this.TaskbarPanel);
			this.splitContainer1.Panel2.Controls.Add(this.StartPanel);
			this.splitContainer1.Panel2.Controls.Add(this.ThemesPanel);
			this.splitContainer1.Panel2.Controls.Add(this.LockScreenPanel);
			this.splitContainer1.Panel2.Controls.Add(this.ColorsPanel);
			this.splitContainer1.Panel2.Controls.Add(this.BackgroundPanel);
			this.splitContainer1.Size = new System.Drawing.Size(750, 559);
			this.splitContainer1.SplitterDistance = 303;
			this.splitContainer1.TabIndex = 13;
			// 
			// ExperimentalButton
			// 
			this.ExperimentalButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.ExperimentalButton.Location = new System.Drawing.Point(0, 161);
			this.ExperimentalButton.Name = "ExperimentalButton";
			this.ExperimentalButton.Size = new System.Drawing.Size(303, 23);
			this.ExperimentalButton.TabIndex = 7;
			this.ExperimentalButton.Text = "Experimental";
			this.ExperimentalButton.UseVisualStyleBackColor = true;
			this.ExperimentalButton.Click += new System.EventHandler(this.ExperimentalButton_Click);
			// 
			// TaskbarButton
			// 
			this.TaskbarButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.TaskbarButton.Location = new System.Drawing.Point(0, 138);
			this.TaskbarButton.Name = "TaskbarButton";
			this.TaskbarButton.Size = new System.Drawing.Size(303, 23);
			this.TaskbarButton.TabIndex = 6;
			this.TaskbarButton.Text = "Taskbar";
			this.TaskbarButton.UseVisualStyleBackColor = true;
			this.TaskbarButton.Click += new System.EventHandler(this.TaskbarButton_Click);
			// 
			// StartButton
			// 
			this.StartButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.StartButton.Location = new System.Drawing.Point(0, 115);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(303, 23);
			this.StartButton.TabIndex = 5;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// FontsButton
			// 
			this.FontsButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.FontsButton.Location = new System.Drawing.Point(0, 92);
			this.FontsButton.Name = "FontsButton";
			this.FontsButton.Size = new System.Drawing.Size(303, 23);
			this.FontsButton.TabIndex = 4;
			this.FontsButton.Text = "Fonts";
			this.FontsButton.UseVisualStyleBackColor = true;
			this.FontsButton.Click += new System.EventHandler(this.FontsButton_Click);
			// 
			// ThemesButton
			// 
			this.ThemesButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.ThemesButton.Location = new System.Drawing.Point(0, 69);
			this.ThemesButton.Name = "ThemesButton";
			this.ThemesButton.Size = new System.Drawing.Size(303, 23);
			this.ThemesButton.TabIndex = 3;
			this.ThemesButton.Text = "Themes";
			this.ThemesButton.UseVisualStyleBackColor = true;
			this.ThemesButton.Click += new System.EventHandler(this.ThemesButton_Click);
			// 
			// LockScreenButton
			// 
			this.LockScreenButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.LockScreenButton.Location = new System.Drawing.Point(0, 46);
			this.LockScreenButton.Name = "LockScreenButton";
			this.LockScreenButton.Size = new System.Drawing.Size(303, 23);
			this.LockScreenButton.TabIndex = 2;
			this.LockScreenButton.Text = "Lock Screen";
			this.LockScreenButton.UseVisualStyleBackColor = true;
			this.LockScreenButton.Click += new System.EventHandler(this.LockScreenButton_Click);
			// 
			// ColorsButton
			// 
			this.ColorsButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.ColorsButton.Location = new System.Drawing.Point(0, 23);
			this.ColorsButton.Name = "ColorsButton";
			this.ColorsButton.Size = new System.Drawing.Size(303, 23);
			this.ColorsButton.TabIndex = 1;
			this.ColorsButton.Text = "Colors";
			this.ColorsButton.UseVisualStyleBackColor = true;
			this.ColorsButton.Click += new System.EventHandler(this.ColorsButton_Click);
			// 
			// BackgroundButton
			// 
			this.BackgroundButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.BackgroundButton.Location = new System.Drawing.Point(0, 0);
			this.BackgroundButton.Name = "BackgroundButton";
			this.BackgroundButton.Size = new System.Drawing.Size(303, 23);
			this.BackgroundButton.TabIndex = 0;
			this.BackgroundButton.Text = "Background";
			this.BackgroundButton.UseVisualStyleBackColor = true;
			this.BackgroundButton.Click += new System.EventHandler(this.BackgroundButton_Click);
			// 
			// ExperimentalPanel
			// 
			this.ExperimentalPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ExperimentalPanel.Controls.Add(this.label2);
			this.ExperimentalPanel.Controls.Add(this.label1);
			this.ExperimentalPanel.Controls.Add(this.DisableWatermarkButton);
			this.ExperimentalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ExperimentalPanel.Location = new System.Drawing.Point(0, 0);
			this.ExperimentalPanel.Name = "ExperimentalPanel";
			this.ExperimentalPanel.Size = new System.Drawing.Size(443, 559);
			this.ExperimentalPanel.TabIndex = 1;
			// 
			// DisableWatermarkButton
			// 
			this.DisableWatermarkButton.Location = new System.Drawing.Point(3, 102);
			this.DisableWatermarkButton.Name = "DisableWatermarkButton";
			this.DisableWatermarkButton.Size = new System.Drawing.Size(125, 34);
			this.DisableWatermarkButton.TabIndex = 0;
			this.DisableWatermarkButton.Text = "Disable Watermark";
			this.DisableWatermarkButton.UseVisualStyleBackColor = true;
			this.DisableWatermarkButton.Click += new System.EventHandler(this.DisableWatermarkButton_Click);
			// 
			// TaskbarPanel
			// 
			this.TaskbarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.TaskbarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TaskbarPanel.Location = new System.Drawing.Point(0, 0);
			this.TaskbarPanel.Name = "TaskbarPanel";
			this.TaskbarPanel.Size = new System.Drawing.Size(443, 559);
			this.TaskbarPanel.TabIndex = 1;
			// 
			// StartPanel
			// 
			this.StartPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.StartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StartPanel.Location = new System.Drawing.Point(0, 0);
			this.StartPanel.Name = "StartPanel";
			this.StartPanel.Size = new System.Drawing.Size(443, 559);
			this.StartPanel.TabIndex = 1;
			// 
			// FontsPanel
			// 
			this.FontsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FontsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FontsPanel.Location = new System.Drawing.Point(0, 0);
			this.FontsPanel.Name = "FontsPanel";
			this.FontsPanel.Size = new System.Drawing.Size(443, 559);
			this.FontsPanel.TabIndex = 1;
			// 
			// ThemesPanel
			// 
			this.ThemesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ThemesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ThemesPanel.Location = new System.Drawing.Point(0, 0);
			this.ThemesPanel.Name = "ThemesPanel";
			this.ThemesPanel.Size = new System.Drawing.Size(443, 559);
			this.ThemesPanel.TabIndex = 1;
			// 
			// LockScreenPanel
			// 
			this.LockScreenPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LockScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LockScreenPanel.Location = new System.Drawing.Point(0, 0);
			this.LockScreenPanel.Name = "LockScreenPanel";
			this.LockScreenPanel.Size = new System.Drawing.Size(443, 559);
			this.LockScreenPanel.TabIndex = 1;
			// 
			// ColorsPanel
			// 
			this.ColorsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ColorsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ColorsPanel.Location = new System.Drawing.Point(0, 0);
			this.ColorsPanel.Name = "ColorsPanel";
			this.ColorsPanel.Size = new System.Drawing.Size(443, 559);
			this.ColorsPanel.TabIndex = 1;
			// 
			// BackgroundPanel
			// 
			this.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
			this.BackgroundPanel.Name = "BackgroundPanel";
			this.BackgroundPanel.Size = new System.Drawing.Size(443, 559);
			this.BackgroundPanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(35, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(367, 39);
			this.label1.TabIndex = 1;
			this.label1.Text = "Experimental Features";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(21, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(381, 40);
			this.label2.TabIndex = 2;
			this.label2.Text = "These features may not work as intended or at all. Use at your own risk.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(750, 559);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WinThemeChange v3.0";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ExperimentalPanel.ResumeLayout(false);
			this.ExperimentalPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		internal System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button ColorsButton;
		private System.Windows.Forms.Button BackgroundButton;
		private System.Windows.Forms.Button LockScreenButton;
		private System.Windows.Forms.Button ThemesButton;
		private System.Windows.Forms.Button FontsButton;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Button TaskbarButton;
		private System.Windows.Forms.Button ExperimentalButton;
		private System.Windows.Forms.Panel ExperimentalPanel;
		private System.Windows.Forms.Button DisableWatermarkButton;
		private System.Windows.Forms.Panel TaskbarPanel;
		private System.Windows.Forms.Panel StartPanel;
		private System.Windows.Forms.Panel FontsPanel;
		private System.Windows.Forms.Panel ThemesPanel;
		private System.Windows.Forms.Panel LockScreenPanel;
		private System.Windows.Forms.Panel ColorsPanel;
		private System.Windows.Forms.Panel BackgroundPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

