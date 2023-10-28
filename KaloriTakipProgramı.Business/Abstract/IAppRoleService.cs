using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.Abstract
{
	public interface IAppRoleService:IGenericService<AppRole>
	{
		int TGetRoleIDByName(string roleName);
	}
}
