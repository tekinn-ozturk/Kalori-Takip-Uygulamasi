using KaloriTakipProgramı.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Data.Extensions
{
	public static class ModelBuilderExtensions
	{
		public static void SeedData(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AppRole>().HasData(new AppRole() { RoleID = 1, RoleName = "Admin" });
			modelBuilder.Entity<AppRole>().HasData(new AppRole() { RoleID = 2, RoleName = "Member" });


			modelBuilder.Entity<Meal>().HasData(new Meal() { MealID = 1, MealName = "Sabah" });
			modelBuilder.Entity<Meal>().HasData(new Meal() { MealID = 2, MealName = "Öğle" });
			modelBuilder.Entity<Meal>().HasData(new Meal() { MealID = 3, MealName = "Akşam" });
			modelBuilder.Entity<Meal>().HasData(new Meal() { MealID = 4, MealName = "Aperatif" });

			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 1, CategoryName = "Balık ve Deniz Ürünleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 2, CategoryName = "Beyaz Et Ürünleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 3, CategoryName = "Meyveler" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 4, CategoryName = "Sütlü Tatlılar" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 5, CategoryName = "Şerbetli Tatlılar" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 6, CategoryName = "Süt Ürünleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 7, CategoryName = "Kahvaltılık Sıcak Ürünler" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 8, CategoryName = "Şarküteri Ürünleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 9, CategoryName = "Kahvaltılık Ürünleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 10, CategoryName = "Makarna Ürünleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 11, CategoryName = "Sos Ürünleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 12, CategoryName = "Fast-Food Ürünleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 13, CategoryName = "Kırmızı Et Ürünleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 14, CategoryName = "Sebze Ürünleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 15, CategoryName = "Sebze Yemekleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 16, CategoryName = "Salata Çeşitleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 17, CategoryName = "Kuruyemiş Çeşitleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 18, CategoryName = "Atıştırmalık Çeşitleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 19, CategoryName = "Alkolsüz İçecek Çeşitleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 20, CategoryName = "Ev Yemekleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 21, CategoryName = "Ekmek ve Tahıllar" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 22, CategoryName = "Hamur İşleri" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 23, CategoryName = "Kurubaklagiller" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 24, CategoryName = "Hayvansal Yağlar" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 25, CategoryName = "Bitkisel Yağlar" });
			modelBuilder.Entity<Category>().HasData(new Category() { CategoryID = 26, CategoryName = "Alkollü İçecekler" });

			//Balık Ürünleri

			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 1, FoodName = "Somon", GramCompensation = 1f, Calories = 2.08f, Carbohydrate = 0f, Protein = 0.19f, Fat = 0.13f, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 2, FoodName = "Ahtapot", GramCompensation = 1f, Calories = 0.73F, Carbohydrate = 0.01F, Protein = 0.15F, Fat = 0.08F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 3, FoodName = "Alabalık", GramCompensation = 1f, Calories = 1.01F, Carbohydrate = 0.01F, Protein = 0.19F, Fat = 0.02F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 4, FoodName = "Barbun", GramCompensation = 1f, Calories = 1.2F, Carbohydrate = 0.01F, Protein = 0.16F, Fat = 0.06F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 5, FoodName = "Çipura", GramCompensation = 1F, Calories = 1.2F, Carbohydrate = 0.01F, Protein = 0.16F, Fat = 0.06F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 6, FoodName = "Dil Balığı", GramCompensation = 1F, Calories = 0.79F, Carbohydrate = 0.01F, Protein = 0.19F, Fat = 0F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 7, FoodName = "Izgara Hamsi", GramCompensation = 1F, Calories = 2F, Carbohydrate = 0.05F, Protein = 0.19F, Fat = 0.1F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 8, FoodName = "Kızartma Hamsi", GramCompensation = 1F, Calories = 1.15F, Carbohydrate = 0.05F, Protein = 0.17F, Fat = 0.1F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 9, FoodName = "Havyar", GramCompensation = 1F, Calories = 2.62F, Carbohydrate = 0.03F, Protein = 0.26F, Fat = 0.15F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 10, FoodName = "Istakoz", GramCompensation = 1F, Calories = 0.91F, Carbohydrate = 0, Protein = 0.17F, Fat = 0.02F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 11, FoodName = "İstavrit", GramCompensation = 1F, Calories = 0.81F, Carbohydrate = 0, Protein = 0.17F, Fat = 0.02F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 12, FoodName = "İstiridye", GramCompensation = 1F, Calories = 0.68F, Carbohydrate = 0, Protein = 0.09F, Fat = 0.02F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 13, FoodName = "İzmarit", GramCompensation = 1F, Calories = 1.53F, Carbohydrate = 0, Protein = 0.23F, Fat = 0.06F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 14, FoodName = "Kalkan Balığı", GramCompensation = 1F, Calories = 1.35F, Carbohydrate = 0, Protein = 0.20F, Fat = 0.06F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 15, FoodName = "Karides Güveç", GramCompensation = 1F, Calories = 1.25F, Carbohydrate = 0.02F, Protein = 0.16F, Fat = 0.06F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 16, FoodName = "Tereyağda Karides", GramCompensation = 1F, Calories = 3.19F, Carbohydrate = 0.02F, Protein = 0.16F, Fat = 0.29F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 17, FoodName = "Kefal Balığı", GramCompensation = 1F, Calories = 1.73F, Carbohydrate = 0F, Protein = 0.19F, Fat = 0, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 18, FoodName = "Kılıç Balığı", GramCompensation = 1F, Calories = 1.53F, Carbohydrate = 0F, Protein = 0.23F, Fat = 0.06F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 19, FoodName = "Lüfer", GramCompensation = 1F, Calories = 1.37F, Carbohydrate = 0F, Protein = 0.16F, Fat = 0.09F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 20, FoodName = "Mezgit", GramCompensation = 1F, Calories = 0.82F, Carbohydrate = 0F, Protein = 0.18F, Fat = 0.06F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 21, FoodName = "Midye Dolma", GramCompensation = 1F, Calories = 1F, Carbohydrate = 1.03F, Protein = 0.05F, Fat = 0.02F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 22, FoodName = "Midye Tava", GramCompensation = 1F, Calories = 2F, Carbohydrate = 0.08F, Protein = 0.09F, Fat = 0.10F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 23, FoodName = "Palamut", GramCompensation = 1F, Calories = 1.51F, Carbohydrate = 0.08F, Protein = 0.19F, Fat = 0.07F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 24, FoodName = "Sardalya", GramCompensation = 1F, Calories = 1.60F, Carbohydrate = 0.08F, Protein = 0.15F, Fat = 0.09F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 25, FoodName = "Sazan", GramCompensation = 1F, Calories = 1.45F, Carbohydrate = 0F, Protein = 0.19F, Fat = 0.07F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 26, FoodName = "Tekir", GramCompensation = 1F, Calories = 1.51F, Carbohydrate = 0F, Protein = 0.25F, Fat = 0.04F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 27, FoodName = "Ton Balığı", GramCompensation = 1F, Calories = 2.90F, Carbohydrate = 0F, Protein = 0.25F, Fat = 0.04F, CategoryID = 1 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 28, FoodName = "Suşi", GramCompensation = 1F, Calories = 0.90f, Carbohydrate = 0.08F, Protein = 0.2F, Fat = 0.04F, CategoryID = 1 });


			//Beyaz Et Ürünleri
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 29, FoodName = "Haşlanmış Tavuk Göğsü", GramCompensation = 1F, Calories = 1.97F, Carbohydrate = 0F, Protein = 0.30F, Fat = 0.08F, CategoryID = 2 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 30, FoodName = "Pişmiş Tavuk Eti", GramCompensation = 1F, Calories = 2.20F, Carbohydrate = 0.02F, Protein = 0.25F, Fat = 0.12F, CategoryID = 2 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 31, FoodName = "Kızarmış Tavuk Kanadı", GramCompensation = 1F, Calories = 1.91f, Carbohydrate = 0.01F, Protein = 0.18F, Fat = 0.13f, CategoryID = 2 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 32, FoodName = "Kızarmış Tavuk But", GramCompensation = 1F, Calories = 3f, Carbohydrate = 0.01F, Protein = 0.18F, Fat = 0.27f, CategoryID = 2 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 33, FoodName = "Haşlanmış Tavuk But", GramCompensation = 1f, Calories = 1.46f, Carbohydrate = 0.05f, Protein = 0.10f, Fat = 0.09f, CategoryID = 2 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 34, FoodName = "Tavuk Köftesi", GramCompensation = 1f, Calories = 1.53f, Carbohydrate = 0.07f, Protein = 0.13f, Fat = 0.07f, CategoryID = 2 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 35, FoodName = "Tavuk Ciğeri", GramCompensation = 1f, Calories = 1.72F, Carbohydrate = 0.01F, Protein = 0.26F, Fat = 0.06F, CategoryID = 2 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 36, FoodName = "Tavuklu Pilav", GramCompensation = 1f, Calories = 1.52F, Carbohydrate = 0.25F, Protein = 0.08F, Fat = 0.04F, CategoryID = 2 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 37, FoodName = "Tavuk Nugget", GramCompensation = 1f, Calories = 2.68F, Carbohydrate = 0.06F, Protein = 0.16F, Fat = 0.2F, CategoryID = 2 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 38, FoodName = "Ekmek Arası Tavuk Döner", GramCompensation = 1f, Calories = 3.09F, Carbohydrate = 0.1513F, Protein = 0.431F, Fat = 0.3637F, CategoryID = 2 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 39, FoodName = "Köri Soslu Tavuk", GramCompensation = 1f, Calories = 1.43F, Carbohydrate = 0.0525F, Protein = 0.1885F, Fat = 0.0465F, CategoryID = 2 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 40, FoodName = "Tavuk Sote", GramCompensation = 1f, Calories = 1.236F, Carbohydrate = 0.06052F, Protein = 0.1724F, Fat = 0.14548F, CategoryID = 2 });

			//Meyveler
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 41, FoodName = "Elma", GramCompensation = 1f, Calories = 0.5278F, Carbohydrate = 0.1396F, Protein = 0.0026F, Fat = 0.0017F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 42, FoodName = "Portakal", GramCompensation = 1f, Calories = 0.4769F, Carbohydrate = 0.1185F, Protein = 0.0096F, Fat = 0.0012F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 43, FoodName = "Greyfurt", GramCompensation = 1f, Calories = 0.302F, Carbohydrate = 0.075F, Protein = 0.0055F, Fat = 0.001F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 44, FoodName = "Mandalina", GramCompensation = 1f, Calories = 0.5333F, Carbohydrate = 0.1367F, Protein = 0.008F, Fat = 0.0033F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 45, FoodName = "Kivi", GramCompensation = 1f, Calories = 0.6087F, Carbohydrate = 0.1464F, Protein = 0.0089F, Fat = 0.0036F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 46, FoodName = "Muz", GramCompensation = 1f, Calories = 0.8898F, Carbohydrate = 0.2297F, Protein = 0.011F, Fat = 0.004F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 47, FoodName = "Kayısı", GramCompensation = 1f, Calories = 0.4857F, Carbohydrate = 0.1114F, Protein = 0.0143F, Fat = 0.0043F, CategoryID = 3 });

			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 48, FoodName = "Çilek", GramCompensation = 1f, Calories = 0.3194F, Carbohydrate = 0.0764F, Protein = 0.0066F, Fat = 0.0031F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 49, FoodName = "Trabzon Hurması", GramCompensation = 1f, Calories = 0.75F, Carbohydrate = 0.2F, Protein = 0.00625F, Fat = 0.00208F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 50, FoodName = "Kiraz", GramCompensation = 1f, Calories = 0.6304F, Carbohydrate = 0.1594F, Protein = 0.0105F, Fat = 0.0022F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 51, FoodName = "Vişne", GramCompensation = 1f, Calories = 0.208F, Carbohydrate = 0.052F, Protein = 0.00412F, Fat = 0.0012F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 52, FoodName = "Kavun", GramCompensation = 1f, Calories = 0.36F, Carbohydrate = 0.087F, Protein = 0.00225F, Fat = 0.002F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 53, FoodName = "Karpuz", GramCompensation = 1f, Calories = 0.3067F, Carbohydrate = 0.10087F, Protein = 0.00933F, Fat = 0.007F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 54, FoodName = "Ananas", GramCompensation = 1f, Calories = 0.5F, Carbohydrate = 0.1312F, Protein = 0.00125F, Fat = 0.000291F, CategoryID = 3 });

			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 55, FoodName = "Avakado", GramCompensation = 1f, Calories = 1.6F, Carbohydrate = 0.085F, Protein = 0.02F, Fat = 0.147F, CategoryID = 3 });

			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 56, FoodName = "Mango", GramCompensation = 1f, Calories = 1.0F, Carbohydrate = 0.247F, Protein = 0.0135F, Fat = 0.0063F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 57, FoodName = "Ahududu", GramCompensation = 1f, Calories = 0.512F, Carbohydrate = 0.117F, Protein = 0.012F, Fat = 0.0063F, CategoryID = 3 });


			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 58, FoodName = "Böğürtlen", GramCompensation = 1f, Calories = 0.62F, Carbohydrate = 0.138F, Protein = 0.015F, Fat = 0.008F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 59, FoodName = "Yeşil Erik", GramCompensation = 1f, Calories = 0.46F, Carbohydrate = 0.114f, Protein = 0.006F, Fat = 0.003F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 60, FoodName = "İncir", GramCompensation = 1f, Calories = 0.74F, Carbohydrate = 0.187f, Protein = 0.008F, Fat = 0.003F, CategoryID = 3 });
			modelBuilder.Entity<Food>().HasData(new Food() { FoodID = 61, FoodName = "Şeftali", GramCompensation = 1f, Calories = 0.39F, Carbohydrate = 0.09f, Protein = 0.01F, Fat = 0.003F, CategoryID = 3 });

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 62,
				FoodName = "Üzüm",
				GramCompensation = 1f,
				Calories = 0.69F,
				Carbohydrate = 0.176f,
				Protein = 0.0076F,
				Fat = 0.0006F,
				CategoryID = 3
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 63,
				FoodName = "Nar",
				GramCompensation = 1f,
				Calories = 0.83F,
				Carbohydrate = 0.18f,
				Protein = 0.02F,
				Fat = 0.01F,
				CategoryID = 3
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 64,
				FoodName = "Limon",
				GramCompensation = 1f,
				Calories = 29F,
				Carbohydrate = 9.32f,
				Protein = 1.1F,
				Fat = 0.3F,
				CategoryID = 3
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 65,
				FoodName = "Limon",
				GramCompensation = 1f,
				Calories = 0.3F,
				Carbohydrate = 0.092f,
				Protein = 0.01F,
				Fat = 0.003F,
				CategoryID = 3
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 66,
				FoodName = "Kırmızı Erik",
				GramCompensation = 1f,
				Calories = 0.46F,
				Carbohydrate = 0.117f,
				Protein = 0.0075F,
				Fat = 0.0015F,
				CategoryID = 3
			});


			//Sütlü Tatlılar
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 67,
				FoodName = "Sütlaç",
				GramCompensation = 1f,
				Calories = 1F,
				Carbohydrate = 0.2f,
				Protein = 0.03F,
				Fat = 0.02F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 68,
				FoodName = "Kazandibi",
				GramCompensation = 1f,
				Calories = 3.5F,
				Carbohydrate = 0.8f,
				Protein = 0.05F,
				Fat = 0.02F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 69,
				FoodName = "Magnolia",
				GramCompensation = 1f,
				Calories = 3.5F,
				Carbohydrate = 0.5f,
				Protein = 0.1F,
				Fat = 0.1F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 70,
				FoodName = "Tiramisu",
				GramCompensation = 1f,
				Calories = 2.5F,
				Carbohydrate = 0.33f,
				Protein = 0.05F,
				Fat = 0.1F,
				CategoryID = 4
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 71,
				FoodName = "Cheesecake",
				GramCompensation = 1f,
				Calories = 3.5F,
				Carbohydrate = 0.3f,
				Protein = 0.1F,
				Fat = 0.16F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 72,
				FoodName = "Güllaç",
				GramCompensation = 1f,
				Calories = 1F,
				Carbohydrate = 0.2f,
				Protein = 0.03F,
				Fat = 0.04F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 73,
				FoodName = "Tavuk Göğsü Tatlısı",
				GramCompensation = 1f,
				Calories = 1F,
				Carbohydrate = 0.15f,
				Protein = 0.03F,
				Fat = 0.01F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 74,
				FoodName = "Muhallebi",
				GramCompensation = 1f,
				Calories = 2F,
				Carbohydrate = 0.25f,
				Protein = 0.03F,
				Fat = 0.03F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 75,
				FoodName = "Puding",
				GramCompensation = 1f,
				Calories = 1F,
				Carbohydrate = 0.06f,
				Protein = 0.04F,
				Fat = 0.02F,
				CategoryID = 4
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 76,
				FoodName = "Supangle",
				GramCompensation = 1f,
				Calories = 1.5F,
				Carbohydrate = 0.15f,
				Protein = 0.03F,
				Fat = 0.05F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 77,
				FoodName = "Trileçe",
				GramCompensation = 185f,
				Calories = 301F,
				Carbohydrate = 39F,
				Protein = 12.85F,
				Fat = 9.25F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 78,
				FoodName = "Höşmerim",
				GramCompensation = 120f,
				Calories = 343F,
				Carbohydrate = 111F,
				Protein = 17F,
				Fat = 10.8F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 79,
				FoodName = "Keşkül",
				GramCompensation = 250f,
				Calories = 273F,
				Carbohydrate = 42.55F,
				Protein = 7.3F,
				Fat = 7.7F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 80,
				FoodName = "Aşure",
				GramCompensation = 250f,
				Calories = 344F,
				Carbohydrate = 61.21F,
				Protein = 7.84F,
				Fat = 5.5F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 81,
				FoodName = "Profiterol",
				GramCompensation = 180f,
				Calories = 429F,
				Carbohydrate = 55.8F,
				Protein = 5.8F,
				Fat = 19.3F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 82,
				FoodName = "Meyveli Dondurma",
				GramCompensation = 75f,
				Calories = 99F,
				Carbohydrate = 21.05F,
				Protein = 0.97F,
				Fat = 1.02F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 83,
				FoodName = "Sütlü Dondurma",
				GramCompensation = 150f,
				Calories = 240F,
				Carbohydrate = 30.75F,
				Protein = 9F,
				Fat = 9F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 84,
				FoodName = "Çikolatalı Dondurma",
				GramCompensation = 150f,
				Calories = 216F,
				Carbohydrate = 28.2F,
				Protein = 3.8F,
				Fat = 11F,
				CategoryID = 4
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 85,
				FoodName = "Sütlü İrmik Tatlısı",
				GramCompensation = 170f,
				Calories = 262F,
				Carbohydrate = 43.15F,
				Protein = 7F,
				Fat = 5F,
				CategoryID = 4
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 86,
				FoodName = "İrmik Helvası",
				GramCompensation = 100f,
				Calories = 532F,
				Carbohydrate = 64.9F,
				Protein = 7.77F,
				Fat = 25.20F,
				CategoryID = 4
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 87,
				FoodName = "Un Helvası",
				GramCompensation = 90f,
				Calories = 294F,
				Carbohydrate = 43.5F,
				Protein = 0.12F,
				Fat = 12.18F,
				CategoryID = 4
			});


			//Şerbetli Tatlılar

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 88,
				FoodName = "Baklava",
				GramCompensation = 90f,
				Calories = 660F,
				Carbohydrate = 79F,
				Protein = 12.36F,
				Fat = 34.35F,
				CategoryID = 5
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 89,
				FoodName = "Kadayıf",
				GramCompensation = 145f,
				Calories = 422F,
				Carbohydrate = 51.75F,
				Protein = 6.85F,
				Fat = 22.55F,
				CategoryID = 5
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 90,
				FoodName = "Soğuk Baklava",
				GramCompensation = 82f,
				Calories = 242F,
				Carbohydrate = 34.45F,
				Protein = 3.3F,
				Fat = 7.25F,
				CategoryID = 5
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 91,
				FoodName = "Tulumba",
				GramCompensation = 90f,
				Calories = 256F,
				Carbohydrate = 40.7F,
				Protein = 2.51F,
				Fat = 14.75F,
				CategoryID = 5
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 92,
				FoodName = "Kemalpaşa",
				GramCompensation = 285f,
				Calories = 476F,
				Carbohydrate = 84.4F,
				Protein = 16.6F,
				Fat = 13.55F,
				CategoryID = 5
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 93,
				FoodName = "Halka Tatlısı",
				GramCompensation = 673F,
				Calories = 476F,
				Carbohydrate = 66.75F,
				Protein = 5F,
				Fat = 40.6F,
				CategoryID = 5
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 94,
				FoodName = "Şam Tatlısı",
				GramCompensation = 90f,
				Calories = 330F,
				Carbohydrate = 150.75F,
				Protein = 5F,
				Fat = 0.94F,
				CategoryID = 5
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 95,
				FoodName = "Şöbiyet",
				GramCompensation = 160f,
				Calories = 522F,
				Carbohydrate = 59.76F,
				Protein = 5.95F,
				Fat = 29.15F,
				CategoryID = 5
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 96,
				FoodName = "Künefe",
				GramCompensation = 120f,
				Calories = 426F,
				Carbohydrate = 55F,
				Protein = 7.36F,
				Fat = 20.52F,
				CategoryID = 5
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 97,
				FoodName = "Şekerpare",
				GramCompensation = 100f,
				Calories = 272F,
				Carbohydrate = 45.95F,
				Protein = 2.65F,
				Fat = 8.95F,
				CategoryID = 5
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 98,
				FoodName = "Revani",
				GramCompensation = 100f,
				Calories = 348F,
				Carbohydrate = 55F,
				Protein = 5.82F,
				Fat = 9.4F,
				CategoryID = 5
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 99,
				FoodName = "Lokma Tatlısı",
				GramCompensation = 15f,
				Calories = 78F,
				Carbohydrate = 7.52F,
				Protein = 0.35F,
				Fat = 4.82F,
				CategoryID = 5
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 100,
				FoodName = "Kalburabastı",
				GramCompensation = 85f,
				Calories = 251F,
				Carbohydrate = 34.38F,
				Protein = 4F,
				Fat = 11.33F,
				CategoryID = 5
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 101,
				FoodName = "Fıstıklı Sarma Tatlısı",
				GramCompensation = 50f,
				Calories = 210F,
				Carbohydrate = 20.95F,
				Protein = 3.71F,
				Fat = 12.08F,
				CategoryID = 5
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 102,
				FoodName = "Un Helvası",
				GramCompensation = 30f,
				Calories = 99F,
				Carbohydrate = 12.63F,
				Protein = 0.48F,
				Fat = 4.81F,
				CategoryID = 5
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 103,
				FoodName = "San Sebastian",
				GramCompensation = 150f,
				Calories = 480F,
				Carbohydrate = 37.05F,
				Protein = 7.8F,
				Fat = 33.3F,
				CategoryID = 5
			});


			//Süt Ürünleri

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 104,
				FoodName = "Tam Yağlı İnek Sütü",
				GramCompensation = 1f,
				Calories = 0.58F,
				Carbohydrate = 0.06F,
				Protein = 0.03F,
				Fat = 0.03F,
				CategoryID = 6
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 105,
				FoodName = "Yarım Yağlı İnek Sütü",
				GramCompensation = 1f,
				Calories = 0.39F,
				Carbohydrate = 0.08F,
				Protein = 0.04F,
				Fat = 0.015F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 106,
				FoodName = "Keçi Sütü",
				GramCompensation = 1f,
				Calories = 0.65F,
				Carbohydrate = 0.18F,
				Protein = 0.09F,
				Fat = 0.015F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 107,
				FoodName = "Badem Sütü",
				GramCompensation = 1f,
				Calories = 0.38F,
				Carbohydrate = 0.18F,
				Protein = 0.04F,
				Fat = 0.01F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 108,
				FoodName = "Beyaz Peynir",
				GramCompensation = 30f,
				Calories = 93F,
				Carbohydrate = 0.76F,
				Protein = 6.11F,
				Fat = 7.30F,
				CategoryID = 6
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 109,
				FoodName = "Süzme Peynir",
				GramCompensation = 30f,
				Calories = 72F,
				Carbohydrate = 1.14F,
				Protein = 3.4F,
				Fat = 6F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 110,
				FoodName = "Lor Peyniri",
				GramCompensation = 15f,
				Calories = 30F,
				Carbohydrate = 0.14F,
				Protein = 2.17F,
				Fat = 2.34F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 111,
				FoodName = "Kaşar Peyniri",
				GramCompensation = 20f,
				Calories = 71F,
				Carbohydrate = 0.51F,
				Protein = 5.4F,
				Fat = 5.32F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 112,
				FoodName = "Labne",
				GramCompensation = 5f,
				Calories = 10F,
				Carbohydrate = 0.28F,
				Protein = 0.25F,
				Fat = 0.9F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 113,
				FoodName = "Örgü Peynir",
				GramCompensation = 25f,
				Calories = 72F,
				Carbohydrate = 0.38F,
				Protein = 6.25F,
				Fat = 5F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 114,
				FoodName = "Dil Peyniri",
				GramCompensation = 25f,
				Calories = 68F,
				Carbohydrate = 1.58F,
				Protein = 4.3F,
				Fat = 4.93F,
				CategoryID = 6
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 115,
				FoodName = "Hellim Peyniri",
				GramCompensation = 25f,
				Calories = 90F,
				Carbohydrate = 0.26F,
				Protein = 6.98F,
				Fat = 7.38F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 116,
				FoodName = "Beyaz Peynir",
				GramCompensation = 30f,
				Calories = 90F,
				Carbohydrate = 0.66F,
				Protein = 6.61F,
				Fat = 6.71F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 117,
				FoodName = "Kefir",
				GramCompensation = 30f,
				Calories = 120F,
				Carbohydrate = 10F,
				Protein = 5.6F,
				Fat = 6F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 118,
				FoodName = "Yoğurt",
				GramCompensation = 200f,
				Calories = 122F,
				Carbohydrate = 9.32F,
				Protein = 6.94F,
				Fat = 6.5F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 119,
				FoodName = "Ayran",
				GramCompensation = 200f,
				Calories = 76F,
				Carbohydrate = 5.6F,
				Protein = 4F,
				Fat = 4F,
				CategoryID = 6
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 120,
				FoodName = "Cacık",
				GramCompensation = 200f,
				Calories = 115F,
				Carbohydrate = 11F,
				Protein = 6.66F,
				Fat = 4.85F,
				CategoryID = 6
			});

			//Kahvaltılık Sıcaklar;
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 121,
				FoodName = "Haşlanmış Yumurta",
				GramCompensation = 50f,
				Calories = 78F,
				Carbohydrate = 0.56F,
				Protein = 6.3F,
				Fat = 5.31F,
				CategoryID = 7
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 122,
				FoodName = "Omlet",
				GramCompensation = 55f,
				Calories = 101F,
				Carbohydrate = 1.27F,
				Protein = 6.7F,
				Fat = 7.94F,
				CategoryID = 7
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 123,
				FoodName = "Peynirli Omlet",
				GramCompensation = 130f,
				Calories = 254F,
				Carbohydrate = 2.05F,
				Protein = 15.3F,
				Fat = 15F,
				CategoryID = 7
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 124,
				FoodName = "Menemen",
				GramCompensation = 150f,
				Calories = 205F,
				Carbohydrate = 3.7F,
				Protein = 12.45F,
				Fat = 10F,
				CategoryID = 7
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 125,
				FoodName = "Sucuklu Yumurta",
				GramCompensation = 100f,
				Calories = 242F,
				Carbohydrate = 3.4F,
				Protein = 13.5F,
				Fat = 19.5F,
				CategoryID = 7
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 126,
				FoodName = "Kuymak - Mıhlama",
				GramCompensation = 120f,
				Calories = 489F,
				Carbohydrate = 3.95F,
				Protein = 19.1F,
				Fat = 44.4F,
				CategoryID = 7
			});



			//Şarküteri;

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 127,
				FoodName = "Sucuk",
				GramCompensation = 50f,
				Calories = 166F,
				Carbohydrate = 2.57F,
				Protein = 7.1F,
				Fat = 14.2F,
				CategoryID = 8
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 128,
				FoodName = "Sosis",
				GramCompensation = 40f,
				Calories = 60F,
				Carbohydrate = 0.12F,
				Protein = 2.24F,
				Fat = 5.6F,
				CategoryID = 8
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 129,
				FoodName = "Dana Salam",
				GramCompensation = 15f,
				Calories = 45F,
				Carbohydrate = 0.64F,
				Protein = 1.65F,
				Fat = 3.92F,
				CategoryID = 8
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 130,
				FoodName = "Hindi Salam",
				GramCompensation = 8f,
				Calories = 17F,
				Carbohydrate = 0.24F,
				Protein = 1.31F,
				Fat = 1.13F,
				CategoryID = 8
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 131,
				FoodName = "Dana Jambon",
				GramCompensation = 30f,
				Calories = 32F,
				Carbohydrate = 0.7F,
				Protein = 4.92F,
				Fat = 0F,
				CategoryID = 8
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 132,
				FoodName = "Hindi Jambon",
				GramCompensation = 30f,
				Calories = 15F,
				Carbohydrate = 0.35F,
				Protein = 2.35F,
				Fat = 0.46F,
				CategoryID = 8
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 133,
				FoodName = "Piliç Jambon",
				GramCompensation = 12f,
				Calories = 11F,
				Carbohydrate = 0.12F,
				Protein = 1.56F,
				Fat = 0.44F,
				CategoryID = 8
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 134,
				FoodName = "Hindi Füme",
				GramCompensation = 30f,
				Calories = 51F,
				Carbohydrate = 0F,
				Protein = 8.8F,
				Fat = 1.5F,
				CategoryID = 8
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 135,
				FoodName = "Pilic Füme",
				GramCompensation = 30f,
				Calories = 26F,
				Carbohydrate = 0.3F,
				Protein = 3.9F,
				Fat = 0.9F,
				CategoryID = 8
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 136,
				FoodName = "Pastırma",
				GramCompensation = 30f,
				Calories = 75F,
				Carbohydrate = 0F,
				Protein = 8.85F,
				Fat = 4.17F,
				CategoryID = 8
			});


			//Kahvaltılıklar

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 137,
				FoodName = "Siyah Zeytin",
				GramCompensation = 4f,
				Calories = 5F,
				Carbohydrate = 0.24F,
				Protein = 0.03F,
				Fat = 0.44F,
				CategoryID = 9
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 138,
				FoodName = "Yeşil Zeytin",
				GramCompensation = 4f,
				Calories = 6F,
				Carbohydrate = 0.15F,
				Protein = 0.05F,
				Fat = 0.61F,
				CategoryID = 9
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 139,
				FoodName = "Bal",
				GramCompensation = 10f,
				Calories = 30F,
				Carbohydrate = 8.25F,
				Protein = 0.04F,
				Fat = 0F,
				CategoryID = 9
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 140,
				FoodName = "Kaymak",
				GramCompensation = 5f,
				Calories = 29F,
				Carbohydrate = 0.17F,
				Protein = 0.05F,
				Fat = 3.16F,
				CategoryID = 9
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 141,
				FoodName = "Cevizli Yaz Helvası",
				GramCompensation = 30f,
				Calories = 169F,
				Carbohydrate = 13.55F,
				Protein = 4.41F,
				Fat = 10F,
				CategoryID = 9
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 142,
				FoodName = "Tahin",
				GramCompensation = 15f,
				Calories = 87F,
				Carbohydrate = 3.18F,
				Protein = 2.67F,
				Fat = 7.2F,
				CategoryID = 9
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 143,
				FoodName = "Pekmez",
				GramCompensation = 10f,
				Calories = 29F,
				Carbohydrate = 0F,
				Protein = 0F,
				Fat = 0.01F,
				CategoryID = 9
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 144,
				FoodName = "Tahin Pekmez",
				GramCompensation = 15f,
				Calories = 66F,
				Carbohydrate = 6.45F,
				Protein = 1.52F,
				Fat = 3.48F,
				CategoryID = 9
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 145,
				FoodName = "Nutella",
				GramCompensation = 5f,
				Calories = 27F,
				Carbohydrate = 2.88F,
				Protein = 0.32F,
				Fat = 1.55F,
				CategoryID = 9
			});
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 146,
				FoodName = "Kakaolu Fındık Kreması",
				GramCompensation = 5f,
				Calories = 25F,
				Carbohydrate = 2.71F,
				Protein = 0.44F,
				Fat = 1.38F,
				CategoryID = 9
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 147,
				FoodName = "Fındık Ezmesi",
				GramCompensation = 6f,
				Calories = 34F,
				Carbohydrate = 3.08F,
				Protein = 0.55F,
				Fat = 2.23F,
				CategoryID = 9
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 148,
				FoodName = "Fıstık Ezmesi",
				GramCompensation = 6f,
				Calories = 35F,
				Carbohydrate = 1.3F,
				Protein = 1.44F,
				Fat = 3F,
				CategoryID = 9
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 149,
				FoodName = "Şekersiz Fıstık Ezmesi",
				GramCompensation = 6f,
				Calories = 36F,
				Carbohydrate = 1.1F,
				Protein = 1.32F,
				Fat = 2.76F,
				CategoryID = 9
			});

			//Makarnalar;
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 150,
				FoodName = "Haşlanmış Makarna",
				GramCompensation = 100f,
				Calories = 157F,
				Carbohydrate = 30.59F,
				Protein = 5.8F,
				Fat = 0.93F,
				CategoryID = 10
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 151,
				FoodName = "Domatesli Makarna",
				GramCompensation = 200f,
				Calories = 178F,
				Carbohydrate = 27.43F,
				Protein = 6.55F,
				Fat = 4.48F,
				CategoryID = 10
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 152,
				FoodName = "Spagetti Bolonez",
				GramCompensation = 200f,
				Calories = 303F,
				Carbohydrate = 20.9F,
				Protein = 15.83F,
				Fat = 17F,
				CategoryID = 10
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 153,
				FoodName = "Penne Arabiata",
				GramCompensation = 100f,
				Calories = 164F,
				Carbohydrate = 31.18F,
				Protein = 26.5F,
				Fat = 4.43F,
				CategoryID = 10
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 154,
				FoodName = "Fettucini Alfredo",
				GramCompensation = 100f,
				Calories = 289F,
				Carbohydrate = 50.1F,
				Protein = 10.4F,
				Fat = 3.8F,
				CategoryID = 10
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 155,
				FoodName = "Lazanya",
				GramCompensation = 150f,
				Calories = 272F,
				Carbohydrate = 25F,
				Protein = 12.65F,
				Fat = 13.56F,
				CategoryID = 10
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 156,
				FoodName = "Fırında Makarna",
				GramCompensation = 230f,
				Calories = 382F,
				Carbohydrate = 52.26F,
				Protein = 17.14F,
				Fat = 11.2F,
				CategoryID = 10
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 157,
				FoodName = "Makarna Salatası",
				GramCompensation = 300f,
				Calories = 283F,
				Carbohydrate = 53.75F,
				Protein = 8.52F,
				Fat = 4.04F,
				CategoryID = 10
			});

			// SOSLAR

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 158,
				FoodName = "Ketçap",
				GramCompensation = 20f,
				Calories = 22F,
				Carbohydrate = 4.8f,
				Protein = 0.25F,
				Fat = 0F,
				CategoryID = 11
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 159,
				FoodName = "Mayonez",
				GramCompensation = 13f,
				Calories = 50F,
				Carbohydrate = 3.11f,
				Protein = 0.12F,
				Fat = 4.34F,
				CategoryID = 11
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 160,
				FoodName = "Hardal",
				GramCompensation = 8f,
				Calories = 6F,
				Carbohydrate = 0.58f,
				Protein = 0.37F,
				Fat = 0.33F,
				CategoryID = 11
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 161,
				FoodName = "Barbekü Sos",
				GramCompensation = 20f,
				Calories = 26F,
				Carbohydrate = 6.38f,
				Protein = 0.12F,
				Fat = 0.06F,
				CategoryID = 11
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 162,
				FoodName = "Ranch Sos",
				GramCompensation = 20f,
				Calories = 24F,
				Carbohydrate = 1.79f,
				Protein = 0.46F,
				Fat = 1.7F,
				CategoryID = 11
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 163,
				FoodName = "Buffalo Sos",
				GramCompensation = 20f,
				Calories = 56F,
				Carbohydrate = 1.4f,
				Protein = 0.4F,
				Fat = 5.4F,
				CategoryID = 11
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 164,
				FoodName = "Pesto Sos",
				GramCompensation = 10f,
				Calories = 9F,
				Carbohydrate = 0.54f,
				Protein = 3.47F,
				Fat = 4.86F,
				CategoryID = 11
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 165,
				FoodName = "Nar Ekşisi",
				GramCompensation = 8f,
				Calories = 15F,
				Carbohydrate = 3.7f,
				Protein = 0.05F,
				Fat = 0F,
				CategoryID = 11
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 166,
				FoodName = "Köri Sos",
				GramCompensation = 10f,
				Calories = 22F,
				Carbohydrate = 1.6f,
				Protein = 0.05F,
				Fat = 1.7F,
				CategoryID = 11
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 167,
				FoodName = "Soya Sos",
				GramCompensation = 10f,
				Calories = 6F,
				Carbohydrate = 0.56f,
				Protein = 1.05F,
				Fat = 0F,
				CategoryID = 11
			});

			//FASTFOODLAR
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 168,
				FoodName = "Çıtır Tavuk",
				GramCompensation = 200f,
				Calories = 529F,
				Carbohydrate = 38.05f,
				Protein = 34F,
				Fat = 26.65F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 169,
				FoodName = "Tavuk Burger",
				GramCompensation = 100f,
				Calories = 270F,
				Carbohydrate = 33f,
				Protein = 13F,
				Fat = 10F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 170,
				FoodName = "Cheeseburger",
				GramCompensation = 115f,
				Calories = 290F,
				Carbohydrate = 30.96f,
				Protein = 16.95F,
				Fat = 12F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 171,
				FoodName = "Etli Ekmek",
				GramCompensation = 130f,
				Calories = 277F,
				Carbohydrate = 31.07f,
				Protein = 15.28F,
				Fat = 9.56F,
				CategoryID = 12
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 172,
				FoodName = "Lahmacun",
				GramCompensation = 150f,
				Calories = 221F,
				Carbohydrate = 32.27f,
				Protein = 9.75F,
				Fat = 5.55F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 173,
				FoodName = "Tantuni",
				GramCompensation = 220f,
				Calories = 380F,
				Carbohydrate = 19.05f,
				Protein = 43.6F,
				Fat = 50.34F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 174,
				FoodName = "Karışık Pizza",
				GramCompensation = 241f,
				Calories = 241F,
				Carbohydrate = 40f,
				Protein = 7.8F,
				Fat = 5.63F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 175,
				FoodName = "Sebzeli Pizza",
				GramCompensation = 220f,
				Calories = 266F,
				Carbohydrate = 41.23f,
				Protein = 13.1F,
				Fat = 6.6F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 176,
				FoodName = "Kokoreç Yarım Ekmek",
				GramCompensation = 245f,
				Calories = 433F,
				Carbohydrate = 68.77f,
				Protein = 28.1F,
				Fat = 3.93F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 177,
				FoodName = "Çiğköfte Dürüm",
				GramCompensation = 150f,
				Calories = 361F,
				Carbohydrate = 64.75f,
				Protein = 15.06F,
				Fat = 30.64F,
				CategoryID = 12
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 178,
				FoodName = "Tavuk Döner Dürüm",
				GramCompensation = 250f,
				Calories = 309F,
				Carbohydrate = 15.13f,
				Protein = 43.1F,
				Fat = 36.37F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 179,
				FoodName = "Et Döner Dürüm",
				GramCompensation = 235f,
				Calories = 301F,
				Carbohydrate = 19.7f,
				Protein = 29.65F,
				Fat = 45.6F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 180,
				FoodName = "Kumpir",
				GramCompensation = 640f,
				Calories = 1296F,
				Carbohydrate = 65.74f,
				Protein = 50F,
				Fat = 92.35F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 181,
				FoodName = "Adana Dürüm",
				GramCompensation = 200f,
				Calories = 325F,
				Carbohydrate = 15.02f,
				Protein = 27.80F,
				Fat = 45.5F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 182,
				FoodName = "Urfa Dürüm",
				GramCompensation = 200f,
				Calories = 325F,
				Carbohydrate = 15.02f,
				Protein = 27.80F,
				Fat = 45.5F,
				CategoryID = 12
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 183,
				FoodName = "Patates Kızartması",
				GramCompensation = 80f,
				Calories = 250F,
				Carbohydrate = 33.15f,
				Protein = 2.75F,
				Fat = 11.8F,
				CategoryID = 12
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 184,
				FoodName = "Soğan Halkası",
				GramCompensation = 100f,
				Calories = 97F,
				Carbohydrate = 18.91f,
				Protein = 3.4F,
				Fat = 0.63F,
				CategoryID = 12
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 185,
				FoodName = "Kıymalı Pide",
				GramCompensation = 300f,
				Calories = 628F,
				Carbohydrate = 73.44f,
				Protein = 24.6F,
				Fat = 25.57F,
				CategoryID = 12
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 186,
				FoodName = "Kaşarlı Pide",
				GramCompensation = 250f,
				Calories = 600F,
				Carbohydrate = 69f,
				Protein = 19.75F,
				Fat = 26.83F,
				CategoryID = 12
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 187,
				FoodName = "Kuşbaşılı pide",
				GramCompensation = 350f,
				Calories = 515F,
				Carbohydrate = 73.2f,
				Protein = 28.3F,
				Fat = 11.5F,
				CategoryID = 12
			});


			//KIRMIZI ET
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 188,
				FoodName = "Dana Eti",
				GramCompensation = 1f,
				Calories = 2.31F,
				Carbohydrate = 73.2f,
				Protein = 28.3F,
				Fat = 11.5F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 189,
				FoodName = "Kuzu Eti",
				GramCompensation = 1f,
				Calories = 2.71F,
				Carbohydrate = 0f,
				Protein = 0.25F,
				Fat = 0.18F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 190,
				FoodName = "Etli Sebzeli Pizza",
				GramCompensation = 1f,
				Calories = 2.44F,
				Carbohydrate = 0.25f,
				Protein = 0.11F,
				Fat = 0.11F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 191,
				FoodName = "Kızarmış Hindi Eti",
				GramCompensation = 1f,
				Calories = 1.9F,
				Carbohydrate = 0f,
				Protein = 0.28F,
				Fat = 0.07F,
				CategoryID = 13
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 192,
				FoodName = "Kaz Eti",
				GramCompensation = 1f,
				Calories = 3.05F,
				Carbohydrate = 0f,
				Protein = 0.25F,
				Fat = 0.22F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 193,
				FoodName = "Keçi Eti",
				GramCompensation = 1f,
				Calories = 1.4F,
				Carbohydrate = 0f,
				Protein = 0.27F,
				Fat = 0.03F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 194,
				FoodName = "Kurutulmuş Sığır Eti",
				GramCompensation = 1f,
				Calories = 4.1F,
				Carbohydrate = 0.11f,
				Protein = 0.33F,
				Fat = 0.25F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 195,
				FoodName = "Etli Nohut",
				GramCompensation = 1f,
				Calories = 1.74F,
				Carbohydrate = 0.08f,
				Protein = 0.012F,
				Fat = 0.01F,
				CategoryID = 13
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 196,
				FoodName = "Et Döner",
				GramCompensation = 1f,
				Calories = 2.52F,
				Carbohydrate = 0.20f,
				Protein = 0.3F,
				Fat = 0.11F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 197,
				FoodName = "Et Kavurma",
				GramCompensation = 1f,
				Calories = 3.43F,
				Carbohydrate = 0f,
				Protein = 0.2F,
				Fat = 0.28F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 198,
				FoodName = "Et Sote",
				GramCompensation = 1f,
				Calories = 1.43F,
				Carbohydrate = 0.03f,
				Protein = 0.14F,
				Fat = 0.07F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 199,
				FoodName = "Dana Etli Burrito",
				GramCompensation = 1f,
				Calories = 2.62F,
				Carbohydrate = 0.29f,
				Protein = 0.13F,
				Fat = 0.1F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 200,
				FoodName = "Etli Kuru Fasulye",
				GramCompensation = 1f,
				Calories = 1.43F,
				Carbohydrate = 0.13f,
				Protein = 0.09F,
				Fat = 0.06F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 201,
				FoodName = "Etli Türlü",
				GramCompensation = 1f,
				Calories = 0.9F,
				Carbohydrate = 0.04f,
				Protein = 0.054F,
				Fat = 0.056F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 202,
				FoodName = "Etli Taze Fasulye",
				GramCompensation = 1f,
				Calories = 0.88F,
				Carbohydrate = 0.024f,
				Protein = 0.066F,
				Fat = 0.057F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 203,
				FoodName = "Etli Biber Dolması",
				GramCompensation = 1f,
				Calories = 0.79F,
				Carbohydrate = 0.036f,
				Protein = 0.054F,
				Fat = 0.047F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 204,
				FoodName = "Sulu Köfte",
				GramCompensation = 1f,
				Calories = 2.22F,
				Carbohydrate = 0.10f,
				Protein = 0.14F,
				Fat = 0.13F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 205,
				FoodName = "İslim Kebabı",
				GramCompensation = 1f,
				Calories = 0.87F,
				Carbohydrate = 0.03f,
				Protein = 0.05F,
				Fat = 0.06F,
				CategoryID = 13
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 206,
				FoodName = "Izgara Köfte",
				GramCompensation = 1f,
				Calories = 1.67F,
				Carbohydrate = 0.04f,
				Protein = 0.14F,
				Fat = 0.1F,
				CategoryID = 13
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 207,
				FoodName = "İzmir Köfte",
				GramCompensation = 1f,
				Calories = 1.65F,
				Carbohydrate = 0.115f,
				Protein = 0.08F,
				Fat = 0.01F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 208,
				FoodName = "İçli Köfte",
				GramCompensation = 1f,
				Calories = 2.33F,
				Carbohydrate = 0.32f,
				Protein = 0.1F,
				Fat = 0.07F,
				CategoryID = 13
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 209,
				FoodName = "Kasap Köfte",
				GramCompensation = 1f,
				Calories = 1.8F,
				Carbohydrate = 0.10f,
				Protein = 0.017F,
				Fat = 0.076F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 210,
				FoodName = "İnegöl Köfte",
				GramCompensation = 1f,
				Calories = 3F,
				Carbohydrate = 0.08f,
				Protein = 0.16F,
				Fat = 0.11F,
				CategoryID = 13
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 211,
				FoodName = "Kadınbudu Köfte",
				GramCompensation = 1f,
				Calories = 3.52F,
				Carbohydrate = 0.14f,
				Protein = 0.13F,
				Fat = 0.27F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 212,
				FoodName = "Adana Kebabı",
				GramCompensation = 1f,
				Calories = 2.29F,
				Carbohydrate = 0.08f,
				Protein = 0.08F,
				Fat = 0.05F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 213,
				FoodName = "Patlıcan Kebabı",
				GramCompensation = 1f,
				Calories = 1.02F,
				Carbohydrate = 0.048f,
				Protein = 0.09F,
				Fat = 0.045F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 214,
				FoodName = "Orman Kebabı",
				GramCompensation = 1f,
				Calories = 1.25F,
				Carbohydrate = 0.1f,
				Protein = 0.048F,
				Fat = 0.04F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 215,
				FoodName = "Kuzu Şiş",
				GramCompensation = 1f,
				Calories = 1.67F,
				Carbohydrate = 0.038f,
				Protein = 0.165F,
				Fat = 0.097F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 216,
				FoodName = "Tas Kebabı",
				GramCompensation = 1f,
				Calories = 0.7F,
				Carbohydrate = 0.07f,
				Protein = 0.05F,
				Fat = 0.04F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 217,
				FoodName = "Beyti Kebabı",
				GramCompensation = 1f,
				Calories = 2F,
				Carbohydrate = 0.13f,
				Protein = 0.1F,
				Fat = 0.12F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 218,
				FoodName = "Cağ Kebabı",
				GramCompensation = 1f,
				Calories = 1.67F,
				Carbohydrate = 0.038f,
				Protein = 0.165F,
				Fat = 0.097F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 219,
				FoodName = "Tepsi Kebabı",
				GramCompensation = 1f,
				Calories = 1.72F,
				Carbohydrate = 0.04f,
				Protein = 0.106F,
				Fat = 0.123F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 220,
				FoodName = "Urfa Kebabı",
				GramCompensation = 1f,
				Calories = 1.77F,
				Carbohydrate = 0.016f,
				Protein = 0.154F,
				Fat = 0.118F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 221,
				FoodName = "Çökertme Kebabı",
				GramCompensation = 1f,
				Calories = 2.49F,
				Carbohydrate = 0.12f,
				Protein = 0.105F,
				Fat = 0.28F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 222,
				FoodName = "Kağıt Kebabı",
				GramCompensation = 1f,
				Calories = 0.8F,
				Carbohydrate = 0.036f,
				Protein = 0.103F,
				Fat = 0.28F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 223,
				FoodName = "İskender",
				GramCompensation = 1f,
				Calories = 1.93F,
				Carbohydrate = 0.14f,
				Protein = 0.09F,
				Fat = 0.11F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 224,
				FoodName = "Alinazik Kebabı",
				GramCompensation = 1f,
				Calories = 0.57F,
				Carbohydrate = 0.03f,
				Protein = 0.035F,
				Fat = 0.034F,
				CategoryID = 13
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 225,
				FoodName = "Manisa Kebabı",
				GramCompensation = 1f,
				Calories = 5.34F,
				Carbohydrate = 3.35f,
				Protein = 2.33F,
				Fat = 3.36F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 226,
				FoodName = "Soğan Kebabı",
				GramCompensation = 1f,
				Calories = 2.79F,
				Carbohydrate = 0.05f,
				Protein = 0.09F,
				Fat = 0.05F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 227,
				FoodName = "Islak Hamburger",
				GramCompensation = 1f,
				Calories = 1.66F,
				Carbohydrate = 0.153f,
				Protein = 0.07F,
				Fat = 0.08F,
				CategoryID = 13
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 228,
				FoodName = "Hamburger",
				GramCompensation = 1f,
				Calories = 2.58F,
				Carbohydrate = 0.265f,
				Protein = 0.147F,
				Fat = 0.104F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 229,
				FoodName = "Kıymalı Börek",
				GramCompensation = 1f,
				Calories = 2.48F,
				Carbohydrate = 0.288f,
				Protein = 0.092F,
				Fat = 0.104F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 230,
				FoodName = "Patlıcan Musakka",
				GramCompensation = 1f,
				Calories = 1.42F,
				Carbohydrate = 0.96f,
				Protein = 0.048F,
				Fat = 0.06F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 231,
				FoodName = "Kıymalı Pide",
				GramCompensation = 1f,
				Calories = 2.09F,
				Carbohydrate = 0.245f,
				Protein = 0.082F,
				Fat = 0.085F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 232,
				FoodName = "Kıymalı Yumurta",
				GramCompensation = 1f,
				Calories = 3.62F,
				Carbohydrate = 0.074f,
				Protein = 0.25F,
				Fat = 0.074F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 233,
				FoodName = "Kavrulmuş Kıyma",
				GramCompensation = 1f,
				Calories = 2F,
				Carbohydrate = 0.007f,
				Protein = 0.276F,
				Fat = 0.122F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 234,
				FoodName = "Kıymalı Makarna",
				GramCompensation = 1f,
				Calories = 3.92F,
				Carbohydrate = 0.539f,
				Protein = 0.155F,
				Fat = 0.121F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 235,
				FoodName = "Kıymalı Ispanak",
				GramCompensation = 1f,
				Calories = 0.75F,
				Carbohydrate = 0.105f,
				Protein = 0.036F,
				Fat = 0.023F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 236,
				FoodName = "Kıymalı Karnabahar",
				GramCompensation = 1f,
				Calories = 1.12F,
				Carbohydrate = 0.11f,
				Protein = 0.03F,
				Fat = 0.06F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 237,
				FoodName = "Kıymalı Kabak Yemeği",
				GramCompensation = 1f,
				Calories = 0.6F,
				Carbohydrate = 0.105f,
				Protein = 0.022F,
				Fat = 0.016F,
				CategoryID = 13
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 238,
				FoodName = "Karnıyarık",
				GramCompensation = 1f,
				Calories = 1.42F,
				Carbohydrate = 0.025f,
				Protein = 0.032F,
				Fat = 0.035F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 239,
				FoodName = "Kıymalı Bezelye",
				GramCompensation = 1f,
				Calories = 0.96F,
				Carbohydrate = 0.058f,
				Protein = 0.079F,
				Fat = 0.044F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 240,
				FoodName = "Kıymalı Bamya",
				GramCompensation = 1f,
				Calories = 0.45F,
				Carbohydrate = 0.032f,
				Protein = 0.034F,
				Fat = 0.018F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 241,
				FoodName = "Kıymalı Gözleme",
				GramCompensation = 1f,
				Calories = 2.56F,
				Carbohydrate = 0.445f,
				Protein = 0.103F,
				Fat = 0.06F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 242,
				FoodName = "Kıymalı Kapuska",
				GramCompensation = 1f,
				Calories = 0.59F,
				Carbohydrate = 0.049f,
				Protein = 0.025F,
				Fat = 0.032F,
				CategoryID = 13
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 243,
				FoodName = "Kıymalı Patates",
				GramCompensation = 1f,
				Calories = 0.8F,
				Carbohydrate = 0.09f,
				Protein = 0.04F,
				Fat = 0.03F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 244,
				FoodName = "Kıymalı Yaprak Sarma",
				GramCompensation = 1f,
				Calories = 1.06F,
				Carbohydrate = 0.052f,
				Protein = 0.056F,
				Fat = 0.071F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 245,
				FoodName = "Kuzu Küşleme",
				GramCompensation = 1f,
				Calories = 2.20F,
				Carbohydrate = 0.025f,
				Protein = 0.328F,
				Fat = 0.09F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 246,
				FoodName = "Etli Lahana Sarma",
				GramCompensation = 1f,
				Calories = 1.25F,
				Carbohydrate = 0.115f,
				Protein = 0.04F,
				Fat = 0.025F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 247,
				FoodName = "Etli Pilav",
				GramCompensation = 1f,
				Calories = 1.42F,
				Carbohydrate = 0.22f,
				Protein = 0.55F,
				Fat = 0.035F,
				CategoryID = 13
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 248,
				FoodName = "Etli Ekmek",
				GramCompensation = 1f,
				Calories = 3.07F,
				Carbohydrate = 0.352f,
				Protein = 0.11F,
				Fat = 0.136F,
				CategoryID = 13
			});

			//SEBZELER

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 249,
				FoodName = "Domates",
				GramCompensation = 123f,
				Calories = 22F,
				Carbohydrate = 4.78F,
				Protein = 1.08F,
				Fat = 0.25F,
				CategoryID = 14
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 250,
				FoodName = "Çeri Domates",
				GramCompensation = 149f,
				Calories = 27F,
				Carbohydrate = 5.8F,
				Protein = 1.31F,
				Fat = 0.30F,
				CategoryID = 14
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 251,
				FoodName = "Salatalık",
				GramCompensation = 100f,
				Calories = 15F,
				Carbohydrate = 3.63F,
				Protein = 0.65F,
				Fat = 0.11F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 252,
				FoodName = "Marul",
				GramCompensation = 36f,
				Calories = 5F,
				Carbohydrate = 1.03F,
				Protein = 0.5F,
				Fat = 0.05F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 253,
				FoodName = "Çarliston Biber",
				GramCompensation = 46f,
				Calories = 12F,
				Carbohydrate = 2.46F,
				Protein = 0.76F,
				Fat = 0.21F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 254,
				FoodName = "Kırmızı Biber",
				GramCompensation = 119f,
				Calories = 37F,
				Carbohydrate = 7.18F,
				Protein = 1.18F,
				Fat = 0.36F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 255,
				FoodName = "Nane",
				GramCompensation = 5f,
				Calories = 1F,
				Carbohydrate = 0.24F,
				Protein = 0.06F,
				Fat = 0.001F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 256,
				FoodName = "Fesleğen",
				GramCompensation = 10f,
				Calories = 1F,
				Carbohydrate = 0.23F,
				Protein = 0.13F,
				Fat = 0.03F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 257,
				FoodName = "Dereotu",
				GramCompensation = 10f,
				Calories = 1F,
				Carbohydrate = 0.23F,
				Protein = 0.13F,
				Fat = 0.01F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 258,
				FoodName = "Kişniş",
				GramCompensation = 5f,
				Calories = 5F,
				Carbohydrate = 0.99F,
				Protein = 0.22F,
				Fat = 0.32F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 259,
				FoodName = "Biberiye",
				GramCompensation = 5f,
				Calories = 4F,
				Carbohydrate = 0.77F,
				Protein = 0.06F,
				Fat = 0.18F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 260,
				FoodName = "Maydanoz",
				GramCompensation = 5f,
				Calories = 1F,
				Carbohydrate = 0.24F,
				Protein = 0.11F,
				Fat = 0.03F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 261,
				FoodName = "Turp",
				GramCompensation = 116f,
				Calories = 19F,
				Carbohydrate = 3.94F,
				Protein = 0.79F,
				Fat = 0.12F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 262,
				FoodName = "Karnabahar",
				GramCompensation = 107f,
				Calories = 27F,
				Carbohydrate = 5.32F,
				Protein = 2.05F,
				Fat = 0.3F,
				CategoryID = 14
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 263,
				FoodName = "Brokoli",
				GramCompensation = 91f,
				Calories = 31F,
				Carbohydrate = 6.04F,
				Protein = 2.57F,
				Fat = 0.34F,
				CategoryID = 14
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 264,
				FoodName = "Brüksel Lahana",
				GramCompensation = 88f,
				Calories = 38F,
				Carbohydrate = 7.88F,
				Protein = 2.97F,
				Fat = 0.26F,
				CategoryID = 14
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 265,
				FoodName = "Beyaz Lahana",
				GramCompensation = 90f,
				Calories = 22F,
				Carbohydrate = 5.16F,
				Protein = 1.14F,
				Fat = 0.09F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 266,
				FoodName = "Kırmızı Lahana",
				GramCompensation = 90f,
				Calories = 28F,
				Carbohydrate = 6.56F,
				Protein = 1.27F,
				Fat = 0.14F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 267,
				FoodName = "Havuç",
				GramCompensation = 61f,
				Calories = 25F,
				Carbohydrate = 5.84F,
				Protein = 0.57F,
				Fat = 0.15F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 268,
				FoodName = "Sarımsak",
				GramCompensation = 5f,
				Calories = 4F,
				Carbohydrate = 0.99F,
				Protein = 0.19F,
				Fat = 0.02F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 269,
				FoodName = "Soğan",
				GramCompensation = 110f,
				Calories = 44F,
				Carbohydrate = 10.27F,
				Protein = 1.21F,
				Fat = 0.11F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 270,
				FoodName = "Yeşil Soğan",
				GramCompensation = 5f,
				Calories = 2F,
				Carbohydrate = 0.44F,
				Protein = 0.11F,
				Fat = 0.01F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 271,
				FoodName = "Semizotu",
				GramCompensation = 43f,
				Calories = 9F,
				Carbohydrate = 1.46F,
				Protein = 0.87F,
				Fat = 0.15F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 272,
				FoodName = "Pazı",
				GramCompensation = 36f,
				Calories = 7F,
				Carbohydrate = 1.35F,
				Protein = 0.65F,
				Fat = 0.07F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 273,
				FoodName = "Kabak",
				GramCompensation = 196f,
				Calories = 33F,
				Carbohydrate = 6.10F,
				Protein = 2.37F,
				Fat = 0.63F,
				CategoryID = 14
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 274,
				FoodName = "Roka",
				GramCompensation = 20f,
				Calories = 5F,
				Carbohydrate = 0.73F,
				Protein = 0.52F,
				Fat = 0.13F,
				CategoryID = 14
			});

			//SEBZE YEMEKLERİ
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 275,
				FoodName = "Ispanak Yemeği (Etsiz)",
				GramCompensation = 100f,
				Calories = 115F,
				Carbohydrate = 5.09F,
				Protein = 2.11F,
				Fat = 10.3F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 276,
				FoodName = "Zeytinyağlı Semizotu",
				GramCompensation = 100f,
				Calories = 112F,
				Carbohydrate = 4.98F,
				Protein = 1.29F,
				Fat = 10.26F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 277,
				FoodName = "Zeytinyağlı Pazı",
				GramCompensation = 100f,
				Calories = 131F,
				Carbohydrate = 11.89F,
				Protein = 3.74F,
				Fat = 7.18F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 278,
				FoodName = "Zeytinyağlı Taze Fasulye",
				GramCompensation = 100f,
				Calories = 151F,
				Carbohydrate = 21.39F,
				Protein = 5.54F,
				Fat = 5.51F,
				CategoryID = 15
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 279,
				FoodName = "Zeytinyağlı Pırasa",
				GramCompensation = 100f,
				Calories = 120F,
				Carbohydrate = 7.25F,
				Protein = 0.91F,
				Fat = 10.27F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 280,
				FoodName = "Bezelye Yemeği (Etsiz)",
				GramCompensation = 100f,
				Calories = 147F,
				Carbohydrate = 11.07F,
				Protein = 3.48F,
				Fat = 10.38F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 281,
				FoodName = "Zeytinyağlı Brokoli",
				GramCompensation = 100f,
				Calories = 80F,
				Carbohydrate = 7.14F,
				Protein = 2.37F,
				Fat = 5.41F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 282,
				FoodName = "Karnabahar Yemeği (Etsiz)",
				GramCompensation = 100f,
				Calories = 115F,
				Carbohydrate = 5.29F,
				Protein = 1.48F,
				Fat = 10.41F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 283,
				FoodName = "Bamya Yemeği (Etsiz)",
				GramCompensation = 100f,
				Calories = 113F,
				Carbohydrate = 4.68F,
				Protein = 1.06F,
				Fat = 10.57F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 284,
				FoodName = "Zeytinyağlı Türlü",
				GramCompensation = 100f,
				Calories = 112F,
				Carbohydrate = 8.68F,
				Protein = 1.33F,
				Fat = 8.87F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 285,
				FoodName = "Zeytinyağlı Bakla",
				GramCompensation = 100f,
				Calories = 145F,
				Carbohydrate = 9.76F,
				Protein = 3.32F,
				Fat = 10.69F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 286,
				FoodName = "Zeytinyağlı Kereviz",
				GramCompensation = 100f,
				Calories = 90F,
				Carbohydrate = 7.14F,
				Protein = 1.92F,
				Fat = 6.37F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 287,
				FoodName = "Zeytinyağlı Enginar",
				GramCompensation = 100f,
				Calories = 146F,
				Carbohydrate = 12.09F,
				Protein = 2.93F,
				Fat = 10.71F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 288,
				FoodName = "Sebze Sote",
				GramCompensation = 200f,
				Calories = 90F,
				Carbohydrate = 4.55F,
				Protein = 0.94F,
				Fat = 10.19F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 289,
				FoodName = "Zeytinyağlı Sebze Dolması",
				GramCompensation = 200f,
				Calories = 258F,
				Carbohydrate = 13.59F,
				Protein = 5.6F,
				Fat = 13.6F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 290,
				FoodName = "Zeytinyağlı Yaprak Sarma",
				GramCompensation = 60f,
				Calories = 108F,
				Carbohydrate = 8.32F,
				Protein = 1.33F,
				Fat = 8.15F,
				CategoryID = 15
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 291,
				FoodName = "Zeytinyağlı Kabak",
				GramCompensation = 100f,
				Calories = 111F,
				Carbohydrate = 5.19F,
				Protein = 0.81F,
				Fat = 10.18F,
				CategoryID = 15
			});

			//SALATALAR
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 292,
				FoodName = "Sade Salata (Karışık Yeşillik)",
				GramCompensation = 55f,
				Calories = 9F,
				Carbohydrate = 1.76F,
				Protein = 0.84F,
				Fat = 0.13F,
				CategoryID = 16
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 293,
				FoodName = "Mercimekli Lor Peynirli Salata",
				GramCompensation = 255f,
				Calories = 180F,
				Carbohydrate = 28F,
				Protein = 2.7F,
				Fat = 5.1F,
				CategoryID = 16
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 294,
				FoodName = "Tavuklu Salata",
				GramCompensation = 255f,
				Calories = 225F,
				Carbohydrate = 5.28F,
				Protein = 31.38F,
				Fat = 8.29F,
				CategoryID = 16
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 295,
				FoodName = "Etli Salata (Bonfileli/Köfteli/Fümeli)",
				GramCompensation = 260f,
				Calories = 267F,
				Carbohydrate = 5.28F,
				Protein = 24.84F,
				Fat = 16.49F,
				CategoryID = 16
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 296,
				FoodName = "Ton Balıklı Salata",
				GramCompensation = 270f,
				Calories = 215F,
				Carbohydrate = 5.28F,
				Protein = 21.96F,
				Fat = 6.35F,
				CategoryID = 16
			});


			//modelBuilder.Entity<Food>().HasData(new Food()
			//{
			//    FoodID = 296,
			//    FoodName = "Kısır",
			//    GramCompensation = 60f,
			//    Calories = 108F,
			//    Carbohydrate = 15.84F,
			//    Protein = 2.71F,
			//    Fat = 4.64F,
			//    CategoryID = 16
			//});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 297,
				FoodName = "Mercimet Köftesi",
				GramCompensation = 30f,
				Calories = 70F,
				Carbohydrate = 9.95F,
				Protein = 2.75F,
				Fat = 2.41F,
				CategoryID = 16
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 298,
				FoodName = "Tabule Salatası",
				GramCompensation = 370f,
				Calories = 588F,
				Carbohydrate = 51F,
				Protein = 14.4F,
				Fat = 33.3F,
				CategoryID = 16
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 299,
				FoodName = "Peynirli Yumurtalı Salata",
				GramCompensation = 260f,
				Calories = 225F,
				Carbohydrate = 6.7F,
				Protein = 16.78F,
				Fat = 9.81F,
				CategoryID = 16
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 300,
				FoodName = "Çoban Salata",
				GramCompensation = 220f,
				Calories = 115F,
				Carbohydrate = 16.62F,
				Protein = 3.19F,
				Fat = 3.76F,
				CategoryID = 16
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 301,
				FoodName = "Gavurdağı Salata",
				GramCompensation = 155f,
				Calories = 114F,
				Carbohydrate = 7.71F,
				Protein = 2.95F,
				Fat = 7.72F,
				CategoryID = 16
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 302,
				FoodName = "Patates Salatası",
				GramCompensation = 187f,
				Calories = 132F,
				Carbohydrate = 21.77F,
				Protein = 2.46F,
				Fat = 3.33F,
				CategoryID = 16
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 303,
				FoodName = "Meyve Salatası",
				GramCompensation = 315f,
				Calories = 172F,
				Carbohydrate = 38.4F,
				Protein = 1.65F,
				Fat = 0.96F,
				CategoryID = 16
			});

			//KURUYEMİŞLER

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 304,
				FoodName = "Kestane",
				GramCompensation = 50f,
				Calories = 98F,
				Carbohydrate = 22.09F,
				Protein = 0.81F,
				Fat = 0.62F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 305,
				FoodName = "Patlamış Mısır",
				GramCompensation = 20f,
				Calories = 76F,
				Carbohydrate = 15.58F,
				Protein = 2.40F,
				Fat = 0.84F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 306,
				FoodName = "Sarı Leblebi",
				GramCompensation = 20f,
				Calories = 71F,
				Carbohydrate = 11.7F,
				Protein = 3.73F,
				Fat = 1.25F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 307,
				FoodName = "Beyaz Leblebi",
				GramCompensation = 20f,
				Calories = 72F,
				Carbohydrate = 11.9F,
				Protein = 3.79F,
				Fat = 1.2F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 308,
				FoodName = "Fındık",
				GramCompensation = 15f,
				Calories = 97F,
				Carbohydrate = 2.57F,
				Protein = 2.30F,
				Fat = 9.36F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 309,
				FoodName = "Badem",
				GramCompensation = 17f,
				Calories = 97F,
				Carbohydrate = 3.62F,
				Protein = 3.55F,
				Fat = 8.39F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 310,
				FoodName = "Yer Fıstığı",
				GramCompensation = 30f,
				Calories = 170F,
				Carbohydrate = 4.84F,
				Protein = 7.74F,
				Fat = 14.77F,
				CategoryID = 17
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 311,
				FoodName = "Antep Fıstığı",
				GramCompensation = 18f,
				Calories = 103F,
				Carbohydrate = 5.09F,
				Protein = 3.79F,
				Fat = 8.25F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 312,
				FoodName = "Ceviz",
				GramCompensation = 10f,
				Calories = 52F,
				Carbohydrate = 1.1F,
				Protein = 1.22F,
				Fat = 5.22F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 313,
				FoodName = "Kabak Çekirdeği",
				GramCompensation = 20f,
				Calories = 104.4F,
				Carbohydrate = 2.68F,
				Protein = 6.6F,
				Fat = 8.42F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 314,
				FoodName = "Çiğ Kaju",
				GramCompensation = 20f,
				Calories = 111F,
				Carbohydrate = 6.04F,
				Protein = 3.64F,
				Fat = 8.77F,
				CategoryID = 17
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 315,
				FoodName = "Kaju Fıstığı Kavrulmuş",
				GramCompensation = 40f,
				Calories = 230F,
				Carbohydrate = 13.08F,
				Protein = 6.12F,
				Fat = 18.54F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 316,
				FoodName = "Sarı Leblebi",
				GramCompensation = 7f,
				Calories = 32F,
				Carbohydrate = 5.2F,
				Protein = 0.66F,
				Fat = 0.76F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 317,
				FoodName = "Erik Kurusu",
				GramCompensation = 100f,
				Calories = 267F,
				Carbohydrate = 68.9F,
				Protein = 3.5F,
				Fat = 1.2F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 318,
				FoodName = "Üzüm Kurusu",
				GramCompensation = 100f,
				Calories = 277F,
				Carbohydrate = 71.2F,
				Protein = 2.3F,
				Fat = 0.5F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 319,
				FoodName = "Kayısı Kurusu",
				GramCompensation = 100f,
				Calories = 284F,
				Carbohydrate = 72.2F,
				Protein = 5.4F,
				Fat = 1.2F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 320,
				FoodName = "Elma Kurusu",
				GramCompensation = 100f,
				Calories = 238F,
				Carbohydrate = 62.3F,
				Protein = 2.1F,
				Fat = 2.1F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 321,
				FoodName = "Muz Kurusu",
				GramCompensation = 100f,
				Calories = 390F,
				Carbohydrate = 80.5F,
				Protein = 3.9F,
				Fat = 1.8F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 322,
				FoodName = "Kuru İncir",
				GramCompensation = 100f,
				Calories = 290F,
				Carbohydrate = 78F,
				Protein = 3.6F,
				Fat = 1.2F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 323,
				FoodName = "Hurma",
				GramCompensation = 100f,
				Calories = 277F,
				Carbohydrate = 74F,
				Protein = 2F,
				Fat = 0.4F,
				CategoryID = 17
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 324,
				FoodName = "Yaban Mersini Kurusu",
				GramCompensation = 100f,
				Calories = 48F,
				Carbohydrate = 12F,
				Protein = 0.38F,
				Fat = 0.38F,
				CategoryID = 17
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 325,
				FoodName = "Armut Kurusu",
				GramCompensation = 100f,
				Calories = 270F,
				Carbohydrate = 62.6F,
				Protein = 2.3F,
				Fat = 0.6F,
				CategoryID = 17
			});

			//ATIŞTIRMALIKLAR
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 326,
				FoodName = "Patates Cipsi",
				GramCompensation = 100f,
				Calories = 719F,
				Carbohydrate = 10.46F,
				Protein = 1.23F,
				Fat = 74.78F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 327,
				FoodName = "Mısır Cipsi",
				GramCompensation = 100f,
				Calories = 404F,
				Carbohydrate = 42.68F,
				Protein = 4.95F,
				Fat = 25.05F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 328,
				FoodName = "Pringles Original",
				GramCompensation = 165f,
				Calories = 861F,
				Carbohydrate = 84.15F,
				Protein = 6.27F,
				Fat = 56.1F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 329,
				FoodName = "Ülker Çikolatalı Gofret",
				GramCompensation = 100f,
				Calories = 198F,
				Carbohydrate = 20.72F,
				Protein = 2.13F,
				Fat = 11.83F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 330,
				FoodName = "Jelibon",
				GramCompensation = 100f,
				Calories = 302F,
				Carbohydrate = 68.31F,
				Protein = 5.85F,
				Fat = 0.09F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 331,
				FoodName = "Petibör Bisküvi",
				GramCompensation = 175f,
				Calories = 765F,
				Carbohydrate = 139.77F,
				Protein = 13.53F,
				Fat = 16.8F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 332,
				FoodName = "Form Kepekli Bisküvi",
				GramCompensation = 45f,
				Calories = 184F,
				Carbohydrate = 26.69F,
				Protein = 5.9F,
				Fat = 4.86F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 333,
				FoodName = "Cicibebe Bisküvi",
				GramCompensation = 4f,
				Calories = 18F,
				Carbohydrate = 2.96F,
				Protein = 0.18F,
				Fat = 0.6F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 334,
				FoodName = "Çikolata",
				GramCompensation = 5f,
				Calories = 26F,
				Carbohydrate = 2.9F,
				Protein = 0.22F,
				Fat = 1.76F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 335,
				FoodName = "Protein Bar",
				GramCompensation = 50f,
				Calories = 76F,
				Carbohydrate = 6.6F,
				Protein = 2.21F,
				Fat = 4.54F,
				CategoryID = 18
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 336,
				FoodName = "Oreo",
				GramCompensation = 57f,
				Calories = 270F,
				Carbohydrate = 41.04F,
				Protein = 2F,
				Fat = 10.83F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 337,
				FoodName = "Olips Şeker",
				GramCompensation = 76f,
				Calories = 286F,
				Carbohydrate = 72.2F,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 338,
				FoodName = "Tadelle Çikolata",
				GramCompensation = 30f,
				Calories = 167F,
				Carbohydrate = 14.31F,
				Protein = 2.7F,
				Fat = 10.98F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 339,
				FoodName = "Dido Çikolata",
				GramCompensation = 35f,
				Calories = 190F,
				Carbohydrate = 21.88F,
				Protein = 2.7F,
				Fat = 9.98F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 340,
				FoodName = "Karam Gurme",
				GramCompensation = 50f,
				Calories = 259F,
				Carbohydrate = 29F,
				Protein = 2.75F,
				Fat = 14F,
				CategoryID = 18
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 341,
				FoodName = "Eti Brownie Gold",
				GramCompensation = 40f,
				Calories = 154F,
				Carbohydrate = 22F,
				Protein = 2.04F,
				Fat = 7.92F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 342,
				FoodName = "Kinder Süt Dilimi",
				GramCompensation = 28f,
				Calories = 118F,
				Carbohydrate = 10.75F,
				Protein = 2.16F,
				Fat = 7.28F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 343,
				FoodName = "Kinder Sürpriz Yumurta",
				GramCompensation = 20f,
				Calories = 110F,
				Carbohydrate = 10.4F,
				Protein = 1.6F,
				Fat = 6.8F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 344,
				FoodName = "Eti Gong",
				GramCompensation = 11f,
				Calories = 50F,
				Carbohydrate = 7.84F,
				Protein = 0.64F,
				Fat = 1.78F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 345,
				FoodName = "Biskrem",
				GramCompensation = 10f,
				Calories = 50F,
				Carbohydrate = 6.51F,
				Protein = 0.45F,
				Fat = 2.41F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 346,
				FoodName = "Ülker Probis",
				GramCompensation = 8f,
				Calories = 39F,
				Carbohydrate = 4.37F,
				Protein = 0.93F,
				Fat = 1.9F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 347,
				FoodName = "Süt Burger",
				GramCompensation = 35f,
				Calories = 113F,
				Carbohydrate = 17.05F,
				Protein = 1.75F,
				Fat = 3.78F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 348,
				FoodName = "Dankek 8kek",
				GramCompensation = 55f,
				Calories = 90F,
				Carbohydrate = 12.65F,
				Protein = 0.88F,
				Fat = 4.01F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 349,
				FoodName = "Brownie Intense",
				GramCompensation = 50f,
				Calories = 232F,
				Carbohydrate = 26.5F,
				Protein = 2.3F,
				Fat = 12.85F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 350,
				FoodName = "Eti Topkek Kakolu",
				GramCompensation = 40f,
				Calories = 167F,
				Carbohydrate = 22.96F,
				Protein = 2.12F,
				Fat = 7.24F,
				CategoryID = 18
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 351,
				FoodName = "Eti Popkek Meyveli",
				GramCompensation = 60f,
				Calories = 264F,
				Carbohydrate = 34.62F,
				Protein = 2.82F,
				Fat = 12.6F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 352,
				FoodName = "Eti Topkek Portakallı",
				GramCompensation = 40f,
				Calories = 167F,
				Carbohydrate = 22.96F,
				Protein = 2.12F,
				Fat = 7.24F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 353,
				FoodName = "Halley",
				GramCompensation = 30f,
				Calories = 132F,
				Carbohydrate = 20.31F,
				Protein = 1.2F,
				Fat = 5.1F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 354,
				FoodName = "Ülker Kremalı Bisküvi",
				GramCompensation = 7f,
				Calories = 33F,
				Carbohydrate = 5.16F,
				Protein = 0.36F,
				Fat = 1.27F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 355,
				FoodName = "Ülker Çokoprens",
				GramCompensation = 30f,
				Calories = 152F,
				Carbohydrate = 18.6F,
				Protein = 1.68F,
				Fat = 7.8F,
				CategoryID = 18
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 356,
				FoodName = "Eti Cin",
				GramCompensation = 10f,
				Calories = 44F,
				Carbohydrate = 7.43F,
				Protein = 0.47F,
				Fat = 1.38F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 357,
				FoodName = "Eti Nero",
				GramCompensation = 120f,
				Calories = 584F,
				Carbohydrate = 69.72F,
				Protein = 8.28F,
				Fat = 29.28F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 358,
				FoodName = "Eti Tutku",
				GramCompensation = 10f,
				Calories = 51F,
				Carbohydrate = 6.1F,
				Protein = 0.5F,
				Fat = 2.6F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 359,
				FoodName = "Eti Benim'O",
				GramCompensation = 10f,
				Calories = 46F,
				Carbohydrate = 6.13F,
				Protein = 0.47F,
				Fat = 2.16F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 360,
				FoodName = "Eti Burçak",
				GramCompensation = 15f,
				Calories = 68F,
				Carbohydrate = 9.87F,
				Protein = 0.93F,
				Fat = 2.54F,
				CategoryID = 18
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 361,
				FoodName = "Ülker İkram",
				GramCompensation = 84f,
				Calories = 405F,
				Carbohydrate = 52.92F,
				Protein = 6.47F,
				Fat = 17.64F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 362,
				FoodName = "Lotus Bisküvi",
				GramCompensation = 125f,
				Calories = 605F,
				Carbohydrate = 90.75F,
				Protein = 6.13F,
				Fat = 23.75F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 363,
				FoodName = "Şölen Greta Zeytinli",
				GramCompensation = 30f,
				Calories = 133F,
				Carbohydrate = 18.1F,
				Protein = 2.8F,
				Fat = 5.4F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 364,
				FoodName = "Ülker Çokonat",
				GramCompensation = 33f,
				Calories = 181F,
				Carbohydrate = 19.11F,
				Protein = 2.05F,
				Fat = 11.32F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 365,
				FoodName = "Kinder Bueno",
				GramCompensation = 21f,
				Calories = 120F,
				Carbohydrate = 10.4F,
				Protein = 1.81F,
				Fat = 7.83F,
				CategoryID = 18
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 366,
				FoodName = "Eti Hoşbeş",
				GramCompensation = 40f,
				Calories = 197F,
				Carbohydrate = 25.56F,
				Protein = 3.04F,
				Fat = 9.8F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 367,
				FoodName = "Twix",
				GramCompensation = 50f,
				Calories = 250F,
				Carbohydrate = 34F,
				Protein = 4F,
				Fat = 12F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 368,
				FoodName = "Snickers",
				GramCompensation = 50f,
				Calories = 237F,
				Carbohydrate = 31.31F,
				Protein = 3.8F,
				Fat = 11.35F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 369,
				FoodName = "Mars",
				GramCompensation = 50f,
				Calories = 225F,
				Carbohydrate = 35F,
				Protein = 2F,
				Fat = 8.5F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 370,
				FoodName = "Ülker Albeni",
				GramCompensation = 40f,
				Calories = 206F,
				Carbohydrate = 25.2F,
				Protein = 2.24F,
				Fat = 10.64F,
				CategoryID = 18
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 371,
				FoodName = "Crunch Çikolata",
				GramCompensation = 33f,
				Calories = 169F,
				Carbohydrate = 20.16F,
				Protein = 2.05F,
				Fat = 8.74F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 372,
				FoodName = "Ülker Metro",
				GramCompensation = 40f,
				Calories = 184F,
				Carbohydrate = 27.36F,
				Protein = 1.96F,
				Fat = 7.4F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 373,
				FoodName = "Alaska Frigo",
				GramCompensation = 60f,
				Calories = 193F,
				Carbohydrate = 22.98F,
				Protein = 2.4F,
				Fat = 9.78F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 374,
				FoodName = "Coco Star",
				GramCompensation = 28f,
				Calories = 148F,
				Carbohydrate = 15.48F,
				Protein = 1.2F,
				Fat = 0F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 375,
				FoodName = "Sade Çubuk Kraker",
				GramCompensation = 52f,
				Calories = 200F,
				Carbohydrate = 40.82F,
				Protein = 5.51F,
				Fat = 2.91F,
				CategoryID = 18
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 376,
				FoodName = "Susamlı Çubuk Kraker",
				GramCompensation = 37f,
				Calories = 172F,
				Carbohydrate = 22.39F,
				Protein = 3.89F,
				Fat = 7.1F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 377,
				FoodName = "Çizi Bisküvi",
				GramCompensation = 20f,
				Calories = 113F,
				Carbohydrate = 5.47F,
				Protein = 3.15F,
				Fat = 8.86F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 378,
				FoodName = "Cornetto",
				GramCompensation = 75f,
				Calories = 125F,
				Carbohydrate = 15F,
				Protein = 1.56F,
				Fat = 6.25F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 379,
				FoodName = "Magnum",
				GramCompensation = 77f,
				Calories = 239F,
				Carbohydrate = 24.64F,
				Protein = 2.7F,
				Fat = 14.63F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 380,
				FoodName = "Mısır Gevreği / Cornflakes",
				GramCompensation = 50f,
				Calories = 179F,
				Carbohydrate = 42.05F,
				Protein = 3.75F,
				Fat = 0.2F,
				CategoryID = 18
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 381,
				FoodName = "Yulaf Ezmesi",
				GramCompensation = 100f,
				Calories = 195F,
				Carbohydrate = 33.14F,
				Protein = 8.45F,
				Fat = 3.45F,
				CategoryID = 18
			});

			//Alkolsüz içecekler

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 382,
				FoodName = "Maden Suyu",
				GramCompensation = 1f,
				Calories = 0.0F,
				Carbohydrate = 0.0f,
				Protein = 0.0F,
				Fat = 0.0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 383,
				FoodName = "Bergamot Çayı",
				GramCompensation = 125f,
				Calories = 2.6F,
				Carbohydrate = 0.0f,
				Protein = 0.0F,
				Fat = 0.0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 384,
				FoodName = "Boza",
				GramCompensation = 275f,
				Calories = 279F,
				Carbohydrate = 60f,
				Protein = 45F,
				Fat = 1.8F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 385,
				FoodName = "Salep",
				GramCompensation = 200f,
				Calories = 188F,
				Carbohydrate = 27.8f,
				Protein = 5.6F,
				Fat = 6F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 386,
				FoodName = "Kahve",
				GramCompensation = 125f,
				Calories = 79F,
				Carbohydrate = 21.4f,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 387,
				FoodName = "CocaCola",
				GramCompensation = 125f,
				Calories = 22.4F,
				Carbohydrate = 21.4f,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 388,
				FoodName = "CocaCola Light",
				GramCompensation = 125f,
				Calories = 0F,
				Carbohydrate = 0f,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 389,
				FoodName = "CocaCola Zero",
				GramCompensation = 125f,
				Calories = 0F,
				Carbohydrate = 0f,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 390,
				FoodName = "Fanta",
				GramCompensation = 125f,
				Calories = 95F,
				Carbohydrate = 23.4f,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 391,
				FoodName = "Limonata",
				GramCompensation = 125f,
				Calories = 73F,
				Carbohydrate = 14.69f,
				Protein = 0.24F,
				Fat = 0.2F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 392,
				FoodName = "Gazoz",
				GramCompensation = 125f,
				Calories = 84F,
				Carbohydrate = 0f,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 393,
				FoodName = "Milkshake",
				GramCompensation = 230f,
				Calories = 230F,
				Carbohydrate = 36.8F,
				Protein = 7.2F,
				Fat = 5.6F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 394,
				FoodName = "Smoothie",
				GramCompensation = 230f,
				Calories = 82F,
				Carbohydrate = 21F,
				Protein = 0.1F,
				Fat = 0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 395,
				FoodName = "Meyve Suyu",
				GramCompensation = 200f,
				Calories = 100F,
				Carbohydrate = 24.2F,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 396,
				FoodName = "Taze Sıkma Portakal Suyu",
				GramCompensation = 200f,
				Calories = 120F,
				Carbohydrate = 29.28F,
				Protein = 0.8F,
				Fat = 0.33F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 397,
				FoodName = "Nar Suyu",
				GramCompensation = 200f,
				Calories = 2F,
				Carbohydrate = 0F,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 398,
				FoodName = "Şalgam Suyu",
				GramCompensation = 200f,
				Calories = 10F,
				Carbohydrate = 2.12F,
				Protein = 1.03F,
				Fat = 0.22F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 399,
				FoodName = "Sıcak Çikolata",
				GramCompensation = 250f,
				Calories = 106F,
				Carbohydrate = 26.06F,
				Protein = 0F,
				Fat = 0.1F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 400,
				FoodName = "Powerade",
				GramCompensation = 250f,
				Calories = 32F,
				Carbohydrate = 0F,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 401,
				FoodName = "Red Bull",
				GramCompensation = 200f,
				Calories = 90F,
				Carbohydrate = 22F,
				Protein = 0.6F,
				Fat = 0.2F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 402,
				FoodName = "Zencefilli Bitki Çayı",
				GramCompensation = 200f,
				Calories = 0F,
				Carbohydrate = 0F,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 403,
				FoodName = "Çay",
				GramCompensation = 150f,
				Calories = 10F,
				Carbohydrate = 2.35F,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 404,
				FoodName = "Türk Kahvesi",
				GramCompensation = 200f,
				Calories = 4F,
				Carbohydrate = 0F,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 405,
				FoodName = "White Chocolate Mocha",
				GramCompensation = 348f,
				Calories = 259F,
				Carbohydrate = 31.86F,
				Protein = 7.55F,
				Fat = 12.04F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 406,
				FoodName = "Cool Lime",
				GramCompensation = 200f,
				Calories = 25F,
				Carbohydrate = 6.99F,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 407,
				FoodName = "Starbucks Berry Hibiscus",
				GramCompensation = 200f,
				Calories = 60F,
				Carbohydrate = 20F,
				Protein = 0F,
				Fat = 0F,
				CategoryID = 19
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 408,
				FoodName = "Cappuccino",
				GramCompensation = 250f,
				Calories = 50F,
				Carbohydrate = 7F,
				Protein = 4.19F,
				Fat = 0.005F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 409,
				FoodName = "Latte",
				GramCompensation = 250f,
				Calories = 60F,
				Carbohydrate = 8.5F,
				Protein = 6F,
				Fat = 0.005F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 410,
				FoodName = "Filtre Kahve",
				GramCompensation = 250f,
				Calories = 3F,
				Carbohydrate = 0F,
				Protein = 0.28F,
				Fat = 0.07F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 411,
				FoodName = "Nescafe Xpress",
				GramCompensation = 250f,
				Calories = 100F,
				Carbohydrate = 16.4F,
				Protein = 2.8F,
				Fat = 2.6F,
				CategoryID = 19
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 412,
				FoodName = "Nescafe 3'ü 1 arada",
				GramCompensation = 250f,
				Calories = 81F,
				Carbohydrate = 15.19F,
				Protein = 0.5F,
				Fat = 1.89F,
				CategoryID = 19
			});


			//EV YEMEKLERİ

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 413,
				FoodName = "Pilav Üstü Kuru",
				GramCompensation = 230f,
				Calories = 336F,
				Carbohydrate = 57.52F,
				Protein = 15.28F,
				Fat = 4.44F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 414,
				FoodName = "Hamsili Pilav",
				GramCompensation = 230f,
				Calories = 334F,
				Carbohydrate = 30.3F,
				Protein = 26.52F,
				Fat = 12.29F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 415,
				FoodName = "Şehriyeli Pilav",
				GramCompensation = 270f,
				Calories = 462F,
				Carbohydrate = 82.85F,
				Protein = 8.53F,
				Fat = 10.01F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 416,
				FoodName = "Nohutlu Pilav",
				GramCompensation = 100f,
				Calories = 169F,
				Carbohydrate = 31.29F,
				Protein = 4.15F,
				Fat = 2.94F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 417,
				FoodName = "İç Pilav",
				GramCompensation = 100f,
				Calories = 139F,
				Carbohydrate = 25.99F,
				Protein = 2.59F,
				Fat = 2.53F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 418,
				FoodName = "Sade Pilav",
				GramCompensation = 80f,
				Calories = 118F,
				Carbohydrate = 22.62F,
				Protein = 1.99F,
				Fat = 1.99F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 419,
				FoodName = "Domatesli Bulgur Pilavı",
				GramCompensation = 230f,
				Calories = 169F,
				Carbohydrate = 31.13F,
				Protein = 4.56F,
				Fat = 2.61F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 420,
				FoodName = "Acem Pilavı",
				GramCompensation = 245f,
				Calories = 480F,
				Carbohydrate = 43.69F,
				Protein = 22.32F,
				Fat = 23.76F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 421,
				FoodName = "Özbek Pilavı",
				GramCompensation = 340f,
				Calories = 570F,
				Carbohydrate = 58.2F,
				Protein = 22.35F,
				Fat = 27.56F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 422,
				FoodName = "Basmati Pilavı",
				GramCompensation = 50f,
				Calories = 118F,
				Carbohydrate = 14.05F,
				Protein = 1.65F,
				Fat = 3.1F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 423,
				FoodName = "Kuskus Pilavı",
				GramCompensation = 180f,
				Calories = 380F,
				Carbohydrate = 72.76F,
				Protein = 11.79F,
				Fat = 3.75F,
				CategoryID = 20
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 424,
				FoodName = "Tereyağlı Pirinç Pilavı",
				GramCompensation = 170f,
				Calories = 283F,
				Carbohydrate = 46.47F,
				Protein = 4.14F,
				Fat = 8.65F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 425,
				FoodName = "Bezelye Çorbası",
				GramCompensation = 150f,
				Calories = 31F,
				Carbohydrate = 3.06F,
				Protein = 1.05F,
				Fat = 1.6F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 426,
				FoodName = "Bezelye Çorbası",
				GramCompensation = 150f,
				Calories = 47F,
				Carbohydrate = 6.53F,
				Protein = 1.36F,
				Fat = 1.66F,
				CategoryID = 20
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 427,
				FoodName = "Bezelye Çorbası",
				GramCompensation = 100f,
				Calories = 31F,
				Carbohydrate = 2.07F,
				Protein = 1.68F,
				Fat = 1.73F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 428,
				FoodName = "Ezogelin Çorbası",
				GramCompensation = 150f,
				Calories = 68F,
				Carbohydrate = 8.92F,
				Protein = 2.83F,
				Fat = 1.76F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 429,
				FoodName = "İşkembe Çorbası",
				GramCompensation = 100f,
				Calories = 139F,
				Carbohydrate = 4.93F,
				Protein = 15.14F,
				Fat = 6.35F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 430,
				FoodName = "Kırmızı Mercimek Çorbası",
				GramCompensation = 150f,
				Calories = 68F,
				Carbohydrate = 12.42F,
				Protein = 3.69F,
				Fat = 0.29F,
				CategoryID = 20
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 431,
				FoodName = "Yeşil Mercimek Çorbası",
				GramCompensation = 150f,
				Calories = 121F,
				Carbohydrate = 12.04F,
				Protein = 4.5F,
				Fat = 6.03F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 432,
				FoodName = "Sebze Çorbası",
				GramCompensation = 100f,
				Calories = 44F,
				Carbohydrate = 6.06F,
				Protein = 1F,
				Fat = 1.68F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 433,
				FoodName = "Tarhana Çorbası",
				GramCompensation = 150f,
				Calories = 91F,
				Carbohydrate = 7.48F,
				Protein = 3.45F,
				Fat = 4.93F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 434,
				FoodName = "Yayla Çorbası",
				GramCompensation = 150f,
				Calories = 70F,
				Carbohydrate = 9.71F,
				Protein = 12.19F,
				Fat = 2.41F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 435,
				FoodName = "Tavuk Çorbası",
				GramCompensation = 150f,
				Calories = 83F,
				Carbohydrate = 5.17F,
				Protein = 5.96F,
				Fat = 2.95F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 436,
				FoodName = "Balkabaği Çorbası",
				GramCompensation = 100f,
				Calories = 29F,
				Carbohydrate = 2.41F,
				Protein = 1.87F,
				Fat = 1.19F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 437,
				FoodName = "Mantar Çorbası",
				GramCompensation = 150f,
				Calories = 99F,
				Carbohydrate = 7.36F,
				Protein = 3.06F,
				Fat = 6.37F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 438,
				FoodName = "Kremalı Mantar Çorbası",
				GramCompensation = 150f,
				Calories = 120F,
				Carbohydrate = 5.21F,
				Protein = 1.92F,
				Fat = 11.27F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 439,
				FoodName = "Brokoli Çorbası",
				GramCompensation = 150f,
				Calories = 39F,
				Carbohydrate = 5.06F,
				Protein = 1.37F,
				Fat = 1.47F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 440,
				FoodName = "Paça Çorbası",
				GramCompensation = 150f,
				Calories = 117F,
				Carbohydrate = 0.86F,
				Protein = 18.81F,
				Fat = 4.29F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 441,
				FoodName = "Balik Çorbası",
				GramCompensation = 100f,
				Calories = 49F,
				Carbohydrate = 4.43F,
				Protein = 4.51F,
				Fat = 1.27F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 442,
				FoodName = "Tutmac Çorbası",
				GramCompensation = 100f,
				Calories = 72F,
				Carbohydrate = 7.2F,
				Protein = 3.01F,
				Fat = 3.07F,
				CategoryID = 20
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 443,
				FoodName = "Tutmac Çorbası",
				GramCompensation = 150f,
				Calories = 67F,
				Carbohydrate = 6.51F,
				Protein = 0.87F,
				Fat = 4.16F,
				CategoryID = 20
			});

			// ekmek ve tahıllar
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 444,
				FoodName = "Beyaz Ekmek",
				GramCompensation = 30f,
				Calories = 71F,
				Carbohydrate = 13.17F,
				Protein = 3.2F,
				Fat = 0.65F,
				CategoryID = 21
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 445,
				FoodName = "Tam Buğday Ekmeği",
				GramCompensation = 25f,
				Calories = 63F,
				Carbohydrate = 10.68F,
				Protein = 3.11F,
				Fat = 0.88F,
				CategoryID = 21
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 446,
				FoodName = "Cavdar Ekmeği",
				GramCompensation = 30f,
				Calories = 63F,
				Carbohydrate = 13.15F,
				Protein = 1.81F,
				Fat = 0.27F,
				CategoryID = 21
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 447,
				FoodName = "Kepekli Ekmek",
				GramCompensation = 25f,
				Calories = 54F,
				Carbohydrate = 11.14F,
				Protein = 1.51F,
				Fat = 0.38F,
				CategoryID = 21
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 448,
				FoodName = "Grissini",
				GramCompensation = 5f,
				Calories = 20F,
				Carbohydrate = 3.53F,
				Protein = 0.51F,
				Fat = 0.36F,
				CategoryID = 21
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 449,
				FoodName = "Beyaz Tost Ekmeği",
				GramCompensation = 30f,
				Calories = 76F,
				Carbohydrate = 14.31F,
				Protein = 2.21F,
				Fat = 1F,
				CategoryID = 21
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 450,
				FoodName = "Çok Tahıllı Tost Ekmeği",
				GramCompensation = 28f,
				Calories = 67F,
				Carbohydrate = 11.65F,
				Protein = 3.33F,
				Fat = 0.79F,
				CategoryID = 21
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 451,
				FoodName = "Sandviç Ekmeği",
				GramCompensation = 65f,
				Calories = 178F,
				Carbohydrate = 37.21F,
				Protein = 5.07F,
				Fat = 1.61F,
				CategoryID = 21
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 452,
				FoodName = "Kepekli Sandviç Ekmeği",
				GramCompensation = 70f,
				Calories = 171F,
				Carbohydrate = 31.08F,
				Protein = 6.72F,
				Fat = 1.5F,
				CategoryID = 21
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 453,
				FoodName = "Hamburger Ekmeği",
				GramCompensation = 52f,
				Calories = 142F,
				Carbohydrate = 29.64F,
				Protein = 3.64F,
				Fat = 1.04F,
				CategoryID = 21
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 454,
				FoodName = "Yufka",
				GramCompensation = 160f,
				Calories = 387F,
				Carbohydrate = 80.18F,
				Protein = 10.94F,
				Fat = 1.41F,
				CategoryID = 21
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 455,
				FoodName = "İrmik",
				GramCompensation = 10f,
				Calories = 36F,
				Carbohydrate = 7.28F,
				Protein = 1.27F,
				Fat = 0.11F,
				CategoryID = 21
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 456,
				FoodName = "Mısır Nişastası",
				GramCompensation = 10f,
				Calories = 37F,
				Carbohydrate = 9.06F,
				Protein = 0.02F,
				Fat = 0.08F,
				CategoryID = 21
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 457,
				FoodName = "Galeta Unu",
				GramCompensation = 10f,
				Calories = 40F,
				Carbohydrate = 7.2F,
				Protein = 1.34F,
				Fat = 0.53F,
				CategoryID = 21
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 458,
				FoodName = "Beyaz Un",
				GramCompensation = 10f,
				Calories = 40F,
				Carbohydrate = 8.54F,
				Protein = 0.04F,
				Fat = 0.01F,
				CategoryID = 21
			});

			//Hamur işleri
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 459,
				FoodName = "Peynirli Börek",
				GramCompensation = 75f,
				Calories = 194F,
				Carbohydrate = 25.11F,
				Protein = 7.58F,
				Fat = 6.85F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 460,
				FoodName = "Patatesli Börek",
				GramCompensation = 75f,
				Calories = 204F,
				Carbohydrate = 26.87F,
				Protein = 4.27F,
				Fat = 8.67F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 461,
				FoodName = "Ispanaklı Börek",
				GramCompensation = 75f,
				Calories = 116F,
				Carbohydrate = 21.39F,
				Protein = 4.29F,
				Fat = 2.35F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 462,
				FoodName = "Su Böreği",
				GramCompensation = 75f,
				Calories = 172F,
				Carbohydrate = 18.77F,
				Protein = 5.39F,
				Fat = 8.24F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 463,
				FoodName = "Çiğ Börek",
				GramCompensation = 70f,
				Calories = 264F,
				Carbohydrate = 32.76F,
				Protein = 3.18F,
				Fat = 13.28F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 464,
				FoodName = "Patlıcanlı Börek",
				GramCompensation = 75f,
				Calories = 107F,
				Carbohydrate = 18.43F,
				Protein = 4.05F,
				Fat = 1.08F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 465,
				FoodName = "Bisküvili Pasta",
				GramCompensation = 220f,
				Calories = 361F,
				Carbohydrate = 57.1F,
				Protein = 11.22F,
				Fat = 7.97F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 466,
				FoodName = "Çikolatalı Pasta",
				GramCompensation = 150f,
				Calories = 577F,
				Carbohydrate = 39.56F,
				Protein = 7.44F,
				Fat = 42.85F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 467,
				FoodName = "Meyveli Pasta",
				GramCompensation = 150f,
				Calories = 257F,
				Carbohydrate = 41.5F,
				Protein = 6.38F,
				Fat = 6.09F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 468,
				FoodName = "Muzlu Rulo Pasta",
				GramCompensation = 160f,
				Calories = 286F,
				Carbohydrate = 43.49F,
				Protein = 10.27F,
				Fat = 6.8F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 469,
				FoodName = "Sade Kek",
				GramCompensation = 70f,
				Calories = 241F,
				Carbohydrate = 32.95F,
				Protein = 4.45F,
				Fat = 9.15F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 470,
				FoodName = "Kakaolu Kek",
				GramCompensation = 70f,
				Calories = 268F,
				Carbohydrate = 31.2F,
				Protein = 3.94F,
				Fat = 13.11F,
				CategoryID = 22
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 471,
				FoodName = "Havuclu Kek",
				GramCompensation = 70f,
				Calories = 249F,
				Carbohydrate = 26.91F,
				Protein = 3.84F,
				Fat = 13.36F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 472,
				FoodName = "Portakallı Kek",
				GramCompensation = 70f,
				Calories = 188F,
				Carbohydrate = 28.92F,
				Protein = 3.55F,
				Fat = 5.7F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 473,
				FoodName = "Elmalı Kek",
				GramCompensation = 45f,
				Calories = 153F,
				Carbohydrate = 18.08F,
				Protein = 2.49F,
				Fat = 7.66F,
				CategoryID = 22
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 474,
				FoodName = "Fındıklı Kurabiye",
				GramCompensation = 45f,
				Calories = 238F,
				Carbohydrate = 22.22F,
				Protein = 3.86F,
				Fat = 14.84F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 475,
				FoodName = "Cevizli Kurabiye",
				GramCompensation = 45f,
				Calories = 203F,
				Carbohydrate = 21.61F,
				Protein = 3.69F,
				Fat = 11.38F,
				CategoryID = 22
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 476,
				FoodName = "Çikolatalı Kurabiye",
				GramCompensation = 45f,
				Calories = 210F,
				Carbohydrate = 21.95F,
				Protein = 2.97F,
				Fat = 12.20F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 477,
				FoodName = "Yulafli Fit Kurabiye",
				GramCompensation = 45f,
				Calories = 161F,
				Carbohydrate = 17.65F,
				Protein = 5.48F,
				Fat = 8.68F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 478,
				FoodName = "Kuru Uzumlu Diyet Kurabiye",
				GramCompensation = 45f,
				Calories = 102F,
				Carbohydrate = 19.39F,
				Protein = 3.46F,
				Fat = 1.54F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 479,
				FoodName = "Tuzlu Pastane Kurabiyesi",
				GramCompensation = 30f,
				Calories = 184f,
				Carbohydrate = 19.31F,
				Protein = 3.82F,
				Fat = 10.22F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 480,
				FoodName = "Un Kurabiyesi",
				GramCompensation = 30f,
				Calories = 128f,
				Carbohydrate = 21.06F,
				Protein = 0.18F,
				Fat = 4.67F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 481,
				FoodName = "Kandil Simidi",
				GramCompensation = 35f,
				Calories = 167f,
				Carbohydrate = 14.97F,
				Protein = 2.93F,
				Fat = 60.67F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 482,
				FoodName = "Simit",
				GramCompensation = 100f,
				Calories = 275f,
				Carbohydrate = 57.14F,
				Protein = 10.71F,
				Fat = 3.57F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 483,
				FoodName = "Poğaça",
				GramCompensation = 70f,
				Calories = 243f,
				Carbohydrate = 22.33F,
				Protein = 4.91F,
				Fat = 14.74F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 484,
				FoodName = "Peynirli Poğaça",
				GramCompensation = 70f,
				Calories = 274f,
				Carbohydrate = 21.4F,
				Protein = 6.1F,
				Fat = 18.29F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 485,
				FoodName = "Dereotlu Poğaça",
				GramCompensation = 70f,
				Calories = 234f,
				Carbohydrate = 25.2F,
				Protein = 5.09F,
				Fat = 20.44F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 486,
				FoodName = "Zeytinli Poğaça",
				GramCompensation = 70f,
				Calories = 267f,
				Carbohydrate = 23.97F,
				Protein = 5.06F,
				Fat = 17.27F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 487,
				FoodName = "Patatesli Poğaça",
				GramCompensation = 70f,
				Calories = 230f,
				Carbohydrate = 20.01F,
				Protein = 3.48F,
				Fat = 14.96F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 488,
				FoodName = "Acma",
				GramCompensation = 90f,
				Calories = 341f,
				Carbohydrate = 35.22F,
				Protein = 5.91F,
				Fat = 23.89F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 489,
				FoodName = "Çikolatalı Acma",
				GramCompensation = 75f,
				Calories = 268f,
				Carbohydrate = 36.71F,
				Protein = 5.32F,
				Fat = 10.83F,
				CategoryID = 22
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 490,
				FoodName = "Zeytinli Acma",
				GramCompensation = 90f,
				Calories = 354f,
				Carbohydrate = 31.25F,
				Protein = 5.27F,
				Fat = 22.95F,
				CategoryID = 22
			});


			//kurubaklagiller
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 491,
				FoodName = "Etsiz Kuru Fasulye",
				GramCompensation = 180f,
				Calories = 250f,
				Carbohydrate = 45.16F,
				Protein = 17.51F,
				Fat = 0.63F,
				CategoryID = 23
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 492,
				FoodName = "Etsiz Nohut Yemeği",
				GramCompensation = 200f,
				Calories = 322f,
				Carbohydrate = 41.16F,
				Protein = 11.80F,
				Fat = 0.63F,
				CategoryID = 23
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 493,
				FoodName = "Bezelye Yemeği",
				GramCompensation = 200f,
				Calories = 132f,
				Carbohydrate = 22.42F,
				Protein = 6.15F,
				Fat = 2.39F,
				CategoryID = 23
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 494,
				FoodName = "Mercimek Yemeği",
				GramCompensation = 230f,
				Calories = 164f,
				Carbohydrate = 17.04F,
				Protein = 8.97F,
				Fat = 4.52F,
				CategoryID = 23
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 495,
				FoodName = "Zeytinyağlı Barbunya",
				GramCompensation = 140f,
				Calories = 140f,
				Carbohydrate = 42.83F,
				Protein = 15.99F,
				Fat = 14.14F,
				CategoryID = 23
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 496,
				FoodName = "Meksika Fasulyesi",
				GramCompensation = 180f,
				Calories = 607f,
				Carbohydrate = 110.32F,
				Protein = 40.55F,
				Fat = 1.91F,
				CategoryID = 23
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 497,
				FoodName = "Soya Fasulyesi",
				GramCompensation = 180f,
				Calories = 274f,
				Carbohydrate = 0.31F,
				Protein = 28.31F,
				Fat = 17.79F,
				CategoryID = 23
			});

			//hayvansal yaglar
			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 498,
				FoodName = "İç Yağı",
				GramCompensation = 15f,
				Calories = 135f,
				Carbohydrate = 0f,
				Protein = 0f,
				Fat = 15F,
				CategoryID = 24
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 499,
				FoodName = "Kuyruk Yağı",
				GramCompensation = 14f,
				Calories = 79f,
				Carbohydrate = 0.01F,
				Protein = 0.29F,
				Fat = 8.61F,
				CategoryID = 24
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 500,
				FoodName = "Balık Yağı",
				GramCompensation = 5f,
				Calories = 44f,
				Carbohydrate = 0f,
				Protein = 0f,
				Fat = 4.99F,
				CategoryID = 24
			});

			//bitkisel yağlar 

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 501,
				FoodName = "Ayçiçeği Yağı",
				GramCompensation = 5f,
				Calories = 44f,
				Carbohydrate = 0f,
				Protein = 0f,
				Fat = 5f,
				CategoryID = 25
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 502,
				FoodName = "Fındık Yağı",
				GramCompensation = 4f,
				Calories = 35f,
				Carbohydrate = 0f,
				Protein = 0f,
				Fat = 4f,
				CategoryID = 25
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 503,
				FoodName = "Zeytin Yağı",
				GramCompensation = 4f,
				Calories = 40f,
				Carbohydrate = 0.01F,
				Protein = 0f,
				Fat = 4.5F,
				CategoryID = 25
			});

			//Alkoller 

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 504,
				FoodName = "Beyaz Şarap",
				GramCompensation = 150f,
				Calories = 125,
				Carbohydrate = 3.81F,
				Protein = 0.1F,
				Fat = 0f,
				CategoryID = 26
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 505,
				FoodName = "Kırmızı Şarap",
				GramCompensation = 150f,
				Calories = 125,
				Carbohydrate = 3.85F,
				Protein = 0.1F,
				Fat = 0f,
				CategoryID = 26
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 506,
				FoodName = "Bira",
				GramCompensation = 330f,
				Calories = 139f,
				Carbohydrate = 10.3F,
				Protein = 1.65F,
				Fat = 0f,
				CategoryID = 26
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 507,
				FoodName = "Cin",
				GramCompensation = 100f,
				Calories = 231f,
				Carbohydrate = 0f,
				Protein = 0f,
				Fat = 0f,
				CategoryID = 26
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 508,
				FoodName = "Raki",
				GramCompensation = 100f,
				Calories = 186f,
				Carbohydrate = 0.33F,
				Protein = 0f,
				Fat = 0f,
				CategoryID = 26
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 509,
				FoodName = "Votka",
				GramCompensation = 100f,
				Calories = 116f,
				Carbohydrate = 0f,
				Protein = 0f,
				Fat = 0f,
				CategoryID = 26
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 510,
				FoodName = "Viski",
				GramCompensation = 100f,
				Carbohydrate = 0.06F,
				Protein = 0f,
				Fat = 0f,
				CategoryID = 26
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 511,
				FoodName = "Vişne Likörü",
				GramCompensation = 30f,
				Calories = 131f,
				Carbohydrate = 15.21F,
				Protein = 0f,
				Fat = 0f,
				CategoryID = 26
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 512,
				FoodName = "Portakal Likörü",
				GramCompensation = 30f,
				Calories = 96f,
				Carbohydrate = 7.5F,
				Protein = 0f,
				Fat = 0f,
				CategoryID = 26
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 513,
				FoodName = "Şampanya",
				GramCompensation = 100f,
				Calories = 80f,
				Carbohydrate = 1.47F,
				Protein = 0.32F,
				Fat = 0f,
				CategoryID = 26
			});


			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 514,
				FoodName = "Brandy",
				GramCompensation = 100f,
				Calories = 220f,
				Carbohydrate = 0f,
				Protein = 0f,
				Fat = 0f,
				CategoryID = 26
			});

			modelBuilder.Entity<Food>().HasData(new Food()
			{
				FoodID = 515,
				FoodName = "Tekila",
				GramCompensation = 30f,
				Calories = 138f,
				Carbohydrate = 7.5F,
				Protein = 0f,
				Fat = 0f,
				CategoryID = 26
			});





		}
	}
}
