namespace BZCLauncher.Forms
{
    partial class PageMain
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConfigButton = new BZCLauncher.Controls.PictureButton();
            this.LaunchButton = new BZCLauncher.Controls.PictureButton();
            this.ButtonAddons = new BZCLauncher.Controls.PictureButton();
            this.ButtonExit = new BZCLauncher.Controls.PictureButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::BZCLauncher.Properties.Resources.bzctag;
            this.pictureBox1.Location = new System.Drawing.Point(256, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ConfigButton
            // 
            this.ConfigButton.DownImage = global::BZCLauncher.Properties.Resources.BLbtnclk;
            this.ConfigButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigButton.ForeColor = System.Drawing.Color.Lime;
            this.ConfigButton.IdleImage = global::BZCLauncher.Properties.Resources.BLbtnoff;
            this.ConfigButton.Location = new System.Drawing.Point(0, 445);
            this.ConfigButton.MousedOverImage = global::BZCLauncher.Properties.Resources.BLbtnon;
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(200, 35);
            this.ConfigButton.TabIndex = 4;
            this.ConfigButton.Text = "CONFIG";
            this.ConfigButton.TextOffset = new System.Drawing.Point(-6, 1);
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // LaunchButton
            // 
            this.LaunchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchButton.DownImage = global::BZCLauncher.Properties.Resources.TRbtnclk;
            this.LaunchButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchButton.ForeColor = System.Drawing.Color.Lime;
            this.LaunchButton.IdleImage = global::BZCLauncher.Properties.Resources.TRbtnoff;
            this.LaunchButton.Location = new System.Drawing.Point(488, 0);
            this.LaunchButton.MousedOverImage = global::BZCLauncher.Properties.Resources.TRbtnon;
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(152, 34);
            this.LaunchButton.TabIndex = 3;
            this.LaunchButton.Text = "LAUNCH";
            this.LaunchButton.TextOffset = new System.Drawing.Point(-12, -3);
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // ButtonAddons
            // 
            this.ButtonAddons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddons.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonAddons.DownImage = global::BZCLauncher.Properties.Resources.BRbtnclk;
            this.ButtonAddons.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddons.ForeColor = System.Drawing.Color.Lime;
            this.ButtonAddons.IdleImage = global::BZCLauncher.Properties.Resources.BRbtnoff;
            this.ButtonAddons.Location = new System.Drawing.Point(440, 445);
            this.ButtonAddons.MousedOverImage = global::BZCLauncher.Properties.Resources.BRbtnon;
            this.ButtonAddons.Name = "ButtonAddons";
            this.ButtonAddons.Size = new System.Drawing.Size(200, 35);
            this.ButtonAddons.TabIndex = 2;
            this.ButtonAddons.Text = "EXPANSIONS";
            this.ButtonAddons.TextOffset = new System.Drawing.Point(12, 1);
            this.ButtonAddons.Click += new System.EventHandler(this.ButtonAddons_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.DownImage = global::BZCLauncher.Properties.Resources.TLbtnclk;
            this.ButtonExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.Lime;
            this.ButtonExit.IdleImage = global::BZCLauncher.Properties.Resources.TLbtnoff;
            this.ButtonExit.Location = new System.Drawing.Point(0, 0);
            this.ButtonExit.MousedOverImage = global::BZCLauncher.Properties.Resources.TLbtnon;
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(152, 34);
            this.ButtonExit.TabIndex = 1;
            this.ButtonExit.Text = "EXIT";
            this.ButtonExit.TextOffset = new System.Drawing.Point(16, -3);
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // PageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BZCLauncher.Properties.Resources.bzclbackground;
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.ButtonAddons);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PageMain";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.PageMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.PictureButton ButtonExit;
        private Controls.PictureButton ButtonAddons;
        private Controls.PictureButton LaunchButton;
        private Controls.PictureButton ConfigButton;

    }
}
