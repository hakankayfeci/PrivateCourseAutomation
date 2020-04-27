using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _BusinessLayer.Repository.Concrete
{
    public class EmployeeExpensBusiness
    {
        private IDatabaseRepository<EmployeeExpens> _EmployeeExpensrepository;
        private IUnitOfWork _EmployeeExpensUnitofwork;
        private DbContext _dbContext;
        public EmployeeExpensBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _EmployeeExpensUnitofwork = new PCUnitOfWork(_dbContext);
            _EmployeeExpensrepository = _EmployeeExpensUnitofwork.GetRepository<EmployeeExpens>();
        }

        public List<EmployeeExpens> GetEmployeeExpenss()
        {
            return _EmployeeExpensrepository.GetAll().ToList();
        }

        public void Add(EmployeeExpens t)
        {
            _EmployeeExpensrepository.Insert(t);
            _EmployeeExpensUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _EmployeeExpensrepository.Delete(id);
            _EmployeeExpensUnitofwork.SaveChanges();
        }

        public void Edit(EmployeeExpens t)
        {
            EmployeeExpens result = Get(t.EmployeeExpensesId);
            result.EmployeeExpensesId = t.EmployeeExpensesId;
            result.Name = t.Name;
            result.Price = t.Price;
            result.Description = t.Description;
            _EmployeeExpensrepository.Update(result);
            _EmployeeExpensUnitofwork.SaveChanges();
        }


        public void Delete(EmployeeExpens t)
        {
                _EmployeeExpensrepository.Delete(t);
                _EmployeeExpensUnitofwork.SaveChanges();
        }

        public EmployeeExpens Get(int id)
        {
                return _EmployeeExpensrepository.Get(x=>x.EmployeeExpensesId==id);
        }
    }
}
