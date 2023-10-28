using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.Abstract
{
	public interface IAppUserService:IGenericService<AppUser>
	{
		bool TIsEmailExist(string email);
		bool TUserExists(string username, string password);
	}
}
