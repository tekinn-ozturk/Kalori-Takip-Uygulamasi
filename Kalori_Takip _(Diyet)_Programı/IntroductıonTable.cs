using Kalori_Takip___Diyet__Programı.Properties;
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
	public partial class IntroductıonTable : Form
	{


		public IntroductıonTable(AppUser user)
		{
			InitializeComponent();
			this.user = user;
		}

		private int currentImageIndex = 1;
		private const int totalImages = 10;
		int count = 0;
		private AppUser user;

		private void btnİleri_Click(object sender, EventArgs e)
		{
			currentImageIndex++;
			if (currentImageIndex > totalImages)
			{
				currentImageIndex = 1;
			}
			if (currentImageIndex == 10)
			{
				IntroduceYourself introduce = new IntroduceYourself(user);
				this.Hide();
				introduce.ShowDialog();
			}
			else
			{
				LoadImage(currentImageIndex);
			}
		}
		private void LoadImage(int imageIndex)
		{
			pbxResim.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject($"{imageIndex}");
		}
		private void IntroductıonTable_Load(object sender, EventArgs e)
		{
			LoadImage(currentImageIndex);
		}

		private void btnGeri_Click(object sender, EventArgs e)
		{
			currentImageIndex--;
			if (currentImageIndex < 1)
			{
				currentImageIndex = totalImages;
			}
			LoadImage(currentImageIndex);
		}

		private void btnGec_Click(object sender, EventArgs e)
		{
			IntroduceYourself introduce = new IntroduceYourself(user);
			this.Hide();
			introduce.ShowDialog();
		}
	}
}
