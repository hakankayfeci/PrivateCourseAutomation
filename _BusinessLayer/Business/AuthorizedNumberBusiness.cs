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
    public class AuthorizedNumberBusiness
    {
        private IDatabaseRepository<AuthorizedNumber> _AuthorizedNumberrepository;
        private IUnitOfWork _AuthorizedNumberUnitofwork;
        private DbContext _dbContext;
        public AuthorizedNumberBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _AuthorizedNumberUnitofwork = new PCUnitOfWork(_dbContext);
            _AuthorizedNumberrepository = _AuthorizedNumberUnitofwork.GetRepository<AuthorizedNumber>();
        }

        public List<AuthorizedNumber> GetAuthorizedNumbers()
        {
            return _AuthorizedNumberrepository.GetAll().ToList();
        }

        public void Add(AuthorizedNumber t)
        {
            _AuthorizedNumberrepository.Insert(t);
            _AuthorizedNumberUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _AuthorizedNumberrepository.Delete(id);
            _AuthorizedNumberUnitofwork.SaveChanges();
        }

        public void Edit(AuthorizedNumber t)
        {
            _AuthorizedNumberrepository.Update(t);
            _AuthorizedNumberUnitofwork.SaveChanges();
        }

        public void Delete(AuthorizedNumber t)
        {
                _AuthorizedNumberrepository.Delete(t);
                _AuthorizedNumberUnitofwork.SaveChanges();
        }

        public AuthorizedNumber Get(int id)
        {
                return _AuthorizedNumberrepository.GetById(id);
        }
        public AuthorizedNumber GetByAuthorizeNumber(int? authnumber)
        {
            var Auth = _AuthorizedNumberrepository.Get(x => x.AuthorizeNumber == authnumber);
            return Auth;
        }
        public bool IsVailAuthNumber(int? authnumber)
        {
            var Auth = _AuthorizedNumberrepository.Get(x => x.AuthorizeNumber == authnumber);
            if (Auth != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
