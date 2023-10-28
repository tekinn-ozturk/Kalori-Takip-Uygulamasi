using KaloriTakipProgramı.Data.Abstract;
using KaloriTakipProgramı.Data.Context;
using KaloriTakipProgramı.Data.Repositories;
using KaloriTakipProgramı.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Data.Concrete.EntityFramework
{
	public class ConsumeFoodRepository : GenericRepository<ConsumeFood> 
	{

		public List<ConsumeFood> GetConsumeFoodByValue(DateTime secilenTarih)
		{
			return _context.ConsumeFoods.Where(x => x.CreatedDate.Date == secilenTarih.Date).ToList();
		}
		public List<ConsumeFood> GetConsumeFoodByMealID(string mealName, DateTime tarih)
		{
			return _context.ConsumeFoods.Where(x => x.Meal.MealName == mealName && x.CreatedDate.Date == tarih.Date).ToList();
		}
		public List<ConsumeFood> GetConsumeFood(int id, DateTime tarih)
		{
			return _context.ConsumeFoods.Where(x => x.Meal.MealID == id && x.CreatedDate.Date == tarih.Date).ToList();
		}
		public ConsumeFood GetConsumeFood2(int id, DateTime tarih)
		{
			return _context.ConsumeFoods.OrderBy(x => x.CreatedDate).LastOrDefault(x => x.Meal.MealID == id && x.CreatedDate.Date == tarih.Date);
		}

		#region Haftalık Ogun İçin
		public List<Meal> HaftalıkBazdaOgunRaporu(DateTime dateTime)
		{
			DateTime startTime = dateTime.AddDays(-7).Date;
			DateTime endTime = dateTime.Date;
			return _context.ConsumeFoods.Include(cf => cf.Meal).Where(x => x.CreatedDate >= startTime && x.CreatedDate <= endTime)
						.GroupBy(cf => cf.Meal.MealName)
						.Select(g => new Meal
						{
							MealName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		public List<Meal> HaftalıkBazdaOgunRaporuKullanıcıİle(int ID, DateTime dateTime)
		{
			DateTime startTime = dateTime.AddDays(-7).Date;
			DateTime endTime = dateTime.Date;
			return _context.ConsumeFoods.Include(cf => cf.Meal).Where(x => x.AppUserID == ID && x.CreatedDate >= startTime && x.CreatedDate <= endTime)
						.GroupBy(cf => cf.Meal.MealName)
						.Select(g => new Meal
						{
							MealName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		#endregion
		#region Aylık Ogunler İçin
		public List<Meal> AylıkBazdaOgunRaporu(DateTime dateTime)
		{
			DateTime endTime = dateTime.Date;
			return _context.ConsumeFoods.Include(cf => cf.Meal).Where(x => x.CreatedDate.Month == endTime.Month)
						.GroupBy(cf => cf.Meal.MealName)
						.Select(g => new Meal
						{
							MealName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		public List<Meal> AylıkBazdaOgunRaporuKullanıcıİle(int ID, DateTime dateTime)
		{
			DateTime endTime = dateTime.Date;
			return _context.ConsumeFoods.Include(cf => cf.Meal).Where(x => x.AppUserID == ID && x.CreatedDate.Month == endTime.Month)
						.GroupBy(cf => cf.Meal.MealName)
						.Select(g => new Meal
						{
							MealName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		#endregion

		#region Haftalık Kategori İçin
		public List<CategoryReport> HaftalıkBazdaKategoriRaporuKullaniciİle(int userId, DateTime dateTime)
		{
			DateTime startTime = dateTime.AddDays(-7).Date;
			DateTime endTime = dateTime.Date;
			List<CategoryReport> categoryReports = _context.ConsumeFoods
				.Where(cf => cf.AppUserID == userId && cf.CreatedDate >= startTime && cf.CreatedDate <= endTime)
				.Join(_context.Foods, cf => cf.ConsumeFoodID, f => f.FoodID, (cf, f) => new { ConsumeFood = cf, Food = f })
				.Join(_context.Categories, joined => joined.Food.CategoryID, c => c.CategoryID, (joined, c) => new { Category = c, Joined = joined })
				.GroupBy(joined => joined.Category.CategoryName)
				.Select(group => new CategoryReport
				{
					CategoryName = group.Key,
					TotalCalories = group.Sum(joined => joined.Joined.ConsumeFood.Calories),
					TotalProtein = group.Sum(joined => joined.Joined.ConsumeFood.Protein),
					TotalCarbohydrate = group.Sum(joined => joined.Joined.ConsumeFood.Carbohydrate),
					TotalFat = group.Sum(joined => joined.Joined.ConsumeFood.Fat)
				})
				.ToList();

			return categoryReports;
		}

		public List<CategoryReport> HaftalıkBazdaKategoriRaporu( DateTime dateTime)
		{
			DateTime startTime = dateTime.AddDays(-7).Date;
			DateTime endTime = dateTime.Date;
			List<CategoryReport> categoryReports = _context.ConsumeFoods
				.Where(cf => cf.CreatedDate >= startTime && cf.CreatedDate <= endTime)
				.Join(_context.Foods, cf => cf.ConsumeFoodID, f => f.FoodID, (cf, f) => new { ConsumeFood = cf, Food = f })
				.Join(_context.Categories, joined => joined.Food.CategoryID, c => c.CategoryID, (joined, c) => new { Category = c, Joined = joined })
				.GroupBy(joined => joined.Category.CategoryName)
				.Select(group => new CategoryReport
				{
					CategoryName = group.Key,
					TotalCalories = group.Sum(joined => joined.Joined.ConsumeFood.Calories),
					TotalProtein = group.Sum(joined => joined.Joined.ConsumeFood.Protein),
					TotalCarbohydrate = group.Sum(joined => joined.Joined.ConsumeFood.Carbohydrate),
					TotalFat = group.Sum(joined => joined.Joined.ConsumeFood.Fat)
				})
				.ToList();

			return categoryReports;
		}
		#endregion

		#region Aylık Kategori
		public List<CategoryReport> AylıkBazdaKategoriRaporu(DateTime dateTime)
		{
			DateTime endTime = dateTime.Date;
			List<CategoryReport> categoryReports = _context.ConsumeFoods
				.Where(cf => cf.CreatedDate.Month == endTime.Month)
				.Join(_context.Foods, cf => cf.ConsumeFoodID, f => f.FoodID, (cf, f) => new { ConsumeFood = cf, Food = f })
				.Join(_context.Categories, joined => joined.Food.CategoryID, c => c.CategoryID, (joined, c) => new { Category = c, Joined = joined })
				.GroupBy(joined => joined.Category.CategoryName)
				.Select(group => new CategoryReport
				{
					CategoryName = group.Key,
					TotalCalories = group.Sum(joined => joined.Joined.ConsumeFood.Calories),
					TotalProtein = group.Sum(joined => joined.Joined.ConsumeFood.Protein),
					TotalCarbohydrate = group.Sum(joined => joined.Joined.ConsumeFood.Carbohydrate),
					TotalFat = group.Sum(joined => joined.Joined.ConsumeFood.Fat)
				})
				.ToList();

			return categoryReports;
		}
		public List<CategoryReport> AylıkBazdaKategoriRaporuKullanıcıİle(int userId, DateTime dateTime)
		{
			DateTime endTime = dateTime.Date;
			List<CategoryReport> categoryReports = _context.ConsumeFoods
				.Where(cf =>cf.AppUserID == userId && cf.CreatedDate.Month == endTime.Month)
				.Join(_context.Foods, cf => cf.ConsumeFoodID, f => f.FoodID, (cf, f) => new { ConsumeFood = cf, Food = f })
				.Join(_context.Categories, joined => joined.Food.CategoryID, c => c.CategoryID, (joined, c) => new { Category = c, Joined = joined })
				.GroupBy(joined => joined.Category.CategoryName)
				.Select(group => new CategoryReport
				{
					CategoryName = group.Key,
					TotalCalories = group.Sum(joined => joined.Joined.ConsumeFood.Calories),
					TotalProtein = group.Sum(joined => joined.Joined.ConsumeFood.Protein),
					TotalCarbohydrate = group.Sum(joined => joined.Joined.ConsumeFood.Carbohydrate),
					TotalFat = group.Sum(joined => joined.Joined.ConsumeFood.Fat)
				})
				.ToList();

			return categoryReports;
		}
		#endregion



	}
}
