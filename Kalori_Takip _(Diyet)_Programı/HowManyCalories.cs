using iTextSharp.text.pdf.qrcode;
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
	public partial class HowManyCalories : Form
	{
		private readonly FoodService _foodService;
		public HowManyCalories()
		{

			InitializeComponent();
			_foodService = new FoodService();
		}
		float girilenMiktar = 0;
		float oran = 0;
		float hesaplananKalori = 0;
		float hesaplananKarbonhidrat = 0;
		float hesaplananYag = 0;
		float hesaplananProtein = 0;
		private Food secilenUrun;
		private void HowManyCalories_Load(object sender, EventArgs e)
		{

		}

		private void txtAra_TextChanged(object sender, EventArgs e)
		{
			string arananKelime = txtAra.Text.ToLower();
			KisileriDoldur(_foodService.TGetAll(), arananKelime);
		}
		private void KisileriDoldur(List<Food> foods, string arananKelime = "")
		{
			lstFoods.Items.Clear();

			foreach (Food food in foods)
			{
				if (arananKelime == "" || food.FoodName.ToLower().Contains(arananKelime))
				{
					ListViewItem item = new ListViewItem(food.FoodID.ToString());
					item.SubItems.Add(food.FoodName);
					item.Tag = food;
					lstFoods.Items.Add(item);
				}
			}
		}

		private void txtMiktar_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnİncele_Click(object sender, EventArgs e)
		{
			bool sonuc = float.TryParse(txtMiktar.Text, out girilenMiktar);
			if (txtMiktar.Text.Trim() == string.Empty || lstFoods.SelectedItems.Count == 0 || sonuc == false)
			{
				MessageBox.Show("Lütfen eklemek istediğiniz ürünü seçin ve tükettiğiniz miktarı sayısal olarak belirtin");
			}
			else
			{
				secilenUrun = (Food)lstFoods.SelectedItems[0].Tag;
				secilenUrun = _foodService.CalculateFoodInfo(secilenUrun.FoodID, girilenMiktar);

				label13.Text = secilenUrun.Carbohydrate.ToString("0.00");
				lblProtein.Text = secilenUrun.Protein.ToString("0.00");
				lblKalori.Text = secilenUrun.Calories.ToString("0.00");
				lblYag.Text = secilenUrun.Fat.ToString("0.00");
			}
		}
	}
}
