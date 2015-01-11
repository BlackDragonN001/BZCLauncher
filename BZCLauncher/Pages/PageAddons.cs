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
        }
    }
}
