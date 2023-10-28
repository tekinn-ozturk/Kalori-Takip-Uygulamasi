using KaloriTakipProgramı.Business.Abstract;
using KaloriTakipProgramı.Data.Concrete.EntityFramework;
using KaloriTakipProgramı.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.Concrete
{
	public class FoodService : IFoodService
	{
		private readonly FoodRepository _foodRepository;
        public FoodService()
        {
            _foodRepository = new FoodRepository();
        }
        public void TAdd(Food t)
		{
			_foodRepository.Add(t);
		}

		public void TDelete(Food t)
		{
			_foodRepository.Delete(t);
		}

		public List<Food> TGetAll()
		{
			return _foodRepository.GetAll();
		}

		public Food TGetByFilter(Expression<Func<Food, bool>> filter)
		{
			return _foodRepository.GetByFilter(filter);
		}

		public List<Food> TGetByFilterList(Expression<Func<Food, bool>> filter)
		{
			return _foodRepository.GetByFilterList(filter);
		}

		public Food TGetByID(int id)
		{
			return _foodRepository.GetByID(id);
		}

		public void TUpdate(Food t)
		{
			_foodRepository.Update(t);
		}

		public Food GetFoodByID(int id)
		{
			return _foodRepository.GetByFilter(f => f.FoodID == id);
		}

		public Food CalculateFoodInfo(int selectedFoodID, float enteredAmount)
		{
			Food selectedFood = GetFoodByID(selectedFoodID);

			if (selectedFood != null)
			{
				float ratio = enteredAmount / selectedFood.GramCompensation;

				selectedFood.Calories *= ratio;
				selectedFood.Carbohydrate *= ratio;
				selectedFood.Fat *= ratio;
				selectedFood.Protein *= ratio;

				return selectedFood;
			}

			return null;
		}

		public Food TGetFoodWithConsumeFoods(int id)
		{
			return _foodRepository.GetFoodWithConsumeFoods(id);
		}
	}
}
