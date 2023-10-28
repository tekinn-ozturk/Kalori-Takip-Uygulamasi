using KaloriTakipProgramı.Data.Abstract;
using KaloriTakipProgramı.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Data.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		protected readonly AppDbContext _context;

		public GenericRepository()
		{
			_context = new AppDbContext();
		}

		public void Add(T t)
		{
			_context.Add(t);
			_context.SaveChanges();
		}

		public void Delete(T t)
		{
			_context.Remove(t);
			_context.SaveChanges();
		}

		public T GetByFilter(Expression<Func<T, bool>> filter)
		{
			return _context.Set<T>().First(filter);

		}

		public List<T> GetByFilterList(Expression<Func<T, bool>> filter)
		{
			return _context.Set<T>().Where(filter).ToList();
		}

		public T GetByID(int id)
		{
			return _context.Set<T>().Find(id);
		}

		public List<T> GetAll()
		{
			return _context.Set<T>().ToList();
		}

		public void Update(T t)
		{
			_context.Update(t);
			_context.SaveChanges();
		}
	}
}
