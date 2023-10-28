using KaloriTakipProgramı.Entity.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.Entities
{
	public class ConsumeFood : BaseEntity
	{
		public ConsumeFood()
		{
			Foods = new List<Food>();
		}
		public int ConsumeFoodID { get; set; }
		public string? ConsumeFoodName { get; set; }
		public float GramCompensation { get; set; }
		public float Calories { get; set; }
		public float Carbohydrate { get; set; }
		public float Protein { get; set; }
		public float Fat { get; set; }
		public string? ImagePath { get; set; } = "Atanmadı";
		public int AppUserID { get; set; }
		public AppUser AppUser { get; set; }
		public  List<Food> Foods { get; set; }

		public int MealID { get; set; }
		public Meal Meal { get; set; }


	}
}
