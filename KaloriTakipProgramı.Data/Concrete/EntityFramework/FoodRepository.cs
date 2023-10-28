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
	public class FoodRepository:GenericRepository<Food>
	{
		public Food GetFoodWithConsumeFoods(int id) 
		{
			return _context.Foods.Include(x => x.ConsumeFoods).First(x => x.FoodID == id);
		
		}

	}
}
