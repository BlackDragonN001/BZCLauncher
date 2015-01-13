using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BZCLauncher.Pages
{
    public partial class PageConfig : UserControl
    {
        private Boolean mIsAutoAddingWin = false;

        public PageConfig()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainWindow activeForm = (MainWindow)Form.ActiveForm;
            activeForm.PageMain.Visible = true;
            activeForm.PageAddons.Visible = false;
            activeForm.PageConfig.Visible = false;
        }

        private void ConfigParameter_Changed(object sender, EventArgs e)
        {
            string parameterText = ConfigParameter.Text.ToLower();

            if (parameterText.Contains("/win") && !CheckWindow.Checked)
            {
                if (!mIsAutoAddingWin)
                    CheckWindow.Checked = true;
            }
            else if (!mIsAutoAddingWin && !parameterText.Contains("/win"))
                CheckWindow.Checked = false;
        }

        private void CheckWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckWindow.Checked && !ConfigParameter.Text.Contains("/win"))
            {
                mIsAutoAddingWin = true;
                ConfigParameter.Text += " /win";
                mIsAutoAddingWin = false;
            }
            else if (!CheckWindow.Checked)
            {
                ConfigParameter.Text = ConfigParameter.Text.ToLower().Replace("/win", "").TrimEnd();
            }
        }
    }
}
