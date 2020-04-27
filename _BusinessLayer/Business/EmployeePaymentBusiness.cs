using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;
using _DataLayer.ViewModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _BusinessLayer.Repository.Concrete
{
    public class EmployeePaymentBusiness
    {
        private IDatabaseRepository<EmployeePayment> _EmployeePaymentrepository;
        private IUnitOfWork _EmployeePaymentUnitofwork;
        private DbContext _dbContext;
        public EmployeePaymentBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _EmployeePaymentUnitofwork = new PCUnitOfWork(_dbContext);
            _EmployeePaymentrepository = _EmployeePaymentUnitofwork.GetRepository<EmployeePayment>();
        }

        public List<EmployeePayment> GetEmployeePayments()
        {
            return _EmployeePaymentrepository.GetAll().ToList();
        }

        public void Add(EmployeePayment t)
        {
            _EmployeePaymentrepository.Insert(t);
            _EmployeePaymentUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _EmployeePaymentrepository.Delete(id);
            _EmployeePaymentUnitofwork.SaveChanges();
        }

        public void Edit(EmployeePayment t)
        {
            EmployeePayment result = Get(t.EmployeePaymentId);
            result.Maaslar = t.Maaslar;
            result.RoleId= t.RoleId;
            _EmployeePaymentrepository.Update(result);
            _EmployeePaymentUnitofwork.SaveChanges();
        }

        public void Delete(EmployeePayment t)
        {
                _EmployeePaymentrepository.Delete(t);
                _EmployeePaymentUnitofwork.SaveChanges();
        }

        public EmployeePayment Get(int id)
        {
                return _EmployeePaymentrepository.GetById(id);
        }
        public List<PaymentViewModel> GetViewEmployeePayments()
        {
            using (PrivacyCourseDBEntities db = new PrivacyCourseDBEntities())
            {
                var classlar = new List<PaymentViewModel>();
                var result = from ep in db.EmployeePayments
                             join r in db.Roles on ep.RoleId equals r.RoleId
                             select new
                             {
                                ep.EmployeePaymentId,
                                ep.Maaslar,
                                ep.RoleId,
                                r.RoleName
                             };
                foreach (var sinif in result)
                {
                    classlar.Add(new PaymentViewModel
                    {
                       EmployeePaymentId=sinif.EmployeePaymentId,
                       Maaslar=sinif.Maaslar,
                       RoleName=sinif.RoleName,
                       RoleId=sinif.RoleId
                    });
                }
                return classlar;
            }
        }
    }
}
