using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalori_Takip___Diyet__Programı
{
	public partial class AboutUs : Form
	{
		public AboutUs()
		{
			InitializeComponent();
		}
		private void AboutUs_Load(object sender, EventArgs e)
		{
			labelCredits.Visible = false;
			tmrAboutUs.Interval = 1000;
			tmrAboutUs.Start();
		}
		private void btnCredits_Click(object sender, EventArgs e)
		{
			labelCredits.Visible = true;
		}

		private int elapsedTime = 0;
		private void tmrAboutUs_Tick(object sender, EventArgs e)
		{
			elapsedTime += 1;

			if (elapsedTime >= 5)
			{
				tmrAboutUs.Stop();
				this.Close();
			}
		}


	}
}
