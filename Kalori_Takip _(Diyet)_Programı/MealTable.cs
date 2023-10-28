using KaloriTakipProgramı.Business.Abstract;
using KaloriTakipProgramı.Business.Concrete;
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
	public partial class MealTable : Form
	{
		private AppUser _user;
		private readonly ConsumeFoodService _consumeFoodService;
		private readonly MealService _mealService;


		public MealTable(AppUser user)
		{
			InitializeComponent();
			_user = user;
			_consumeFoodService = new ConsumeFoodService();
			_mealService = new MealService();
		}


		DateTime tuketimTarihi;
		bool dateTimePickerIsAktif = false;
		private void MealTable_Load(object sender, EventArgs e)
		{
			brekfast = _mealService.TGetByMealIDBreakfast();
			dinner = _mealService.TGetByMealIDDinner();
			brunch = _mealService.TGetByMealIDBrunch();
			Aperatif = _mealService.TGetByMealIDSnack();



			DateTime secilenTarih;
			if (dateTimePickerIsAktif == true)
			{
				secilenTarih = dtpMealDate.Value;
			}
			else
			{
				secilenTarih = DateTime.Now;
			}
			BesinDegeriTopla(brekfast.MealName, secilenTarih);

			BesinDegeriTopla(brunch.MealName, secilenTarih);

			BesinDegeriTopla(dinner.MealName, secilenTarih);

			BesinDegeriTopla(Aperatif.MealName, secilenTarih);
			TotalBesinDegeri(secilenTarih);
		}
		Meal brekfast;
		private void btnSabahGoster_Click(object sender, EventArgs e)
		{

			if (dateTimePickerIsAktif == true)
			{
				FoodShow foodShow = new FoodShow(brekfast, dtpMealDate.Value.Date);
				foodShow.ShowDialog();
				BesinDegeriTopla(brekfast.MealName, dtpMealDate.Value.Date);
				TotalBesinDegeri(dtpMealDate.Value.Date);
			}
			else
			{
				FoodShow foodShow = new FoodShow(brekfast, DateTime.Now.Date);
				foodShow.ShowDialog();
				BesinDegeriTopla(brekfast.MealName, DateTime.Now.Date);
				TotalBesinDegeri(dtpMealDate.Value.Date);
			}
		}
		Meal dinner;
		private void btnAksamGoster_Click(object sender, EventArgs e)
		{

			if (dateTimePickerIsAktif == true)
			{
				FoodShow foodShow = new FoodShow(dinner, dtpMealDate.Value.Date);
				foodShow.ShowDialog();
				BesinDegeriTopla(dinner.MealName, DateTime.Now.Date);
				TotalBesinDegeri(dtpMealDate.Value.Date);
			}
			else
			{
				FoodShow foodShow = new FoodShow(dinner, DateTime.Now.Date);
				foodShow.ShowDialog();
				BesinDegeriTopla(dinner.MealName, DateTime.Now.Date);
				TotalBesinDegeri(dtpMealDate.Value.Date);
			}
		}
		Meal brunch;
		private void btnOgleGoster_Click(object sender, EventArgs e)
		{

			if (dateTimePickerIsAktif == true)
			{
				FoodShow foodShow = new FoodShow(brunch, dtpMealDate.Value.Date);
				foodShow.ShowDialog();
				BesinDegeriTopla(brunch.MealName, DateTime.Now.Date);
				TotalBesinDegeri(dtpMealDate.Value.Date);
			}
			else
			{
				FoodShow foodShow = new FoodShow(brunch, DateTime.Now.Date);
				foodShow.ShowDialog();
				BesinDegeriTopla(brunch.MealName, DateTime.Now.Date);
				TotalBesinDegeri(dtpMealDate.Value.Date);
			}
		}
		Meal Aperatif;
		private void btnAperatifGoster_Click(object sender, EventArgs e)
		{
			if (dateTimePickerIsAktif == true)
			{
				FoodShow foodShow = new FoodShow(Aperatif, dtpMealDate.Value.Date);
				foodShow.ShowDialog();
				BesinDegeriTopla(Aperatif.MealName, DateTime.Now.Date);
				TotalBesinDegeri(dtpMealDate.Value.Date);
			}
			else
			{
				FoodShow foodShow = new FoodShow(Aperatif, DateTime.Now.Date);
				foodShow.ShowDialog();
				BesinDegeriTopla(Aperatif.MealName, DateTime.Now.Date);
				TotalBesinDegeri(dtpMealDate.Value.Date);

			}
		}

		private void dtpMealDate_ValueChanged(object sender, EventArgs e)
		{
			dateTimePickerIsAktif = true;
			DateTime secilenTarih = dtpMealDate.Value.Date;
			if (secilenTarih.Date != DateTime.Now.Date)
			{
				btnKahvaltiEkle.Enabled = false;
				btnAksamYemegi.Enabled = false;
				btnOgleYemegi.Enabled = false;
				btnAperatifEkle.Enabled = false;
			}
			else
			{
				btnKahvaltiEkle.Enabled = true;
				btnAksamYemegi.Enabled = true;
				btnOgleYemegi.Enabled = true;
				btnAperatifEkle.Enabled = true;
			}

			BesinDegeriTopla(brekfast.MealName, secilenTarih);
			BesinDegeriTopla(brunch.MealName, secilenTarih);
			BesinDegeriTopla(dinner.MealName, secilenTarih);
			BesinDegeriTopla(Aperatif.MealName, secilenTarih);
			TotalBesinDegeri(secilenTarih);
		}

		private void btnKahvaltiEkle_Click(object sender, EventArgs e)
		{
			AddBreakfast addBreakfast = new AddBreakfast(_user);
			this.Hide();
			addBreakfast.ShowDialog();
			BesinDegeriTopla(brekfast.MealName, DateTime.Now);
			TotalBesinDegeri(DateTime.Now);
			this.Show();
		}
		private void btnOgleYemegi_Click(object sender, EventArgs e)
		{
			AddLunch addLunch = new AddLunch(_user);
			this.Hide();
			addLunch.ShowDialog();
			BesinDegeriTopla(brunch.MealName, DateTime.Now);
			TotalBesinDegeri(DateTime.Now);
			this.Show();
		}
		private void btnAksamYemegi_Click(object sender, EventArgs e)
		{

			AddDinner addDinner = new AddDinner(_user);
			this.Hide();
			addDinner.ShowDialog();
			BesinDegeriTopla(dinner.MealName, DateTime.Now);
			TotalBesinDegeri(DateTime.Now);
			this.Show();
		}

		private void btnAperatifEkle_Click(object sender, EventArgs e)
		{
			AddSnack addSnack = new AddSnack(_user);
			this.Show();
			addSnack.ShowDialog();
			BesinDegeriTopla(Aperatif.MealName, DateTime.Now);
			TotalBesinDegeri(DateTime.Now);
			this.Show();
		}

		float totFat = 0;
		float totCarb = 0;
		float totProtein = 0;
		float totCal = 0;
		private void TotalBesinDegeri(DateTime secilenTarih)
		{
			totFat = 0;
			totCarb = 0;
			totProtein = 0;
			totCal = 0;
			var tuketilenYemekBesindegerleri = _consumeFoodService.TGetConsumeFoodByValue(secilenTarih);
			foreach (ConsumeFood item in tuketilenYemekBesindegerleri)
			{
				totFat += item.Fat;
				totCarb += item.Carbohydrate;
				totProtein += item.Protein;
				totCal += item.Calories;
			}
			lblTotalKalori.Text = totCal.ToString("0.00");
			lblTotalKarbonhidrat.Text = totCarb.ToString("0.00");
			lblTotalYag.Text = totFat.ToString("0.00");
			lblTotalProtein.Text = totProtein.ToString("0.00");
		}
		private void BesinDegeriTopla(string mealName, DateTime tarih)
		{
			totFat = 0;
			totCarb = 0;
			totProtein = 0;
			totCal = 0;
			var tuketilenYemekBesindegerleri = _consumeFoodService.TGetConsumeFoodByMealID(mealName, tarih);
			foreach (ConsumeFood item in tuketilenYemekBesindegerleri)
			{
				totFat += item.Fat;
				totCarb += item.Carbohydrate;
				totProtein += item.Protein;
				totCal += item.Calories;
			}
			if (mealName == "Sabah")
			{
				lblBreakfastCalory.Text = totCal.ToString("0.00");
				lblBreakfastCarb.Text = totCarb.ToString("0.00");
				lblBreakfastFat.Text = totFat.ToString("0.00");
				lblBreakfastProtein.Text = totProtein.ToString("0.00");
			}
			if (mealName == "Öğle")
			{
				lblOgleCalory.Text = totCal.ToString("0.00");
				lblOgleCarb.Text = totCarb.ToString("0.00");
				lblOgleFat.Text = totFat.ToString("0.00");
				lblOgleProtein.Text = totProtein.ToString("0.00");
			}
			if (mealName == "Akşam")
			{
				lblAksamCalory.Text = totCal.ToString("0.00");
				lblAksamCarb.Text = totCarb.ToString("0.00");
				lblAksamFat.Text = totFat.ToString("0.00");
				lblAksamProtein.Text = totProtein.ToString("0.00");
			}
			if (mealName == "Aperatif")
			{
				lblAperatifCalory.Text = totCal.ToString("0.00");
				lblAperatifCarb.Text = totCarb.ToString("0.00");
				lblAperatifFat.Text = totFat.ToString("0.00");
				lblAperatifProtein.Text = totProtein.ToString("0.00");
			}
		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
