namespace BZCLauncher
{
    partial class PageAddons
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
            this.BackButton = new BZCLauncher.Controls.PictureButton();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.DownImage = global::BZCLauncher.Properties.Resources.ESCCLK;
            this.BackButton.Location = new System.Drawing.Point(214, 349);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(188, 58);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UpImage = global::BZCLauncher.Properties.Resources.ESCON;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PageAddons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BZCLauncher.Properties.Resources.battle800x600;
            this.Controls.Add(this.BackButton);
            this.Name = "PageAddons";
            this.Size = new System.Drawing.Size(624, 442);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PictureButton BackButton;
    }
}
