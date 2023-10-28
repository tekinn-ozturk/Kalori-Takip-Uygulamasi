using KaloriTakipProgramı.Business.Abstract;
using KaloriTakipProgramı.Data.Concrete.EntityFramework;
using KaloriTakipProgramı.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.Concrete
{
	public class ConsumeFoodService : IConsumeFoodService
	{
		private ConsumeFoodRepository _consumeFoodRepository;
        public ConsumeFoodService()
        {
            _consumeFoodRepository = new ConsumeFoodRepository();
        }
        public void TAdd(ConsumeFood t)
		{
			_consumeFoodRepository.Add(t);
		}

		public void TDelete(ConsumeFood t)
		{
			_consumeFoodRepository.Delete(t);
		}

		public List<ConsumeFood> TGetAll()
		{
			return _consumeFoodRepository.GetAll();
		}

		public ConsumeFood TGetByFilter(Expression<Func<ConsumeFood, bool>> filter)
		{
			return _consumeFoodRepository.GetByFilter(filter);
		}

		public List<ConsumeFood> TGetByFilterList(Expression<Func<ConsumeFood, bool>> filter)
		{
			return _consumeFoodRepository.GetByFilterList(filter);
		}

		public ConsumeFood TGetByID(int id)
		{
			return _consumeFoodRepository.GetByID(id);
		}

		public void TUpdate(ConsumeFood t)
		{
			_consumeFoodRepository.Update(t);
		}
		public List<ConsumeFood> TGetConsumeFoodByValue(DateTime secilenTarih)
		{
			return _consumeFoodRepository.GetConsumeFoodByValue(secilenTarih);
		}
		public List<ConsumeFood> TGetConsumeFoodByMealID(string mealName, DateTime tarih)
		{
			return _consumeFoodRepository.GetConsumeFoodByMealID(mealName, tarih);
		}
		public List<ConsumeFood> TGetConsumeFood(int id, DateTime tarih)
		{
			return _consumeFoodRepository.GetConsumeFood(id, tarih);
		}
		public ConsumeFood TGetConsumeFood2(int id, DateTime tarih)
		{
			return _consumeFoodRepository.GetConsumeFood2(id, tarih);
		}

		


	}
}
