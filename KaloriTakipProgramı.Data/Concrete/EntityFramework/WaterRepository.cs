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
	public class WaterRepository:GenericRepository<Water>
	{
	public Water GetWaterByUserIdAndDate(int userId, DateTime tarih)
		{
			var entity = _context.Waters.FirstOrDefault(x => x.AppUserID == userId && x.ModifiedDate2.Value.Date == tarih.Date);
			if (entity != null)
			{
				return entity;
			}
			else
			{
				return null;
			}
			
		}
	}
}
