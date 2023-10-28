using Kalori_Takip___Diyet__Programı.Extensions;
using KaloriTakipProgramı.Business.Concrete;
using KaloriTakipProgramı.Business.Formules;
using KaloriTakipProgramı.Entity.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Kalori_Takip___Diyet__Programı
{
	public partial class IntroduceYourself : Form
	{
		private readonly AppUser _user;
		private readonly AppUserService _userService;
		public IntroduceYourself(AppUser user)
		{
			InitializeComponent();
			_user = user;
			_userService = new AppUserService();
		}


		private void Introduce_Load(object sender, EventArgs e)
		{

		}
		bool islemTamamMi = false;
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (Helper.AlanlariKontrolEtInroduce(grpKisiselBilgiler.Controls))
			{
				MessageBox.Show("Lütfen tüm alanları doldurun.");
				return;
			}

			var user = _user;
			float kilo = (float)nmrKilo.Value;
			float boy = (float)nmrBoy.Value;
			string cinsiyet = _user.Gender;
			int yas = (int)nmrYas.Value;
			float belcevresi = (float)nmrBelCevresi.Value;
			float boyunCevresi = (float)nmrBoyunCevresi.Value;
			float basenCevresi = (float)nmrBasenCevresi.Value;
			_user.Height = (float)nmrBoy.Value;
			_user.Weight = (float)nmrKilo.Value;
			_user.Age = (int)nmrYas.Value;
			_user.NeckCircle = boyunCevresi;
			_user.BasinCircle = basenCevresi;
			_user.WaistCircle = belcevresi;
			_user.ModifiedDate = DateTime.Now;
			_user.VKI = Formul.HesaplaBMI(kilo, boy);
			_user.VYO = Formul.HesaplaVucutYagOrani(cinsiyet, kilo, boy, yas, belcevresi, boyunCevresi, basenCevresi);
			_user.BMH = Formul.HesaplaBMR(cinsiyet, kilo, boy, yas);
			_user.ImagePath = imageName;
			_userService.TUpdate(user);
			islemTamamMi = true;
			if (_userService.BelBoyunKontrol(belcevresi, boyunCevresi))
			{
				if (islemTamamMi)
				{
					if (_user.ModifiedDate2 == null)
					{
						MessageBox.Show("Bilgiler Kaydedildi");
						IntroduceYourselfActıvıty introduceYourselfActıvıty = new IntroduceYourselfActıvıty(_user);
						this.Hide();
						introduceYourselfActıvıty.ShowDialog();
						this.Show();
					}
					else
					{
						UserHomePage userHomePage = new UserHomePage(_user);
						this.Hide();
						userHomePage.ShowDialog();
						this.Show();
					}

				}
				else
				{
					MessageBox.Show("Kaydetme Başarısız");
				}
			}
			else
			{
				MessageBox.Show("Boyun Çevresi Bel Çevresinden Büyük Olamaz");
			}
		}
		string imageName;
		private void btnResimEkle_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif|Tüm Dosyalar|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string selectedImagePath = openFileDialog.FileName;
				string fileExtension = Path.GetExtension(selectedImagePath);
				imageName = Guid.NewGuid().ToString() + fileExtension;
				string saveLocation = Path.Combine(Application.StartupPath, "UserImage", imageName);
				File.Copy(selectedImagePath, saveLocation);
				_user.ImagePath = imageName;
			}
		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{

		}
	}
}
