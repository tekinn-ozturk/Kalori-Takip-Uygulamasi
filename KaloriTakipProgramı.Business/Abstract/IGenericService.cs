using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.Abstract
{
	public interface IGenericService<T> 
	{
		void TAdd(T t);
		void TDelete(T t);
		void TUpdate(T t);
		List<T> TGetAll();
		T TGetByID(int id);
		T TGetByFilter(Expression<Func<T, bool>> filter);
		List<T> TGetByFilterList(Expression<Func<T, bool>> filter);
	}
}
