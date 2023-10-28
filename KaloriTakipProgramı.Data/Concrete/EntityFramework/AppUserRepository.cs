using KaloriTakipProgramı.Data.Context;
using KaloriTakipProgramı.Data.Repositories;
using KaloriTakipProgramı.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Data.Concrete.EF
{
	public class AppUserRepository : GenericRepository<AppUser>
	{

		public bool IsEmailExist(string email)
		{
			var user = _context.AppUsers.Any(x => x.Email == email);
			return user;
		}

		public bool UserExists(string username, string password)
		{

			var user = _context.AppUsers.SingleOrDefault(u => u.Username == username && u.Password == password);

			return user != null;
		}
		public string UserAuthenticationResult(string username, string password)
		{
			var userExists = _context.AppUsers.FirstOrDefault(u => u.Username == username);

			if (userExists != null)
			{
				if (userExists.Password == password)
				{
					return "Giriş Başarılı";
				}
				else
				{
					return "Şifre Yanlış";
				}
			}
			else
			{
				return "Kullanıcı Bulunamadı";
			}
		}



	}
}
