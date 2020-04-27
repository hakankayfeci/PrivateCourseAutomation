using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _BusinessLayer.Repository.Concrete
{
    public class RoleBusiness
    {
        private IDatabaseRepository<Role> _Rolerepository;
        private IUnitOfWork _RoleUnitofwork;
        private DbContext _dbContext;
        public RoleBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _RoleUnitofwork = new PCUnitOfWork(_dbContext);
            _Rolerepository = _RoleUnitofwork.GetRepository<Role>();
        }

        public List<Role> GetRoles()
        {
            return _Rolerepository.GetAll().ToList();
        }

        public void Add(Role t)
        {
            _Rolerepository.Insert(t);
            _RoleUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _Rolerepository.Delete(id);
            _RoleUnitofwork.SaveChanges();
        }

        public void Edit(Role t)
        {
            var result = Get(t.RoleId);
            result.RoleId = t.RoleId;
            result.RoleName = t.RoleName;
            _Rolerepository.Update(result);
            _RoleUnitofwork.SaveChanges();
        }

        public void Delete(Role t)
        {
                _Rolerepository.Delete(t);
                _RoleUnitofwork.SaveChanges();
        }

        public Role Get(int id)
        {
                return _Rolerepository.GetById(id);
        }
    }
}
