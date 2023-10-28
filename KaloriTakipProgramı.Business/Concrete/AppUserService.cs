using KaloriTakipProgramı.Business.Abstract;
using KaloriTakipProgramı.Data.Concrete.EF;
using KaloriTakipProgramı.Entity.Entities;
using Microsoft.Data.SqlClient.DataClassification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static KaloriTakipProgramı.Data.Concrete.EF.AppUserRepository;
using static System.Net.Mime.MediaTypeNames;

namespace KaloriTakipProgramı.Business.Concrete
{
	public class AppUserService : IAppUserService
	{
		private readonly AppUserRepository _repository;

        public AppUserService()
        {
            _repository = new AppUserRepository();
        }
        public void TAdd(AppUser appUser)
		{
			_repository.Add(appUser);
		}

		public void TDelete(AppUser t)
		{
			_repository.Delete(t);
		}

		public AppUser TGetByFilter(Expression<Func<AppUser, bool>> filter)
		{
			return _repository.GetByFilter(filter);
		}

		public List<AppUser> TGetByFilterList(Expression<Func<AppUser, bool>> filter)
		{
			return _repository.GetByFilterList(filter);
		}

		public AppUser TGetByID(int id)
		{
			return _repository.GetByID(id);
		}

		public List<AppUser> TGetAll()
		{
			return _repository.GetAll();
		}

		public void TUpdate(AppUser t)
		{
			_repository.Update(t);
		}

		public bool TIsEmailExist(string email)
		{
			if (_repository.IsEmailExist(email))
			{
				return true;
			}
			else 
			{ 
				return false; 
			}
			
		}

		public string SifreyiKodla(string password)
		{
			using (SHA256 hash = SHA256Managed.Create())
			{
				return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
			}
		}
		public bool ArePasswordsMatching(string password, string confirmPassword)
		{
			return password.Equals(confirmPassword);
		}

		public string CheckPasswordStrength(string password)
		{
			bool hasUpperCase = false;
			bool hasLowerCase = false;
			bool hasDigit = false;
			bool hasSpecialChar = false;

			foreach (char character in password)
			{
				if (char.IsUpper(character))
				{
					hasUpperCase = true;
				}
				else if (char.IsLower(character))
				{
					hasLowerCase = true;
				}
				else if (char.IsDigit(character))
				{
					hasDigit = true;
				}
				else if (!char.IsLetterOrDigit(character))
				{
					hasSpecialChar = true;
				}
			}

			if (hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar && password.Length >= 8)
			{
				return "Güçlü Şifre...";
			}
			else if (hasDigit && hasLowerCase && password.Length >= 8)
			{
				return "Orta Seviye...";
			}
			else
			{
				return "Zayıf Şifre...";
			}
		}

		public bool TUserExists(string username, string password)
		{
			return _repository.UserExists(username, password);
		}
		public string AuthenticateUser(string username, string password)
		{
			return _repository.UserAuthenticationResult(username, password);
		}

		public bool BelBoyunKontrol(double bel, double boyun)
		{
			if (boyun >= bel)
			{

				return false;
			}
			else
			{
				return true;
			}
		}

		
	}
}
