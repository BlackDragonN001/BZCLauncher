namespace BZCLauncher.Forms {
	partial class PageConfig {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
				foreach (var disposable in Disposables) {
					if (disposable != null) {
						disposable.Dispose();
					}
				}
				this.Disposables.Clear();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.ConfigParameter = new System.Windows.Forms.TextBox();
            this.CheckWindow = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckNoIntro = new System.Windows.Forms.CheckBox();
            this.CheckPowerUser = new System.Windows.Forms.CheckBox();
            this.CheckEdit = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckNobodyHome = new System.Windows.Forms.CheckBox();
            this.CheckNoScript = new System.Windows.Forms.CheckBox();
            this.CheckShellMap = new System.Windows.Forms.CheckBox();
            this.CheckResolution = new System.Windows.Forms.CheckBox();
            this.ResolutionX = new System.Windows.Forms.TextBox();
            this.ResolutionY = new System.Windows.Forms.TextBox();
            this.CheckIvar = new System.Windows.Forms.CheckBox();
            this.IvarNum = new System.Windows.Forms.TextBox();
            this.IvarVal = new System.Windows.Forms.TextBox();
            this.CheckSnapScrap = new System.Windows.Forms.CheckBox();
            this.CheckAdjustHeightOnLoad = new System.Windows.Forms.CheckBox();
            this.AdjustHeightOnLoadVal = new System.Windows.Forms.TextBox();
            this.CommandPreview = new System.Windows.Forms.TextBox();
            this.LaunchButton = new BZCLauncher.Controls.PictureButton();
            this.BackButton = new BZCLauncher.Controls.PictureButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfigParameter
            // 
            this.ConfigParameter.Location = new System.Drawing.Point(170, 100);
            this.ConfigParameter.Name = "ConfigParameter";
            this.ConfigParameter.Size = new System.Drawing.Size(300, 20);
            this.ConfigParameter.TabIndex = 1;
            this.ConfigParameter.TextChanged += new System.EventHandler(this.ConfigParameter_Changed);
            // 
            // CheckWindow
            // 
            this.CheckWindow.AutoSize = true;
            this.CheckWindow.BackColor = System.Drawing.Color.Transparent;
            this.CheckWindow.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckWindow.ForeColor = System.Drawing.Color.Lime;
            this.CheckWindow.Location = new System.Drawing.Point(170, 141);
            this.CheckWindow.Name = "CheckWindow";
            this.CheckWindow.Size = new System.Drawing.Size(106, 20);
            this.CheckWindow.TabIndex = 2;
            this.CheckWindow.Text = "Windowed Mode";
            this.CheckWindow.UseVisualStyleBackColor = false;
            this.CheckWindow.CheckedChanged += new System.EventHandler(this.CheckWindow_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BZCLauncher.Properties.Resources.bigwindow1;
            this.pictureBox1.Location = new System.Drawing.Point(146, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(151, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Additional Config. Use this to add command line arguments to the game.";
            // 
            // CheckNoIntro
            // 
            this.CheckNoIntro.AutoSize = true;
            this.CheckNoIntro.BackColor = System.Drawing.Color.Transparent;
            this.CheckNoIntro.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNoIntro.ForeColor = System.Drawing.Color.Lime;
            this.CheckNoIntro.Location = new System.Drawing.Point(170, 167);
            this.CheckNoIntro.Name = "CheckNoIntro";
            this.CheckNoIntro.Size = new System.Drawing.Size(103, 20);
            this.CheckNoIntro.TabIndex = 7;
            this.CheckNoIntro.Text = "Skip Intro Movie";
            this.CheckNoIntro.UseVisualStyleBackColor = false;
            // 
            // CheckPowerUser
            // 
            this.CheckPowerUser.AutoSize = true;
            this.CheckPowerUser.BackColor = System.Drawing.Color.Transparent;
            this.CheckPowerUser.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPowerUser.ForeColor = System.Drawing.Color.Lime;
            this.CheckPowerUser.Location = new System.Drawing.Point(170, 193);
            this.CheckPowerUser.Name = "CheckPowerUser";
            this.CheckPowerUser.Size = new System.Drawing.Size(84, 20);
            this.CheckPowerUser.TabIndex = 8;
            this.CheckPowerUser.Text = "Power User";
            this.CheckPowerUser.UseVisualStyleBackColor = false;
            // 
            // CheckEdit
            // 
            this.CheckEdit.AutoSize = true;
            this.CheckEdit.BackColor = System.Drawing.Color.Transparent;
            this.CheckEdit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckEdit.ForeColor = System.Drawing.Color.Lime;
            this.CheckEdit.Location = new System.Drawing.Point(359, 193);
            this.CheckEdit.Name = "CheckEdit";
            this.CheckEdit.Size = new System.Drawing.Size(54, 20);
            this.CheckEdit.TabIndex = 9;
            this.CheckEdit.Text = "Editor";
            this.CheckEdit.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(306, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 48);
            this.label2.TabIndex = 10;
            this.label2.Text = "Check this to launch Battlezone II \r\ninto Editor mode. Multiplayer is \r\ndisabled " +
    "during this mode.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CheckNobodyHome
            // 
            this.CheckNobodyHome.AutoSize = true;
            this.CheckNobodyHome.BackColor = System.Drawing.Color.Transparent;
            this.CheckNobodyHome.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNobodyHome.ForeColor = System.Drawing.Color.Lime;
            this.CheckNobodyHome.Location = new System.Drawing.Point(309, 219);
            this.CheckNobodyHome.Name = "CheckNobodyHome";
            this.CheckNobodyHome.Size = new System.Drawing.Size(93, 20);
            this.CheckNobodyHome.TabIndex = 11;
            this.CheckNobodyHome.Text = "NobodyHome";
            this.CheckNobodyHome.UseVisualStyleBackColor = false;
            // 
            // CheckNoScript
            // 
            this.CheckNoScript.AutoSize = true;
            this.CheckNoScript.BackColor = System.Drawing.Color.Transparent;
            this.CheckNoScript.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNoScript.ForeColor = System.Drawing.Color.Lime;
            this.CheckNoScript.Location = new System.Drawing.Point(309, 245);
            this.CheckNoScript.Name = "CheckNoScript";
            this.CheckNoScript.Size = new System.Drawing.Size(67, 20);
            this.CheckNoScript.TabIndex = 12;
            this.CheckNoScript.Text = "NoScript";
            this.CheckNoScript.UseVisualStyleBackColor = false;
            // 
            // CheckShellMap
            // 
            this.CheckShellMap.AutoSize = true;
            this.CheckShellMap.BackColor = System.Drawing.Color.Transparent;
            this.CheckShellMap.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckShellMap.ForeColor = System.Drawing.Color.Lime;
            this.CheckShellMap.Location = new System.Drawing.Point(309, 271);
            this.CheckShellMap.Name = "CheckShellMap";
            this.CheckShellMap.Size = new System.Drawing.Size(71, 20);
            this.CheckShellMap.TabIndex = 13;
            this.CheckShellMap.Text = "ShellMap";
            this.CheckShellMap.UseVisualStyleBackColor = false;
            // 
            // CheckResolution
            // 
            this.CheckResolution.AutoSize = true;
            this.CheckResolution.BackColor = System.Drawing.Color.Transparent;
            this.CheckResolution.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckResolution.ForeColor = System.Drawing.Color.Lime;
            this.CheckResolution.Location = new System.Drawing.Point(170, 380);
            this.CheckResolution.Name = "CheckResolution";
            this.CheckResolution.Size = new System.Drawing.Size(76, 20);
            this.CheckResolution.TabIndex = 14;
            this.CheckResolution.Text = "Resolution";
            this.CheckResolution.UseVisualStyleBackColor = false;
            // 
            // ResolutionX
            // 
            this.ResolutionX.Location = new System.Drawing.Point(246, 380);
            this.ResolutionX.Name = "ResolutionX";
            this.ResolutionX.Size = new System.Drawing.Size(30, 20);
            this.ResolutionX.TabIndex = 15;
            // 
            // ResolutionY
            // 
            this.ResolutionY.Location = new System.Drawing.Point(282, 380);
            this.ResolutionY.Name = "ResolutionY";
            this.ResolutionY.Size = new System.Drawing.Size(30, 20);
            this.ResolutionY.TabIndex = 16;
            // 
            // CheckIvar
            // 
            this.CheckIvar.AutoSize = true;
            this.CheckIvar.BackColor = System.Drawing.Color.Transparent;
            this.CheckIvar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckIvar.ForeColor = System.Drawing.Color.Lime;
            this.CheckIvar.Location = new System.Drawing.Point(309, 349);
            this.CheckIvar.Name = "CheckIvar";
            this.CheckIvar.Size = new System.Drawing.Size(46, 20);
            this.CheckIvar.TabIndex = 17;
            this.CheckIvar.Text = "Ivar";
            this.CheckIvar.UseVisualStyleBackColor = false;
            // 
            // IvarNum
            // 
            this.IvarNum.Location = new System.Drawing.Point(350, 349);
            this.IvarNum.Name = "IvarNum";
            this.IvarNum.Size = new System.Drawing.Size(30, 20);
            this.IvarNum.TabIndex = 18;
            // 
            // IvarVal
            // 
            this.IvarVal.Location = new System.Drawing.Point(386, 349);
            this.IvarVal.Name = "IvarVal";
            this.IvarVal.Size = new System.Drawing.Size(30, 20);
            this.IvarVal.TabIndex = 19;
            // 
            // CheckSnapScrap
            // 
            this.CheckSnapScrap.AutoSize = true;
            this.CheckSnapScrap.BackColor = System.Drawing.Color.Transparent;
            this.CheckSnapScrap.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckSnapScrap.ForeColor = System.Drawing.Color.Lime;
            this.CheckSnapScrap.Location = new System.Drawing.Point(309, 297);
            this.CheckSnapScrap.Name = "CheckSnapScrap";
            this.CheckSnapScrap.Size = new System.Drawing.Size(80, 20);
            this.CheckSnapScrap.TabIndex = 20;
            this.CheckSnapScrap.Text = "SnapScrap";
            this.CheckSnapScrap.UseVisualStyleBackColor = false;
            // 
            // CheckAdjustHeightOnLoad
            // 
            this.CheckAdjustHeightOnLoad.AutoSize = true;
            this.CheckAdjustHeightOnLoad.BackColor = System.Drawing.Color.Transparent;
            this.CheckAdjustHeightOnLoad.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAdjustHeightOnLoad.ForeColor = System.Drawing.Color.Lime;
            this.CheckAdjustHeightOnLoad.Location = new System.Drawing.Point(309, 323);
            this.CheckAdjustHeightOnLoad.Name = "CheckAdjustHeightOnLoad";
            this.CheckAdjustHeightOnLoad.Size = new System.Drawing.Size(123, 20);
            this.CheckAdjustHeightOnLoad.TabIndex = 21;
            this.CheckAdjustHeightOnLoad.Text = "AdjustHeightOnLoad";
            this.CheckAdjustHeightOnLoad.UseVisualStyleBackColor = false;
            // 
            // AdjustHeightOnLoadVal
            // 
            this.AdjustHeightOnLoadVal.Location = new System.Drawing.Point(429, 323);
            this.AdjustHeightOnLoadVal.Name = "AdjustHeightOnLoadVal";
            this.AdjustHeightOnLoadVal.Size = new System.Drawing.Size(30, 20);
            this.AdjustHeightOnLoadVal.TabIndex = 22;
            // 
            // CommandPreview
            // 
            this.CommandPreview.Enabled = false;
            this.CommandPreview.Location = new System.Drawing.Point(170, 402);
            this.CommandPreview.Name = "CommandPreview";
            this.CommandPreview.ReadOnly = true;
            this.CommandPreview.Size = new System.Drawing.Size(300, 20);
            this.CommandPreview.TabIndex = 23;
            // 
            // LaunchButton
            // 
            this.LaunchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchButton.BackColor = System.Drawing.Color.Transparent;
            this.LaunchButton.DownImage = global::BZCLauncher.Properties.Resources.TRbtnclk;
            this.LaunchButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchButton.ForeColor = System.Drawing.Color.Lime;
            this.LaunchButton.IdleImage = global::BZCLauncher.Properties.Resources.TRbtnoff;
            this.LaunchButton.Location = new System.Drawing.Point(486, 0);
            this.LaunchButton.MousedOverImage = global::BZCLauncher.Properties.Resources.TRbtnon;
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(152, 34);
            this.LaunchButton.TabIndex = 4;
            this.LaunchButton.Text = "LAUNCH";
            this.LaunchButton.TextOffset = new System.Drawing.Point(-12, -3);
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.DownImage = global::BZCLauncher.Properties.Resources.TLbtnclk;
            this.BackButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Lime;
            this.BackButton.IdleImage = global::BZCLauncher.Properties.Resources.TLbtnoff;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.MousedOverImage = global::BZCLauncher.Properties.Resources.TLbtnon;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(152, 34);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "BACK";
            this.BackButton.TextOffset = new System.Drawing.Point(16, -3);
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BZCLauncher.Properties.Resources.bzctag;
            this.pictureBox2.Location = new System.Drawing.Point(256, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // PageConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BZCLauncher.Properties.Resources.bzclbackground;
            this.ClientSize = new System.Drawing.Size(638, 479);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CommandPreview);
            this.Controls.Add(this.AdjustHeightOnLoadVal);
            this.Controls.Add(this.CheckAdjustHeightOnLoad);
            this.Controls.Add(this.CheckSnapScrap);
            this.Controls.Add(this.IvarVal);
            this.Controls.Add(this.IvarNum);
            this.Controls.Add(this.CheckIvar);
            this.Controls.Add(this.ResolutionY);
            this.Controls.Add(this.ResolutionX);
            this.Controls.Add(this.CheckResolution);
            this.Controls.Add(this.CheckShellMap);
            this.Controls.Add(this.CheckNoScript);
            this.Controls.Add(this.CheckNobodyHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckEdit);
            this.Controls.Add(this.CheckPowerUser);
            this.Controls.Add(this.CheckNoIntro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckWindow);
            this.Controls.Add(this.ConfigParameter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.BackButton);
            this.MaximizeBox = false;
            this.Name = "PageConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Controls.PictureButton BackButton;
		public System.Windows.Forms.TextBox ConfigParameter;
		public System.Windows.Forms.CheckBox CheckWindow;
		private Controls.PictureButton LaunchButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.CheckBox CheckNoIntro;
		public System.Windows.Forms.CheckBox CheckPowerUser;
		public System.Windows.Forms.CheckBox CheckEdit;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.CheckBox CheckNobodyHome;
		public System.Windows.Forms.CheckBox CheckNoScript;
		public System.Windows.Forms.CheckBox CheckShellMap;
		public System.Windows.Forms.CheckBox CheckResolution;
		private System.Windows.Forms.TextBox ResolutionX;
		private System.Windows.Forms.TextBox ResolutionY;
		public System.Windows.Forms.CheckBox CheckIvar;
		private System.Windows.Forms.TextBox IvarNum;
		private System.Windows.Forms.TextBox IvarVal;
		public System.Windows.Forms.CheckBox CheckSnapScrap;
		public System.Windows.Forms.CheckBox CheckAdjustHeightOnLoad;
		private System.Windows.Forms.TextBox AdjustHeightOnLoadVal;
		public System.Windows.Forms.TextBox CommandPreview;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
