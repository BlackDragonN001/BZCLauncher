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
        }
    }
}
