﻿namespace BZCLauncher
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
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
            this.BackButton.TextOffset = new System.Drawing.Point(15, -3);
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BZCLauncher.Properties.Resources.bzctag;
            this.pictureBox1.Location = new System.Drawing.Point(256, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PageAddons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BZCLauncher.Properties.Resources.bzclbackground;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Name = "PageAddons";
            this.Size = new System.Drawing.Size(640, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PictureButton BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}