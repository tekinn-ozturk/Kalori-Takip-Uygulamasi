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
	public class MealService : IMealService
	{
		private readonly MealRepository _MealRepository;
		public MealService()
		{
			_MealRepository = new MealRepository();
		}

		public Meal TGetByMealIDBreakfast()
		{
			return _MealRepository.GetByMealIDBreakfast();
		}

		public Meal TGetByMealIDBrunch()
		{
			return _MealRepository.GetByMealIDBrunch() ;
		}

		public Meal TGetByMealIDDinner()
		{
			return _MealRepository.GetByMealIDDinner();
		}

		public Meal TGetByMealIDSnack()
		{
			return _MealRepository.GetByMealIDSnack();
		}

		public void TAdd(Meal t)
		{
			_MealRepository.Add(t);
		}

		public void TDelete(Meal t)
		{
			_MealRepository.Delete(t);
		}

		public List<Meal> TGetAll()
		{
			return _MealRepository.GetAll();
		}

		public Meal TGetByFilter(Expression<Func<Meal, bool>> filter)
		{
			return _MealRepository.GetByFilter(filter);
		}

		public List<Meal> TGetByFilterList(Expression<Func<Meal, bool>> filter)
		{
			return _MealRepository.GetByFilterList(filter);
		}

		public Meal TGetByID(int id)
		{
			return _MealRepository.GetByID(id);
		}

		public void TUpdate(Meal t)
		{
			_MealRepository.Update(t);
		}
		


	}
}
