using KaloriTakipProgramı.Data.Context;
using KaloriTakipProgramı.Data.Repositories;
using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Data.Concrete.EntityFramework
{
	public class AppRoleRepository:GenericRepository<AppRole>
	{
		public int GetRoleIdByName(string roleName)
		{
			var role = _context.AppRoles.FirstOrDefault(r => r.RoleName == roleName);
			return role.RoleID;
		}
	}
}
