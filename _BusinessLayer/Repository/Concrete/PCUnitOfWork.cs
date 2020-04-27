using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.Repository.Concrete;
using System;
using System.Data.Entity;

namespace _BusinessLayer.UnitOfWork
{
    public class PCUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        private bool disposed = false;
        public PCUnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IDatabaseRepository<T> GetRepository<T>() where T : class
        {
            return new PCRepository<T>(_dbContext);
        }

        public int SaveChanges()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.InnerException.Message);
            }
        }
    }
}
