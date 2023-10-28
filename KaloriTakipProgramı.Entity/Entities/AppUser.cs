using KaloriTakipProgramı.Entity.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.Entities
{
	public class AppUser : BaseEntity
	{

        public AppUser()
        {
		
			MacroFoodReports= new List<MacroFoodReport>();
			Waters = new List<Water>();
			ConsumeFoods = new List<ConsumeFood>();

		}
        [Key]
		public int AppUserID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
		public string Gender { get; set; }
		public string? ImagePath { get; set; } = "Atanmadı";
		public int? Age { get; set; }
		public float? Height { get; set; }
		public float? Weight { get; set; }
		public float? BasinCircle { get; set; }
		public float? NeckCircle { get; set; }
		public float? WaistCircle { get; set; }
		public float? ActivityValue { get; set; }
		public DateTime? LastWaterAdditionDate { get; set; }

		public double? VKI { get; set; }
		public double? VYO { get; set; }
		public double? BMH { get; set; }


		//Navigation Property

		[ForeignKey("AppRole")]
        public virtual int? RoleID { get; set; }
        public AppRole AppRole  { get; set; }

		public  ICollection<Water> Waters { get; set; }

		public  ICollection<MacroFoodReport>? MacroFoodReports { get; set; }
		public  ICollection<ConsumeFood> ConsumeFoods { get; set; }
	}
}
