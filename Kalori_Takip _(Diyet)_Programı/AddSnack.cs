using Kalori_Takip___Diyet__Programı.Extensions;
using KaloriTakipProgramı.Business.Concrete;
using KaloriTakipProgramı.Data.Context;
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
	public partial class AddSnack : Form
	{
		private AppDbContext _db;
		private MealService _mealService;
		private AppUser _user;
		private ConsumeFood _consumeFood;
		private Food secilenUrun;
		private int secilenUrunID = 0;



		public AddSnack(AppUser user)
		{
			InitializeComponent();
			_db = new AppDbContext();
			_mealService = new MealService();
			_user = user;
			_consumeFood = new ConsumeFood();
		}

		private void txtUrunAra_TextChanged(object sender, EventArgs e)
		{
			lstUrunler.Items.Clear();
			string arananUrun = txtUrunAra.Text;

			var Urunler = _db.Foods.Where(x => x.FoodName.Contains(arananUrun)).ToList();

			foreach (Food item in Urunler)
			{
				string[] arr = { item.FoodID.ToString(), item.FoodName };
				ListViewItem lvi = new ListViewItem(arr);
				lstUrunler.Items.Add(lvi);
			}
		}


		private void btnEkle_Click(object sender, EventArgs e)
		{
			bool sonuc = float.TryParse(txtMiktar.Text, out girilenMiktar);
			if (txtMiktar.Text.Trim() == string.Empty || lstUrunler.SelectedItems.Count == 0 || sonuc == false)
			{
				MessageBox.Show("Lütfen eklemek istediğiniz ürünü seçin ve tükettiğiniz miktarı sayısal olarak belirtin");
			}
			else
			{
				secilenUrunID = Convert.ToInt32(lstUrunler.SelectedItems[0].Text);
				UrunBilgisiHesapla(secilenUrunID);
				string[] arr = { secilenUrunID.ToString(),
					_db.Foods.First(x => x.FoodID == secilenUrunID).FoodName,
					txtMiktar.Text,
					hesaplananKalori.ToString("0.00"),
					hesaplananKarbonhidrat.ToString("0.00"),
					hesaplananProtein.ToString("0.00"),
					hesaplananYag.ToString("0.00") };
				ListViewItem lvi = new ListViewItem(arr);
				lstEklenenUrunler.Items.Add(lvi);
			}
		}
		float oran = 0;
		float hesaplananKalori = 0;
		float hesaplananKarbonhidrat = 0;
		float hesaplananYag = 0;
		float hesaplananProtein = 0;
		float girilenMiktar = 0;
		private void UrunBilgisiHesapla(int secilenUrunID)
		{

			secilenUrun = _db.Foods.First(x => x.FoodID == secilenUrunID);
			girilenMiktar = Convert.ToSingle(txtMiktar.Text);
			oran = girilenMiktar / (secilenUrun.GramCompensation);
			hesaplananKalori = secilenUrun.Calories * oran;
			hesaplananKarbonhidrat = secilenUrun.Carbohydrate * oran;
			hesaplananYag = secilenUrun.Fat * oran;
			hesaplananProtein = secilenUrun.Protein * oran;

		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			var result = _mealService.TGetByMealIDSnack();
			if (lstEklenenUrunler.Items.Count == 0)
			{
				MessageBox.Show("Lütfen kaydetmek istediğiniz ürünü/ürünleri bu listeye ekleyin");
			}
			else
			{
				foreach (ListViewItem item in lstEklenenUrunler.Items)
				{
					ConsumeFood consumeFood = new ConsumeFood()
					{

						GramCompensation = Convert.ToSingle(item.SubItems[2].Text),
						Calories = Convert.ToSingle(item.SubItems[3].Text),
						Protein = Convert.ToSingle(item.SubItems[4].Text),
						Fat = Convert.ToSingle(item.SubItems[5].Text),
						Carbohydrate = Convert.ToSingle(item.SubItems[6].Text),
						CreatedDate = DateTime.Now,
						ImagePath = imageName,
						AppUserID = _user.AppUserID,
						MealID = result.MealID,
						Foods = new List<Food>() { secilenUrun },
						ConsumeFoodName = item.SubItems[1].Text,
					};
					_db.ConsumeFoods.Add(consumeFood);
					_db.SaveChanges();
				}

				MessageBox.Show("Başarılı bir şekilde kaydedildi");
				Helper.Temizle(grpAraOguniEkle.Controls);
			}

		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (lstEklenenUrunler.SelectedItems.Count > 0)
			{
				lstEklenenUrunler.Items.Remove(lstEklenenUrunler.SelectedItems[0]);
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
				string saveLocation = Path.Combine(Application.StartupPath, "FoodImage", imageName);
				File.Copy(selectedImagePath, saveLocation);
				_consumeFood.ImagePath = imageName;
			}

			Image ımage = LoadImages.LoadFoodImage(_consumeFood.ImagePath);
			pbxYemekResmi.Image = ımage;
		}

		private void grpAraOguniEkle_Enter(object sender, EventArgs e)
		{

		}
	}
}
