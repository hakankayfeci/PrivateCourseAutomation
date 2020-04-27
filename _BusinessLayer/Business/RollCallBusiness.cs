using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;
using _DataLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer.Business
{
    public class RollCallBusiness
    {
        private IDatabaseRepository<RollCall> _Rollcallrepository;
        private IUnitOfWork _RollcallUnitofwork;
        private DbContext _dbContext;
        public RollCallBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _RollcallUnitofwork = new PCUnitOfWork(_dbContext);
            _Rollcallrepository = _RollcallUnitofwork.GetRepository<RollCall>();
        }

        public List<RollCall> GetRollCalls()
        {
            return _Rollcallrepository.GetAll().ToList();
        }

        public void Add(RollCall t)
        {
            _Rollcallrepository.Insert(t);
            _RollcallUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _Rollcallrepository.Delete(id);
            _RollcallUnitofwork.SaveChanges();
        }

        public void Edit(RollCall t)
        {
            var result = GetByUserId(t.RollCallId);
            result.RollCallId = t.RollCallId;
            result.NumberOfDays = t.NumberOfDays;
            result.StudentId = t.StudentId;
            _Rollcallrepository.Update(result);
            _RollcallUnitofwork.SaveChanges();
        }

        public void Delete(RollCall t)
        {
            _Rollcallrepository.Delete(t);
            _RollcallUnitofwork.SaveChanges();
        }

        public RollCall Get(int id)
        {
            return _Rollcallrepository.GetById(id);
        }
        public void Less(int id, int sayi)
        {
            var deger =_Rollcallrepository.GetById(id);
            deger.NumberOfDays-=sayi;
            Edit(deger);
        }
        public void More(int id,int sayi)
        {
            var deger = _Rollcallrepository.GetById(id);
            deger.NumberOfDays+=sayi;
            Edit(deger);
        }
        public RollCall GetByUserId(int id)
        {
            return _Rollcallrepository.Get(x => x.RollCallId == id);
        }
        public List<RollCallViewModel> GetRollCallViewModels()
        {
            using (PrivacyCourseDBEntities db = new PrivacyCourseDBEntities())
            {
                var results = new List<RollCallViewModel>();
                var result = from rc in db.RollCalls
                             join s in db.Students on rc.StudentId equals s.StudentId
                             select new
                             {
                                 rc.StudentId,
                                 rc.NumberOfDays,
                                 rc.RollCallId,
                                 s.Firstname
                             };
                foreach (var item in result)
                {
                    results.Add(new RollCallViewModel
                    {
                        StudentId=item.StudentId,
                        RollCallId=item.RollCallId,
                        StudentName=item.Firstname,
                        NumberOfDays=item.NumberOfDays
                    });
                }
                return results;
            }
        }

    }
}
