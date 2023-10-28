using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.Abstract
{
	public interface IFoodService:IGenericService<Food>
	{
		Food TGetFoodWithConsumeFoods(int id);
	}
}
