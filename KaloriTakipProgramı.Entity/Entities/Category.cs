using KaloriTakipProgramı.Entity.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.Entities
{
	public class Category:BaseEntity
	{
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        //Navigation Property
        public ICollection<Food> Foods { get; set;}
    }
}
