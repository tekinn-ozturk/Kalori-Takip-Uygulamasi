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
	public partial class Register : Form
	{
		private readonly AppUserService _userService;
		private readonly AppRoleService _roleService;


		public Register()
		{
			_userService = new AppUserService();
			_roleService = new AppRoleService();
			InitializeComponent();
		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			OpeningPage openingPage = new OpeningPage();
			this.Hide();
			openingPage.ShowDialog();
		}

		private void btnKayitOl_Click(object sender, EventArgs e)
		{
			if (_userService.TIsEmailExist(txtEmail.Text))
			{
				MessageBox.Show("Böyle bir mail veritabanın mevcut");
			}
			else
			{

				var role = _roleService.TGetByFilter(x => x.RoleName == "Member");
				if (_userService.ArePasswordsMatching(_userService.SifreyiKodla(txtSifre.Text), _userService.SifreyiKodla(txtSifreTekrar.Text)))
				{
					var user = new AppUser()
					{
						Name = txtAd.Text,
						Surname = txtSoyad.Text,
						Email = txtEmail.Text,
						Username = txtKullaniciAdi.Text,
						Password = txtSifre.Text,
						ConfirmPassword = txtSifreTekrar.Text,
						Gender = (rdbErkek.Checked ? "Erkek" : (rdbKadin.Checked ? "Kadın" : string.Empty)),
						Status = true,
						CreatedDate = DateTime.Now,
						RoleID = role.RoleID
					};
					AppUserValidator _rules = new AppUserValidator();
					ValidationResult result = _rules.Validate(user);
					user.Password = _userService.SifreyiKodla(user.Password);
					user.ConfirmPassword = _userService.SifreyiKodla(user.ConfirmPassword);
					if (result.IsValid)
					{
						_userService.TAdd(user);
						MessageBox.Show("Tebrikler Kayıt İşleminiz Başarılı");
						Helper.Temizle(grpKayitOl.Controls);
						lblGüvenlikSeviyesi.Text = string.Empty;
						lblSifreEslesmeDurumu.Text = string.Empty;
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

		}

		private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
		{
			if (_userService.ArePasswordsMatching(_userService.SifreyiKodla(txtSifre.Text), _userService.SifreyiKodla(txtSifreTekrar.Text)))
			{
				lblSifreEslesmeDurumu.Text = "Şifreler eşleşti";
			}
			else
			{
				lblSifreEslesmeDurumu.Text = "Şifreler eşleşmiyor.Lütfen aynı şifreyi tekrar girin.";
			}

		}

		private void txtSifre_TextChanged(object sender, EventArgs e)
		{
			lblGüvenlikSeviyesi.Text = _userService.CheckPasswordStrength(txtSifre.Text);
		}

		private void btnGoster_Click(object sender, EventArgs e)
		{

		}

		private void btnGoster_MouseDown(object sender, MouseEventArgs e)
		{
			txtSifre.PasswordChar = default;
			txtSifreTekrar.PasswordChar = default;
		}

		private void btnGoster_MouseUp(object sender, MouseEventArgs e)
		{
			txtSifre.PasswordChar = '*';
			txtSifreTekrar.PasswordChar = '*';
		}
	}
}
