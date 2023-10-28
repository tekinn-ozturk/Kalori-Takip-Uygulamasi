using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.Entities
{
	public class AppRole
	{
		[Key]
		public int RoleID { get; set; }
		public string RoleName { get; set; }


		//Navigation Property

		public ICollection<AppUser> AppUsers { get; set; }	

	}
}
