using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer.Business
{
    public class UserAuthorizedBusiness
    {
        private IDatabaseRepository<UserAuthorize> _UserAuthorizerepository;
        private IUnitOfWork _UserAuthorizeUnitofwork;
        private DbContext _dbContext;
        public UserAuthorizedBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _UserAuthorizeUnitofwork = new PCUnitOfWork(_dbContext);
            _UserAuthorizerepository = _UserAuthorizeUnitofwork.GetRepository<UserAuthorize>();
        }

        public List<UserAuthorize> GetUserAuthorizes()
        {
            return _UserAuthorizerepository.GetAll().ToList();
        }

        public void Add(UserAuthorize t)
        {
            _UserAuthorizerepository.Insert(t);
            _UserAuthorizeUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _UserAuthorizerepository.Delete(id);
            _UserAuthorizeUnitofwork.SaveChanges();
        }

        public void Edit(UserAuthorize t)
        {
            _UserAuthorizerepository.Update(t);
            _UserAuthorizeUnitofwork.SaveChanges();
        }

        public void Delete(UserAuthorize t)
        {
             _UserAuthorizerepository.Delete(t);
             _UserAuthorizeUnitofwork.SaveChanges();
        }

        public UserAuthorize Get(int id)
        {
             return _UserAuthorizerepository.GetById(id);
        }
        public UserAuthorize GetByUserId(Guid id)
        {
            return _UserAuthorizerepository.Get(x=>x.UserId==id);
        }

    }
}