using KaloriTakipProgramı.Data.Context;
using KaloriTakipProgramı.Data.Repositories;
using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Data.Concrete.EntityFramework
{
	public class MealRepository:GenericRepository<Meal>
	{
		public Meal GetByMealIDBreakfast()
		{
			var meal = _context.Meals.FirstOrDefault(x => x.MealName == "Sabah");
			return meal;

		}
		public Meal GetByMealIDBrunch()
		{
			var meal = _context.Meals.FirstOrDefault(x => x.MealName == "Öğle");
			return meal;
		}
		public Meal GetByMealIDDinner()
		{
			var meal = _context.Meals.FirstOrDefault(x => x.MealName == "Akşam");
			return meal;

		}
		public Meal GetByMealIDSnack()
		{
			var meal = _context.Meals.FirstOrDefault(x => x.MealName == "Aperatif");
			return meal;

		}
	}
}
