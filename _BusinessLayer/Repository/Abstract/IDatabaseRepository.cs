using System;
using System.Linq;
using System.Linq.Expressions;

namespace _BusinessLayer.Repository.Abstract
{
    public interface IDatabaseRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        T Get(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
