using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;
using _DataLayer.ViewModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _BusinessLayer.Repository.Concrete
{
    public class EmployeeBusiness
    {
        private IDatabaseRepository<Employee> _Employeerepository;
        private IUnitOfWork _EmployeeUnitofwork;
        private DbContext _dbContext;
        public EmployeeBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _EmployeeUnitofwork = new PCUnitOfWork(_dbContext);
            _Employeerepository = _EmployeeUnitofwork.GetRepository<Employee>();
        }

        public List<Employee> GetEmployees()
        {
            return _Employeerepository.GetAll().ToList();
        }

        public void Add(Employee t)
        {
            _Employeerepository.Insert(t);
            _EmployeeUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _Employeerepository.Delete(id);
            _EmployeeUnitofwork.SaveChanges();
        }

        public void Edit(Employee t)
        {
            Employee emp = Get(t.EmployeeId);
            emp.Firstname = t.Firstname;
            emp.Lastname = t.Lastname;
            emp.AuthorizeNumberId = t.AuthorizeNumberId;
            emp.AuthorizedNumber = t.AuthorizedNumber;
            emp.Birthday = t.Birthday;
            emp.Email = t.Email;
            emp.EmployeeId = t.EmployeeId;
            emp.IdentityNo = t.IdentityNo;
            emp.LowerEmail = t.LowerEmail;
            emp.Phone = t.Phone;
            emp.RoleId = t.RoleId;

            _Employeerepository.Update(emp);
            _EmployeeUnitofwork.SaveChanges();
        }

        public void Delete(Employee t)
        {
                _Employeerepository.Delete(t);
                _EmployeeUnitofwork.SaveChanges();
        }

        public Employee Get(int id)
        {
                return _Employeerepository.GetById(id);
        }
        public List<EmployeeViewModel> GetPersonelViewModel()
        {
            using (PrivacyCourseDBEntities db = new PrivacyCourseDBEntities())
            {
                var personals = new List<EmployeeViewModel>();
                var result = from e in db.Employees
                             join r in db.Roles on e.RoleId equals r.RoleId
                             join an in db.AuthorizedNumbers on e.AuthorizeNumberId equals an.AuthorizeNumberId
                             select new
                             {
                                 e.EmployeeId,
                                 e.Firstname,
                                 e.Lastname,
                                 e.IdentityNo,
                                 e.Phone,
                                 e.Email,
                                 e.Birthday,
                                 e.RoleId,
                                 e.AuthorizeNumberId,
                                 r.RoleName,
                                 an.AuthorizeNumber
                             };
                foreach (var personel in result)
                {
                    personals.Add(new EmployeeViewModel
                    {
                        EmployeeId=personel.EmployeeId,
                        Firstname=personel.Firstname,
                        Lastname=personel.Lastname,
                        IdentityNo=personel.IdentityNo,
                        Birthday=personel.Birthday,
                        Email=personel.Email,
                        Phone=personel.Phone,
                        RoleName=personel.RoleName,
                        AuthorizeNumber=personel.AuthorizeNumber
                    });
                }
                return personals;
            }
        }
    }
}
