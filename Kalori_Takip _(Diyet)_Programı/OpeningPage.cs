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
	public partial class OpeningPage : Form
	{
		public OpeningPage()
		{
			InitializeComponent();
		}

		private void btnHakkimizda_Click(object sender, EventArgs e)
		{
			AboutUs aboutUs = new AboutUs();
			this.Hide();
			aboutUs.ShowDialog();
			this.Show();


		}

		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			this.Hide();
			login.ShowDialog();
		}

		private void btnKayitOl_Click(object sender, EventArgs e)
		{
			Register register = new Register();
			this.Hide();
			register.ShowDialog();
		}

		private void btnUyeOlmadanDevamEt_Click(object sender, EventArgs e)
		{
			PersonalInformation personalInformation = new PersonalInformation();
			this.Hide();
			personalInformation.ShowDialog();
			this.Show();
		}
	}
}
