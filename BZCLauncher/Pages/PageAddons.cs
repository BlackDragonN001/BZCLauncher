using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BZCLauncher
{
    public partial class PageAddons : UserControl
    {
        public PageAddons()
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

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            MainWindow activeForm = (MainWindow)Form.ActiveForm;
            activeForm.LaunchGame();
        }

        private void Enable_Click(object sender, EventArgs e)
        {

        }

        private void Install_Click(object sender, EventArgs e)
        {

        }
    }
}
