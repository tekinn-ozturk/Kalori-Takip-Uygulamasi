using Kalori_Takip___Diyet__Programı.Extensions;
using KaloriTakipProgramı.Business.Concrete;
using KaloriTakipProgramı.Business.Formules;
using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalori_Takip___Diyet__Programı
{
	public partial class WaterTracking : Form
	{
		private AppUser _user;
		private Water _water;
		private readonly WaterService _waterService;
		private readonly AppUserService _userService;


		public WaterTracking(AppUser user)
		{
			InitializeComponent();
			_user = user;
			_waterService = new WaterService();
			_water = new Water();
			_userService = new AppUserService();

		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		float kilo;
		float sulitresi;
		private void WaterTracking_Load(object sender, EventArgs e)
		{
			kilo = (float)_user.Weight;

			lblKilo.Text = kilo.ToString();
			sulitresi = Formul.HesaplaGunlukSuIhtiyaci(kilo);
			if (!_user.LastWaterAdditionDate.HasValue)
			{
				lblİcmenizGerekenSuMiktari.Text = $"Bugün İçmeniz Gereken Su Miktarı {(sulitresi / 1000)} Litredir.";
			}
			else
			{
				SuMiktarıHesapla();
			}

		}
		private void SuMiktarıHesapla()
		{
			flowLayoutPanel1.Controls.Clear();
			suMiktari = _waterService.TGetWaterByUserIdAndDate(_user.AppUserID, dtSuTarih.Value.Date);

			if (suMiktari!=null)
			{
				flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
				float sulitresi = Formul.HesaplaGunlukSuIhtiyaci(kilo);
				double suIhtiyaci = (sulitresi / 1000) - (suMiktari.WaterQuantity * 0.25);
				string suIhtiyaciMetin = string.Format("Bugün İçmeniz Gereken Su Miktarı {0:F2} Litredir.", suIhtiyaci);
				lblİcmenizGerekenSuMiktari.Text = suIhtiyaciMetin;
				for (int i = 0; i < suMiktari.WaterQuantity; i++)
				{

					PictureBox bardakPictureBox = new PictureBox();
					bardakPictureBox.Image = pbxSuBardagi.Image;
					bardakPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
					bardakPictureBox.Size = new Size(45, 86);
					flowLayoutPanel1.Controls.Add(bardakPictureBox);
				}
			}
			else
			{
				lblİcmenizGerekenSuMiktari.Text = $"Bugün İçmeniz Gereken Su Miktarı {(sulitresi / 1000)} Litredir.";
			}
			
		}



		Water guncellenecekWater;
		private void btnSuEkle_Click(object sender, EventArgs e)
		{
			if (!_user.LastWaterAdditionDate.HasValue || _user.LastWaterAdditionDate.Value.Date < DateTime.Now.Date)
			{
				_water = new Water()
				{
					WaterQuantity = (float)nmrSuMiktari.Value,
					ConsumedDate = DateTime.Now.Date,
					AppUserID = _user.AppUserID,
					ModifiedDate2 = DateTime.Now.Date,
				};
				_waterService.TAdd(_water);
				_user.LastWaterAdditionDate = DateTime.Now.Date;
				_userService.TUpdate(_user);
				MessageBox.Show("Ekleme İşlemi Başarılı");
				SuMiktarıHesapla();
				Helper.Temizle(grpSuMiktariGir.Controls);
			}
			else
			{
				guncellenecekWater = _waterService.TGetWaterByUserIdAndDate(_user.AppUserID, dtSuTarih.Value.Date);
				guncellenecekWater.WaterQuantity += (float)nmrSuMiktari.Value;
				guncellenecekWater.ModifiedDate2 = DateTime.Now.Date;
				_user.LastWaterAdditionDate = DateTime.Now.Date;
				_userService.TUpdate(_user);
				_waterService.TUpdate(guncellenecekWater);
				SuMiktarıHesapla();
				MessageBox.Show("Güncelleme İşlemi Başarılı");
			}



		}

		Water suMiktari;
		private void dtSuTarih_ValueChanged(object sender, EventArgs e)
		{
			if (dtSuTarih.Value.Date < DateTime.Now.Date)
			{
				btnSuEkle.Enabled = false;
				suMiktari = _waterService.TGetWaterByUserIdAndDate(_user.AppUserID, dtSuTarih.Value.Date);
				if (suMiktari == null)
				{
					MessageBox.Show("Bu tarihte bir veri bulunamadı");
				}
				else
				{
					lblGecmisİcilmisSu.Text = $"İçtiğiniz su {suMiktari.WaterQuantity} bardaktır";
				}


			}
			if (dtSuTarih.Value.Date == DateTime.Now.Date)
			{
				btnSuEkle.Enabled = true;
				lblGecmisİcilmisSu.Text = "";
			}
			if (dtSuTarih.Value.Date > DateTime.Now.Date)
			{

				btnSuEkle.Enabled = false;
				suMiktari = _waterService.TGetWaterByUserIdAndDate(_user.AppUserID, dtSuTarih.Value.Date);
				if (suMiktari == null)
				{
					MessageBox.Show("Bu tarihte bir veri bulunamadı");
				}
				else
				{
					lblGecmisİcilmisSu.Text = $"İçtiğiniz su {suMiktari.WaterQuantity} bardaktır";
				}
				lblGecmisİcilmisSu.Text = "";
			}




		}
	}
}
