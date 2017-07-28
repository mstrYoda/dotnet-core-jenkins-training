using System;
using System.Linq;
using System.Linq.Expressions;

namespace WebApiCore.Repositories
{
    public interface IRepository<T> where T : class
    {
		IQueryable<T> GetAll();
		T GetSingle(int fooId);
        T GetSingle(Expression<Func<T, bool>> predicate);
		IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
		void Add(T entity);
		void Delete(T entity);
		void Edit(T entity);
		void Save();
    }
}
