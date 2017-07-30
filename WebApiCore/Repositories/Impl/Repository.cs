using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WebApiCore.Models;

namespace WebApiCore.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        MyContext dataContext;
        DbSet<T> dbSet;

        public Repository(MyContext context)
        {
            dataContext = context;
            dbSet = dataContext.Set<T>();
        }

        public void Add(T entity)
        {
            dataContext.Add(entity);
        }

        public void Delete(T entity)
        {
            dataContext.Remove(entity);
        }

        public void Edit(T entity)
        {
            dataContext.Update(entity);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetSingle(int fooId)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            dataContext.SaveChanges();
        }
    }
}
