using FluentValidation.Results;
using Kalori_Takip___Diyet__Programı.Extensions;
using KaloriTakipProgramı.Business.Concrete;
using KaloriTakipProgramı.Business.ValidationRules;
using KaloriTakipProgramı.Entity.Entities;
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
	public partial class UserSettings : Form
	{
		private AppUser _user;
		private readonly AppUserService _userService;

		public UserSettings(AppUser user)
		{
			InitializeComponent();
			_user = user;
			_userService = new AppUserService();
		}

		private void UserSettings_Load(object sender, EventArgs e)
		{
			txtAd.Text = _user.Name;
			txtSoyad.Text = _user.Surname;
			nmrBoy.Value = (decimal)_user.Height.Value;
			nmrKilo.Value = (decimal)_user.Weight.Value;
			nmrYas.Value = (int)_user.Age.Value;
			nmrBasenCevresi.Value = (decimal)_user.BasinCircle.Value;
			nmrBelCevresi.Value = (decimal)_user.WaistCircle.Value;
			nmrBoyunCevresi.Value = (decimal)_user.NeckCircle.Value;

			Image userImage = LoadImages.LoadUserImage(_user.ImagePath);
			if (userImage != null)
			{
				pbxImage.Image = userImage;
			}
		}


		private void btnBilgiileriGuncelle_Click(object sender, EventArgs e)
		{


			if (_userService.ArePasswordsMatching(_userService.SifreyiKodla(txtSifre.Text), _userService.SifreyiKodla(txtSifreTekrar.Text)))
			{
				var kullanici = _userService.TGetByID(_user.AppUserID);
				if (kullanici != null)
				{
					kullanici.Name = txtAd.Text;
					kullanici.Surname = txtSoyad.Text;
					kullanici.Age = (int)nmrYas.Value;
					kullanici.Height = (float)nmrBoy.Value;
					kullanici.Weight = (int)nmrKilo.Value;
					kullanici.BasinCircle = (float)nmrBasenCevresi.Value;
					kullanici.WaistCircle = (float)nmrBelCevresi.Value;
					kullanici.NeckCircle = (float)nmrBoyunCevresi.Value;
					kullanici.Password = txtSifre.Text;
					kullanici.ImagePath = imageName;
					kullanici.ConfirmPassword = txtSifreTekrar.Text;
				}

				AppUserValidator _rules = new AppUserValidator();
				ValidationResult result = _rules.Validate(kullanici);
				kullanici.Password = _userService.SifreyiKodla(kullanici.Password);
				kullanici.ConfirmPassword = _userService.SifreyiKodla(kullanici.ConfirmPassword);
				if (result.IsValid)
				{
					_userService.TUpdate(kullanici);
					MessageBox.Show("Güncelleme İşlemi Başarılı");
					Helper.Temizle(grpKisiselBilgiler.Controls);
					this.Close();
				}
				else
				{
					foreach (var item in result.Errors)
					{

						MessageBox.Show(item.ErrorMessage, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

					}
				}
			}
			else
			{
				MessageBox.Show("Şifreler Eşleşmiyor");
			}
		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			this.Close();
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
			Image userImage = LoadImages.LoadUserImage(_user.ImagePath);
			if (userImage != null)
			{
				pbxImage.Image = userImage;
			}
		}

		private void btnAkviteDuzeyi_Click(object sender, EventArgs e)
		{
			IntroduceYourselfActıvıty introduceYourselfActıvıty = new IntroduceYourselfActıvıty(_user);
			this.Hide();
			introduceYourselfActıvıty.ShowDialog();
			this.Show();
		}
	}
}
