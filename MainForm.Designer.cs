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
			this.LockScreenPanel = new System.Windows.Forms.Panel();
			this.LockScreenFacts = new System.Windows.Forms.CheckBox();
			this.LockImageButton = new System.Windows.Forms.Button();
			this.LockImage = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.ColorsPanel = new System.Windows.Forms.Panel();
			this.ColorButton = new System.Windows.Forms.Button();
			this.AccentBackground = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TransparencyEffects = new System.Windows.Forms.CheckBox();
			this.AppDarkMode = new System.Windows.Forms.CheckBox();
			this.SystemDarkMode = new System.Windows.Forms.CheckBox();
			this.ColorImage = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ExperimentalPanel = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.DisableWatermarkButton = new System.Windows.Forms.Button();
			this.BackgroundPanel = new System.Windows.Forms.Panel();
			this.BackgroundColorButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.WallpaperFit = new System.Windows.Forms.ComboBox();
			this.WallpaperButton = new System.Windows.Forms.Button();
			this.WallpaperImage = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.FontsPanel = new System.Windows.Forms.Panel();
			this.TaskbarPanel = new System.Windows.Forms.Panel();
			this.StartPanel = new System.Windows.Forms.Panel();
			this.ThemesPanel = new System.Windows.Forms.Panel();
			this.SignInImage = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.LockScreenPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LockImage)).BeginInit();
			this.ColorsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ColorImage)).BeginInit();
			this.ExperimentalPanel.SuspendLayout();
			this.BackgroundPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WallpaperImage)).BeginInit();
			this.SuspendLayout();
			// 
			// colorDialog
			// 
			this.colorDialog.AnyColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
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
			this.splitContainer1.Panel2.Controls.Add(this.LockScreenPanel);
			this.splitContainer1.Panel2.Controls.Add(this.ColorsPanel);
			this.splitContainer1.Panel2.Controls.Add(this.ExperimentalPanel);
			this.splitContainer1.Panel2.Controls.Add(this.BackgroundPanel);
			this.splitContainer1.Panel2.Controls.Add(this.FontsPanel);
			this.splitContainer1.Panel2.Controls.Add(this.TaskbarPanel);
			this.splitContainer1.Panel2.Controls.Add(this.StartPanel);
			this.splitContainer1.Panel2.Controls.Add(this.ThemesPanel);
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
			// LockScreenPanel
			// 
			this.LockScreenPanel.BackColor = System.Drawing.Color.Black;
			this.LockScreenPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LockScreenPanel.Controls.Add(this.SignInImage);
			this.LockScreenPanel.Controls.Add(this.LockScreenFacts);
			this.LockScreenPanel.Controls.Add(this.LockImageButton);
			this.LockScreenPanel.Controls.Add(this.LockImage);
			this.LockScreenPanel.Controls.Add(this.label7);
			this.LockScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LockScreenPanel.Location = new System.Drawing.Point(0, 0);
			this.LockScreenPanel.Name = "LockScreenPanel";
			this.LockScreenPanel.Size = new System.Drawing.Size(443, 559);
			this.LockScreenPanel.TabIndex = 1;
			// 
			// LockScreenFacts
			// 
			this.LockScreenFacts.AutoSize = true;
			this.LockScreenFacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LockScreenFacts.ForeColor = System.Drawing.Color.White;
			this.LockScreenFacts.Location = new System.Drawing.Point(57, 308);
			this.LockScreenFacts.Name = "LockScreenFacts";
			this.LockScreenFacts.Size = new System.Drawing.Size(375, 21);
			this.LockScreenFacts.TabIndex = 8;
			this.LockScreenFacts.Text = "Get fun facts, tips, tricks, and more on your lock screen";
			this.LockScreenFacts.UseVisualStyleBackColor = true;
			this.LockScreenFacts.CheckedChanged += new System.EventHandler(this.LockScreenFacts_CheckedChanged);
			// 
			// LockImageButton
			// 
			this.LockImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LockImageButton.Location = new System.Drawing.Point(57, 268);
			this.LockImageButton.Name = "LockImageButton";
			this.LockImageButton.Size = new System.Drawing.Size(114, 29);
			this.LockImageButton.TabIndex = 7;
			this.LockImageButton.Text = "Select Image";
			this.LockImageButton.UseVisualStyleBackColor = true;
			this.LockImageButton.Click += new System.EventHandler(this.LockImageButton_Click);
			// 
			// LockImage
			// 
			this.LockImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.LockImage.InitialImage = null;
			this.LockImage.Location = new System.Drawing.Point(57, 62);
			this.LockImage.Name = "LockImage";
			this.LockImage.Size = new System.Drawing.Size(320, 180);
			this.LockImage.TabIndex = 6;
			this.LockImage.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(115, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(210, 39);
			this.label7.TabIndex = 3;
			this.label7.Text = "Lock Screen";
			// 
			// ColorsPanel
			// 
			this.ColorsPanel.AutoScroll = true;
			this.ColorsPanel.BackColor = System.Drawing.Color.Black;
			this.ColorsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ColorsPanel.Controls.Add(this.ColorButton);
			this.ColorsPanel.Controls.Add(this.AccentBackground);
			this.ColorsPanel.Controls.Add(this.label6);
			this.ColorsPanel.Controls.Add(this.TransparencyEffects);
			this.ColorsPanel.Controls.Add(this.AppDarkMode);
			this.ColorsPanel.Controls.Add(this.SystemDarkMode);
			this.ColorsPanel.Controls.Add(this.ColorImage);
			this.ColorsPanel.Controls.Add(this.label5);
			this.ColorsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ColorsPanel.Location = new System.Drawing.Point(0, 0);
			this.ColorsPanel.Name = "ColorsPanel";
			this.ColorsPanel.Size = new System.Drawing.Size(443, 559);
			this.ColorsPanel.TabIndex = 1;
			// 
			// ColorButton
			// 
			this.ColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ColorButton.Location = new System.Drawing.Point(57, 437);
			this.ColorButton.Name = "ColorButton";
			this.ColorButton.Size = new System.Drawing.Size(103, 27);
			this.ColorButton.TabIndex = 11;
			this.ColorButton.Text = "Select Color";
			this.ColorButton.UseVisualStyleBackColor = true;
			this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
			// 
			// AccentBackground
			// 
			this.AccentBackground.AutoSize = true;
			this.AccentBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AccentBackground.ForeColor = System.Drawing.Color.White;
			this.AccentBackground.Location = new System.Drawing.Point(57, 410);
			this.AccentBackground.Name = "AccentBackground";
			this.AccentBackground.Size = new System.Drawing.Size(331, 21);
			this.AccentBackground.TabIndex = 10;
			this.AccentBackground.Text = "Automatically pick accent color from background";
			this.AccentBackground.UseVisualStyleBackColor = true;
			this.AccentBackground.CheckedChanged += new System.EventHandler(this.AccentBackground_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(53, 375);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(212, 20);
			this.label6.TabIndex = 9;
			this.label6.Text = "Choose your accent color";
			// 
			// TransparencyEffects
			// 
			this.TransparencyEffects.AutoSize = true;
			this.TransparencyEffects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TransparencyEffects.ForeColor = System.Drawing.Color.White;
			this.TransparencyEffects.Location = new System.Drawing.Point(57, 327);
			this.TransparencyEffects.Name = "TransparencyEffects";
			this.TransparencyEffects.Size = new System.Drawing.Size(204, 21);
			this.TransparencyEffects.TabIndex = 8;
			this.TransparencyEffects.Text = "Enable transparency effects";
			this.TransparencyEffects.UseVisualStyleBackColor = true;
			this.TransparencyEffects.CheckedChanged += new System.EventHandler(this.TransparencyEffects_CheckedChanged);
			// 
			// AppDarkMode
			// 
			this.AppDarkMode.AutoSize = true;
			this.AppDarkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AppDarkMode.ForeColor = System.Drawing.Color.White;
			this.AppDarkMode.Location = new System.Drawing.Point(57, 300);
			this.AppDarkMode.Name = "AppDarkMode";
			this.AppDarkMode.Size = new System.Drawing.Size(170, 21);
			this.AppDarkMode.TabIndex = 7;
			this.AppDarkMode.Text = "Enable app dark mode";
			this.AppDarkMode.UseVisualStyleBackColor = true;
			this.AppDarkMode.CheckedChanged += new System.EventHandler(this.AppDarkMode_CheckedChanged);
			// 
			// SystemDarkMode
			// 
			this.SystemDarkMode.AutoSize = true;
			this.SystemDarkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SystemDarkMode.ForeColor = System.Drawing.Color.White;
			this.SystemDarkMode.Location = new System.Drawing.Point(57, 273);
			this.SystemDarkMode.Name = "SystemDarkMode";
			this.SystemDarkMode.Size = new System.Drawing.Size(190, 21);
			this.SystemDarkMode.TabIndex = 6;
			this.SystemDarkMode.Text = "Enable system dark mode";
			this.SystemDarkMode.UseVisualStyleBackColor = true;
			this.SystemDarkMode.CheckedChanged += new System.EventHandler(this.SystemDarkMode_CheckedChanged);
			// 
			// ColorImage
			// 
			this.ColorImage.Image = global::WinThemeChange.Properties.Resources.wallpaper_foreground;
			this.ColorImage.InitialImage = null;
			this.ColorImage.Location = new System.Drawing.Point(57, 62);
			this.ColorImage.Name = "ColorImage";
			this.ColorImage.Size = new System.Drawing.Size(320, 180);
			this.ColorImage.TabIndex = 5;
			this.ColorImage.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(154, 5);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 39);
			this.label5.TabIndex = 2;
			this.label5.Text = "Colors";
			// 
			// ExperimentalPanel
			// 
			this.ExperimentalPanel.BackColor = System.Drawing.Color.Black;
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
			// BackgroundPanel
			// 
			this.BackgroundPanel.AutoScroll = true;
			this.BackgroundPanel.BackColor = System.Drawing.Color.Black;
			this.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.BackgroundPanel.Controls.Add(this.BackgroundColorButton);
			this.BackgroundPanel.Controls.Add(this.label4);
			this.BackgroundPanel.Controls.Add(this.WallpaperFit);
			this.BackgroundPanel.Controls.Add(this.WallpaperButton);
			this.BackgroundPanel.Controls.Add(this.WallpaperImage);
			this.BackgroundPanel.Controls.Add(this.label3);
			this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
			this.BackgroundPanel.Name = "BackgroundPanel";
			this.BackgroundPanel.Size = new System.Drawing.Size(443, 559);
			this.BackgroundPanel.TabIndex = 0;
			// 
			// BackgroundColorButton
			// 
			this.BackgroundColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BackgroundColorButton.Location = new System.Drawing.Point(57, 308);
			this.BackgroundColorButton.Name = "BackgroundColorButton";
			this.BackgroundColorButton.Size = new System.Drawing.Size(114, 29);
			this.BackgroundColorButton.TabIndex = 8;
			this.BackgroundColorButton.Text = "Select Color";
			this.BackgroundColorButton.UseVisualStyleBackColor = true;
			this.BackgroundColorButton.Click += new System.EventHandler(this.BackgroundColorButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(229, 258);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Choose a fit";
			// 
			// WallpaperFit
			// 
			this.WallpaperFit.FormattingEnabled = true;
			this.WallpaperFit.Items.AddRange(new object[] {
            "Center",
            "Tile",
            "Stretch",
            "Fit",
            "Fill",
            "Span"});
			this.WallpaperFit.Location = new System.Drawing.Point(232, 278);
			this.WallpaperFit.Name = "WallpaperFit";
			this.WallpaperFit.Size = new System.Drawing.Size(145, 21);
			this.WallpaperFit.TabIndex = 6;
			this.WallpaperFit.SelectedIndexChanged += new System.EventHandler(this.WallpaperFit_SelectedIndexChanged);
			// 
			// WallpaperButton
			// 
			this.WallpaperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WallpaperButton.Location = new System.Drawing.Point(57, 273);
			this.WallpaperButton.Name = "WallpaperButton";
			this.WallpaperButton.Size = new System.Drawing.Size(114, 29);
			this.WallpaperButton.TabIndex = 5;
			this.WallpaperButton.Text = "Select Image";
			this.WallpaperButton.UseVisualStyleBackColor = true;
			this.WallpaperButton.Click += new System.EventHandler(this.WallpaperButton_Click);
			// 
			// WallpaperImage
			// 
			this.WallpaperImage.Image = global::WinThemeChange.Properties.Resources.wallpaper_foreground;
			this.WallpaperImage.InitialImage = null;
			this.WallpaperImage.Location = new System.Drawing.Point(57, 62);
			this.WallpaperImage.Name = "WallpaperImage";
			this.WallpaperImage.Size = new System.Drawing.Size(320, 180);
			this.WallpaperImage.TabIndex = 4;
			this.WallpaperImage.TabStop = false;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(123, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(202, 39);
			this.label3.TabIndex = 2;
			this.label3.Text = "Background";
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
			// ThemesPanel
			// 
			this.ThemesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ThemesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ThemesPanel.Location = new System.Drawing.Point(0, 0);
			this.ThemesPanel.Name = "ThemesPanel";
			this.ThemesPanel.Size = new System.Drawing.Size(443, 559);
			this.ThemesPanel.TabIndex = 1;
			// 
			// SignInImage
			// 
			this.SignInImage.AutoSize = true;
			this.SignInImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SignInImage.ForeColor = System.Drawing.Color.White;
			this.SignInImage.Location = new System.Drawing.Point(57, 335);
			this.SignInImage.Name = "SignInImage";
			this.SignInImage.Size = new System.Drawing.Size(376, 21);
			this.SignInImage.TabIndex = 9;
			this.SignInImage.Text = "Show lock screen background picture on sign-in screen";
			this.SignInImage.UseVisualStyleBackColor = true;
			this.SignInImage.CheckedChanged += new System.EventHandler(this.SignInImage_CheckedChanged);
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
			this.LockScreenPanel.ResumeLayout(false);
			this.LockScreenPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LockImage)).EndInit();
			this.ColorsPanel.ResumeLayout(false);
			this.ColorsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ColorImage)).EndInit();
			this.ExperimentalPanel.ResumeLayout(false);
			this.ExperimentalPanel.PerformLayout();
			this.BackgroundPanel.ResumeLayout(false);
			this.BackgroundPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.WallpaperImage)).EndInit();
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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox WallpaperImage;
		private System.Windows.Forms.Button WallpaperButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox WallpaperFit;
		private System.Windows.Forms.Button BackgroundColorButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox ColorImage;
		private System.Windows.Forms.CheckBox SystemDarkMode;
		private System.Windows.Forms.CheckBox AppDarkMode;
		private System.Windows.Forms.CheckBox TransparencyEffects;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox AccentBackground;
		private System.Windows.Forms.Button ColorButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox LockImage;
		private System.Windows.Forms.Button LockImageButton;
		private System.Windows.Forms.CheckBox LockScreenFacts;
		private System.Windows.Forms.CheckBox SignInImage;
	}
}

