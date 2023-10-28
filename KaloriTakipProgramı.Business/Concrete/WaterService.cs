using KaloriTakipProgramı.Business.Abstract;
using KaloriTakipProgramı.Data.Concrete.EntityFramework;
using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.Concrete
{
	public class WaterService : IWaterService
	{
		private readonly WaterRepository _waterRepository;
        public WaterService()
        {
            _waterRepository = new WaterRepository();
        }
        public void TAdd(Water t)
		{
			_waterRepository.Add(t);
		}

		public void TDelete(Water t)
		{
			_waterRepository.Delete(t);
		}

		public List<Water> TGetAll()
		{
			return _waterRepository.GetAll();
		}

		public Water TGetByFilter(Expression<Func<Water, bool>> filter)
		{
			return _waterRepository.GetByFilter(filter);
		}

		public List<Water> TGetByFilterList(Expression<Func<Water, bool>> filter)
		{
			return _waterRepository.GetByFilterList(filter);
		}

		public Water TGetByID(int id)
		{
			return _waterRepository.GetByID(id);
		}

		public void TUpdate(Water t)
		{
			_waterRepository.Update(t);
		}
		public Water TGetWaterByUserIdAndDate(int userId, DateTime tarih)
		{
			return _waterRepository.GetWaterByUserIdAndDate(userId, tarih);
			
		}
	}
}
