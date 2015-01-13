namespace BZCLauncher.Pages
{
    partial class PageConfig
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
            this.ConfigParameter = new System.Windows.Forms.TextBox();
            this.CheckWindow = new System.Windows.Forms.CheckBox();
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
            // ConfigParameter
            // 
            this.ConfigParameter.Location = new System.Drawing.Point(276, 176);
            this.ConfigParameter.Name = "ConfigParameter";
            this.ConfigParameter.Size = new System.Drawing.Size(100, 20);
            this.ConfigParameter.TabIndex = 1;
            this.ConfigParameter.TextChanged += new System.EventHandler(this.ConfigParameter_Changed);
            // 
            // CheckWindow
            // 
            this.CheckWindow.AutoSize = true;
            this.CheckWindow.Location = new System.Drawing.Point(276, 233);
            this.CheckWindow.Name = "CheckWindow";
            this.CheckWindow.Size = new System.Drawing.Size(107, 17);
            this.CheckWindow.TabIndex = 2;
            this.CheckWindow.Text = "Windowed Mode";
            this.CheckWindow.UseVisualStyleBackColor = true;
            this.CheckWindow.CheckedChanged += new System.EventHandler(this.CheckWindow_CheckedChanged);
            // 
            // PageConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BZCLauncher.Properties.Resources.bzclbackground;
            this.Controls.Add(this.CheckWindow);
            this.Controls.Add(this.ConfigParameter);
            this.Controls.Add(this.BackButton);
            this.Name = "PageConfig";
            this.Size = new System.Drawing.Size(640, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PictureButton BackButton;
        public System.Windows.Forms.TextBox ConfigParameter;
        public System.Windows.Forms.CheckBox CheckWindow;
    }
}
