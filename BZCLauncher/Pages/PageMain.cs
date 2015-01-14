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
	public partial class PageMain : Page
	{
		public PageMain()
		{
			this.InitializeComponent();
		}

		private void PageMain_Load(object sender, EventArgs e)
		{

		}

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			this.MainWindow.Close();
		}

		private void ButtonAddons_Click(object sender, EventArgs e)
		{
			this.MainWindow.ShowPage("Addons");
		}

		private void LaunchButton_Click(object sender, EventArgs e)
		{
			this.MainWindow.LaunchGame();
		}

		private void ConfigButton_Click(object sender, EventArgs e)
		{
			this.MainWindow.ShowPage("Config");
		}
	}
}
