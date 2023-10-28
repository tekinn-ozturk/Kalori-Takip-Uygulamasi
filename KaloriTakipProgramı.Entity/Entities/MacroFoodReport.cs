using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.Entities
{
	public class MacroFoodReport
	{
        public MacroFoodReport()
        {
			Foods = new List<Food>();

		}
		[Key]
        public int ReportID { get; set; }
		public int CaloriesValue { get; set; }
		public int CarbohydrateValue { get; set; }
		public int ProteinValue { get; set; }
		public int FatValue { get; set; }
		public DateTime IssuedDate { get; set; }




        //Navigation Property
		public int AppUserID { get; set; }
		public AppUser AppUser { get; set; }

		public virtual ICollection<Food> Foods { get; set; }

	}
}
