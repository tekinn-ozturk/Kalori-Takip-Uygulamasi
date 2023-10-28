using KaloriTakipProgramı.Entity.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.Entities
{
	public class Water : BaseEntity
	{

		public int WaterID { get; set; }
		public float WaterQuantity { get; set; }
		public DateTime ConsumedDate { get; set; }




		//Navigation Property
		public int AppUserID { get; set; }
		public AppUser AppUser { get; set; }
	}
}
