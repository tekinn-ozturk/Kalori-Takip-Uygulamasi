using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.BaseEntities
{
	public class BaseEntity
	{
		public DateTime CreatedDate { get; set; }= DateTime.Now;
		public DateTime? ModifiedDate { get; set; }
		public DateTime? ModifiedDate2 { get; set; }
		public DateTime? DeletedDate { get; set; }
		public int Value { get; set; } = 1;
		public bool Status { get; set; }
	}
}
