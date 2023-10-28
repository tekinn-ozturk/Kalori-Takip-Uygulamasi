using KaloriTakipProgramı.Business.Abstract;
using KaloriTakipProgramı.Data.Concrete.EF;
using KaloriTakipProgramı.Data.Concrete.EntityFramework;
using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.Concrete
{
	public class AppRoleService
	{
		private readonly AppRoleRepository _repository;
        public AppRoleService()
        {
            _repository = new AppRoleRepository();
        }
		public AppRole TGetByFilter(Expression<Func<AppRole, bool>> filter)
		{
			return _repository.GetByFilter(filter);
		}
		public int TGetRoleIDByName(string roleName)
		{
			return _repository.GetRoleIdByName(roleName);
		}

	}
}
