using _BusinessLayer.Repository.Abstract;
using System;

namespace _BusinessLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDatabaseRepository<T> GetRepositorys<T>() where T : class;

        int SaveChanges();
    }
}
