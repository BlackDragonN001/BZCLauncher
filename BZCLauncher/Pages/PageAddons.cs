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
	public partial class PageAddons : Page
	{
		public PageAddons()
		{
			this.InitializeComponent();
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.MainWindow.ShowPage("Main");
		}

		private void LaunchButton_Click(object sender, EventArgs e)
		{
			this.MainWindow.LaunchGame();
		}

		private void Enable_Click(object sender, EventArgs e)
		{

		}

		private void Install_Click(object sender, EventArgs e)
		{

		}
	}
}
