using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Data.Abstract
{
	public interface IGenericRepository<T> where T : class
	{
		void Add(T t);
		void Delete(T t);
		void Update(T t);
		List<T> GetAll();
		T GetByID(int id);
		T GetByFilter(Expression<Func<T, bool>> filter);
		List<T> GetByFilterList(Expression<Func<T, bool>> filter);
	}
}
