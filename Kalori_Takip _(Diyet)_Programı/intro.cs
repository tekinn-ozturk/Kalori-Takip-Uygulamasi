using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kalori_Takip___Diyet__Programı
{
	public partial class intro : Form
	{
		public intro()
		{
			InitializeComponent();
		}

		private void intro_Load(object sender, EventArgs e)
		{
			tmrIntro.Interval = 50;
			pgrBar.Minimum = 0;
			pgrBar.Maximum = 100;
			pgrBar.Step = 1;
			pgrBar.ForeColor = System.Drawing.Color.Orange;
			tmrIntro.Start();
		}
		private void tmrIntro_Tick(object sender, EventArgs e)
		{
			//if (pgrBar.Value == 100)
			//{

			//	pgrBar.Value += 1;
			//}
			//else
			//{
			//	tmrIntro.Stop();
			//	Login form2 = new Login();
			//	form2.Show();
			//	this.Hide();
			//}
			if (pgrBar.Value < pgrBar.Maximum)
			{
				pgrBar.PerformStep();
			}
			else
			{
				tmrIntro.Stop();
				OpeningPage page = new OpeningPage();
				page.Show();
				this.Hide();
			}
		}


	}
}