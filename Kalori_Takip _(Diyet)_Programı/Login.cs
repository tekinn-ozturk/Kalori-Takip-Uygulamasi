using Kalori_Takip___Diyet__Programı.Extensions;
using KaloriTakipProgramı.Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KaloriTakipProgramı.Data.Concrete.EF.AppUserRepository;

namespace Kalori_Takip___Diyet__Programı
{
	public partial class Login : Form
	{
		private readonly AppUserService _service;
		public Login()
		{
			_service = new AppUserService();
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			OpeningPage openingPage = new OpeningPage();
			this.Hide();
			openingPage.ShowDialog();

		}



		private void btnHesapOlustur_Click(object sender, EventArgs e)
		{
			Register register = new Register();
			this.Hide();
			register.ShowDialog();
			this.Show();
		}

		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			if (Helper.AlanlariKontrolEtLogin(grpGirisYap.Controls))
			{
				MessageBox.Show("Lütfen tüm alanları doldurun.");
				return;
			}

			var result = _service.AuthenticateUser(txtKullaniciAdi.Text, _service.SifreyiKodla(txtSifre.Text));

			if (result == "Giriş Başarılı")
			{
				var user = _service.TGetByFilter(X => X.Username == txtKullaniciAdi.Text && X.Password == _service.SifreyiKodla(txtSifre.Text));
				if (user != null)
				{

					if (user.ModifiedDate == null)
					{
						IntroductıonTable introductıonTable = new IntroductıonTable(user);
						this.Hide();
						introductıonTable.ShowDialog();
						this.Show();



					}
					if (user.ModifiedDate2 == null)
					{
						IntroduceYourselfActıvıty introduceYourselfActıvıty = new IntroduceYourselfActıvıty(user);
						this.Hide();
						introduceYourselfActıvıty.ShowDialog();
					}
					else
					{
						UserHomePage userHomePage = new UserHomePage(user);
						this.Hide();
						userHomePage.Show();
					}
				}


			}
			if (result == "Şifre Yanlış")
			{
				MessageBox.Show("Lütfen şifrenizi kontrol ediniz");

			}
			if (result == "Kullanıcı Bulunamadı")
			{
				MessageBox.Show("Böyle bir kullanıcı bulunamadı");

			}


		}

		private void btnGoster_MouseDown(object sender, MouseEventArgs e)
		{
			txtSifre.PasswordChar = default;

		}

		private void btnGoster_MouseUp(object sender, MouseEventArgs e)
		{
			txtSifre.PasswordChar = '*';
		}
	}
}

