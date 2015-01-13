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
    public partial class PageMain : UserControl
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void PageMain_Load(object sender, EventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void ButtonAddons_Click(object sender, EventArgs e)
        {
            MainWindow activeForm = (MainWindow)Form.ActiveForm;
            activeForm.PageMain.Visible = false;
            activeForm.PageAddons.Visible = true;
            activeForm.PageConfig.Visible = false;
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            MainWindow activeForm = (MainWindow)Form.ActiveForm;
            string commandArguments = activeForm.PageConfig.ConfigParameter.Text;

            try
            {
                //Form.ActiveForm.Hide();
                //Form.ActiveForm.Show();

                //MainWindow newWindow = new MainWindow();
                //newWindow.Show();

                System.Diagnostics.Process resultProcess = System.Diagnostics.Process.Start("bzone.exe", "/config BZC_bzone.cfg " + commandArguments);

               // resultProcess.WaitForExit();

                //Form.ActiveForm.Visible = true;
            }
            catch (System.ComponentModel.Win32Exception exception)
            {
                MessageBox.Show("An internal exception occurred trying to run BattleZone: " + exception.Message, "Error");
            }

            activeForm.Close();
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            MainWindow activeForm = (MainWindow)Form.ActiveForm;
            activeForm.PageMain.Visible = false;
            activeForm.PageAddons.Visible = false;
            activeForm.PageConfig.Visible = true;
        }
    }
}
