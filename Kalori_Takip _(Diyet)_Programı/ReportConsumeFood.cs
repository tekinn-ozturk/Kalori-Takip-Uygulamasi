using KaloriTakipProgramı.Business.Concrete;
using KaloriTakipProgramı.Data.Concrete.EntityFramework;
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
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kalori_Takip___Diyet__Programı
{
	public partial class ReportConsumeFood : Form
	{
		private readonly ConsumeFoodService _service;
		private readonly ConsumeFoodRepository _service2;

		private AppUser _user;


		public ReportConsumeFood(AppUser user)
		{
			_service = new ConsumeFoodService();
			_service2 = new ConsumeFoodRepository();
			InitializeComponent();
			_user = user;
		}

		private void ReportConsumeFood_Load(object sender, EventArgs e)
		{

		}

		private void btnRaporla_Click(object sender, EventArgs e)
		{
			if (rdbHaftalik.Checked)
			{
				if (rdbOgun.Checked)
				{
					chart1.Series.Clear();
					var consumedFoodsuser = _service2.HaftalıkBazdaOgunRaporuKullanıcıİle(_user.AppUserID, dtTarih.Value);
					chart1.Series.Add("Siz");
					chart1.Series["Siz"].Points.DataBind(consumedFoodsuser, "MealName", "Value", "");
					chart1.Series["Siz"].ChartType = SeriesChartType.Column;


					var consumedFood = _service2.HaftalıkBazdaOgunRaporu(dtTarih.Value);
					chart1.Series.Add("Diğer Kullanıcılar");
					chart1.Series["Diğer Kullanıcılar"].Points.DataBind(consumedFood, "MealName", "Value", "");
					chart1.Series["Diğer Kullanıcılar"].ChartType = SeriesChartType.Column;
				}
				else
				{

					chart1.Series.Clear();
					var consumedFoodsuser = _service2.HaftalıkBazdaKategoriRaporuKullaniciİle(_user.AppUserID,dtTarih.Value);
					chart1.Series.Add("Siz");
					chart1.Series["Siz"].Points.DataBind(consumedFoodsuser, "CategoryName", "TotalCalories", "");
					chart1.Series["Siz"].ChartType = SeriesChartType.Column;

					//İkinci sütun için verileri ayarla
					var consumedFood = _service2.HaftalıkBazdaKategoriRaporu(dtTarih.Value);
					chart1.Series.Add("Diğer Kullanıcılar");
					chart1.Series["Diğer Kullanıcılar"].Points.DataBind(consumedFood, "CategoryName", "TotalCalories", "");
					chart1.Series["Diğer Kullanıcılar"].ChartType = SeriesChartType.Column;



				}

			}

			else
			{
				if (rdbOgun.Checked)
				{
					chart1.Series.Clear();
					var consumedFoodsuser = _service2.AylıkBazdaOgunRaporuKullanıcıİle(_user.AppUserID, dtTarih.Value);
					chart1.Series.Add("Siz");
					chart1.Series["Siz"].Points.DataBind(consumedFoodsuser, "MealName", "Value", "");
					chart1.Series["Siz"].ChartType = SeriesChartType.Column;

					// İkinci sütun için verileri ayarla
					var consumedFood = _service2.AylıkBazdaOgunRaporu(dtTarih.Value);
					chart1.Series.Add("Diğer Kullanıcılar");
					chart1.Series["Diğer Kullanıcılar"].Points.DataBind(consumedFood, "MealName", "Value", "");
					chart1.Series["Diğer Kullanıcılar"].ChartType = SeriesChartType.Column;
				}
				else
				{

					chart1.Series.Clear();
					var consumedFoodsuser = _service2.AylıkBazdaKategoriRaporuKullanıcıİle(_user.AppUserID, dtTarih.Value);
					chart1.Series.Add("Siz");
					chart1.Series["Siz"].Points.DataBind(consumedFoodsuser, "CategoryName", "TotalCalories", "");
					chart1.Series["Siz"].ChartType = SeriesChartType.Column;

					var consumedFood = _service2.AylıkBazdaKategoriRaporu(dtTarih.Value);
					chart1.Series.Add("Diğer Kullanıcılar");
					chart1.Series["Diğer Kullanıcılar"].Points.DataBind(consumedFood, "CategoryName", "TotalCalories", "");
					chart1.Series["Diğer Kullanıcılar"].ChartType = SeriesChartType.Column;

				}

			}
		}


	}
}
