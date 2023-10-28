using Kalori_Takip___Diyet__Programı.Extensions;
using Kalori_Takip___Diyet__Programı.Properties;
using KaloriTakipProgramı.Business.Concrete;
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

namespace Kalori_Takip___Diyet__Programı
{
	public partial class FoodShow : Form
	{

		private DateTime _date;
		private Meal _result;
		private readonly ConsumeFoodService _foodService;



		public FoodShow(Meal result, DateTime date)
		{
			InitializeComponent();
			_result = result;
			_date = date;
			_foodService = new ConsumeFoodService();
		}

		private void FoodShow_Load(object sender, EventArgs e)
		{
			lstKaydedilenUrunler.Items.Clear();
			var tuketilenUrunler = _foodService.TGetConsumeFood(_result.MealID, _date);
			var tuketilenUrun = _foodService.TGetConsumeFood2(_result.MealID, _date);
			if (tuketilenUrun != null)
			{
				foreach (ConsumeFood food in tuketilenUrunler)
				{

					ListViewItem item = new ListViewItem();
					item.Text = food.ConsumeFoodName;
					item.SubItems.Add(food.GramCompensation.ToString());
					item.SubItems.Add(food.Calories.ToString());
					item.SubItems.Add(food.Protein.ToString());
					item.SubItems.Add(food.Fat.ToString());
					item.SubItems.Add(food.Carbohydrate.ToString());
					item.Tag = food;
					lstKaydedilenUrunler.Items.Add(item);

				}
				if (_result.MealID == 1)
				{
					lblGosterBaslik.Text = $"{_date.Date} Tarihinde Sabah Öğününde Tüketilen Yiyecek Listesi";
				}
				else if (_result.MealID == 2)
				{
					lblGosterBaslik.Text = $"{_date.Date} Tarihinde Öğle Öğününde Tüketilen Yiyecek Listesi";
				}
				else if (_result.MealID == 3)
				{
					lblGosterBaslik.Text = $"{_date.Date.Date} Tarihinde Akşam Öğününde Tüketilen Yiyecek Listesi";
				}
				else
				{
					lblGosterBaslik.Text = $"{_date.Date.Date} Tarihinde Aperatif Olarak Tüketilen Yiyecek Listesi";
				}

				Image ımage = LoadImages.LoadFoodImage(tuketilenUrun.ImagePath);
				if (ımage != null)
				{
					pbxYemekResmi.Image = Resources.defaultyemek;
				}
				pbxYemekResmi.Image = ımage;
			}
			else
			{
				DialogResult dr = MessageBox.Show("Henüz tüketilen yiyecek bilgisi bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

				if (dr == DialogResult.OK)
				{
					this.Close();
				}
			}
		
			
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (lstKaydedilenUrunler.SelectedItems.Count == 0)
			{
				MessageBox.Show("Lütfen silmek istediğiniz ürünü seçiniz");
			}
			else
			{
				var result = (ConsumeFood)lstKaydedilenUrunler.SelectedItems[0].Tag;
				_foodService.TDelete(result);
				lstKaydedilenUrunler.Items.Remove(lstKaydedilenUrunler.SelectedItems[0]);
				lstKaydedilenUrunler.Refresh();
				MessageBox.Show("Ürün veritabanından başarıyla silindi");
			}
		}
	}
}
