namespace BZCLauncher
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
            this.ButtonAddons = new BZCLauncher.Controls.PictureButton();
            this.ButtonExit = new BZCLauncher.Controls.PictureButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BZCLauncher.Properties.Resources.Bzlogo;
            this.pictureBox1.Location = new System.Drawing.Point(215, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonAddons
            // 
            this.ButtonAddons.DownImage = global::BZCLauncher.Properties.Resources.ESCCLK;
            this.ButtonAddons.Location = new System.Drawing.Point(213, 108);
            this.ButtonAddons.Name = "ButtonAddons";
            this.ButtonAddons.Size = new System.Drawing.Size(188, 58);
            this.ButtonAddons.TabIndex = 2;
            this.ButtonAddons.Text = "Addons";
            this.ButtonAddons.UpImage = global::BZCLauncher.Properties.Resources.ESCON;
            this.ButtonAddons.Click += new System.EventHandler(this.ButtonAddons_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.DownImage = global::BZCLauncher.Properties.Resources.ESCCLK;
            this.ButtonExit.Location = new System.Drawing.Point(215, 357);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(188, 58);
            this.ButtonExit.TabIndex = 1;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UpImage = global::BZCLauncher.Properties.Resources.ESCON;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // PageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BZCLauncher.Properties.Resources.bztemp;
            this.Controls.Add(this.ButtonAddons);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PageMain";
            this.Size = new System.Drawing.Size(624, 442);
            this.Load += new System.EventHandler(this.PageMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.PictureButton ButtonExit;
        private Controls.PictureButton ButtonAddons;

    }
}
