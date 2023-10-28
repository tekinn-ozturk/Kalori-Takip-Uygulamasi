using KaloriTakipProgramı.Entity.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.Entities
{
	public class Meal:BaseEntity
	{
        public Meal()
        {
			ConsumeFoods= new List<ConsumeFood>();


		}
        //Sabah Öğle Akşam Aperatif
        public int MealID { get; set; }
		public string MealName { get; set; }
		public List<ConsumeFood> ConsumeFoods { get; set; }


		public override string ToString()
		{
			return $"{MealName}";
		}

	}
}
