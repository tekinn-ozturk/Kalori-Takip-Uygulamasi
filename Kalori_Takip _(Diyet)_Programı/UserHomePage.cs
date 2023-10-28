using Kalori_Takip___Diyet__Programı.Extensions;
using Kalori_Takip___Diyet__Programı.Properties;
using KaloriTakipProgramı.Business.Formules;
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
	public partial class UserHomePage : Form
	{
		private readonly AppUser _user;

		public UserHomePage(AppUser user)
		{
			InitializeComponent();
			_user = user;
		}

		private void btnKaloriTakibi_Click(object sender, EventArgs e)
		{
			MealTable mealTable = new MealTable(_user);
			this.Hide();
			mealTable.ShowDialog();
			this.Show();
		}
		string cinsiyet;
		double kilo;
		double boy;
		int yas;
		double activityValue;
		private void UserHomePage_Load(object sender, EventArgs e)
		{
			cinsiyet = _user.Gender.ToString();
			kilo = (double)_user.Weight;
			boy = (double)_user.Height;
			yas = (int)_user.Age;
			activityValue = (double)_user.ActivityValue;
			lblKisiAdi.Text = $"{_user.Name} {_user.Surname}";

			Image userImage = LoadImages.LoadUserImage(_user.ImagePath);
			if (userImage != null)
			{
				pbxUserImage.Image = userImage;
			}


		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnSuTakibi_Click(object sender, EventArgs e)
		{
			WaterTracking waterTracking = new WaterTracking(_user);
			this.Hide();
			waterTracking.ShowDialog();
			this.Show();
		}



		private void btnProfil_Click(object sender, EventArgs e)
		{
			UserInformatıons userInformatıons = new UserInformatıons(_user);
			this.Hide();
			userInformatıons.ShowDialog();
			this.Show();
		}

		private void btnYemekMiKacKolari_Click(object sender, EventArgs e)
		{
			HowManyCalories howManyCalories = new HowManyCalories();
			this.Hide();
			howManyCalories.ShowDialog();
			this.Show();
		}

		private void btnRaporlar_Click(object sender, EventArgs e)
		{
			ReportConsumeFood reportConsumeFood = new ReportConsumeFood(_user);
			this.Hide();
			reportConsumeFood.ShowDialog();
			this.Show();
		}


	}
}
