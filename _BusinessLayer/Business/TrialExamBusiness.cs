using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;
using _DataLayer.ViewModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _BusinessLayer.Repository.Concrete
{
    public class TrialExamBusiness
    {

        private IDatabaseRepository<TrialExam> _TrialExamrepository;
        private IUnitOfWork _TrialExamUnitofwork;
        private DbContext _dbContext;
        public TrialExamBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _TrialExamUnitofwork = new PCUnitOfWork(_dbContext);
            _TrialExamrepository = _TrialExamUnitofwork.GetRepository<TrialExam>();
        }

        public List<TrialExam> GetTrialExams()
        {
            return _TrialExamrepository.GetAll().ToList();
        }

        public void Add(TrialExam t)
        {
            _TrialExamrepository.Insert(t);
            _TrialExamUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _TrialExamrepository.Delete(id);
            _TrialExamUnitofwork.SaveChanges();
        }

        public void Edit(TrialExam t)
        {
            _TrialExamrepository.Update(t);
            _TrialExamUnitofwork.SaveChanges();
        }

        public void Delete(TrialExam t)
        {
                _TrialExamrepository.Delete(t);
                _TrialExamUnitofwork.SaveChanges();
        }

        public TrialExam Get(int id)
        {
            return _TrialExamrepository.Get(x=>x.TrialExamId==id);
        }
        public List<TrialExamViewModel> GetViewTrialExam()
        {
            using (PrivacyCourseDBEntities db = new PrivacyCourseDBEntities())
            {
                var sinavlar = new List<TrialExamViewModel>();
                var result = from te in db.TrialExams
                             join l in db.Lessons on te.LessonId equals l.LessonId
                             select new
                             {
                                 te.TrialExamId,
                                 te.Session,
                                 te.Time,
                                 te.TrialExamName,
                                 te.LessonId,
                                 te.TrialExamDescription,
                                 te.TrialExamResults,
                                 l.LessonName
                             };
                foreach (var sinav in result)
                {
                    sinavlar.Add(new TrialExamViewModel
                    {
                         TrialExamId=sinav.TrialExamId,
                         Session=sinav.Session,
                         Time=sinav.Time,
                         TrialExamName=sinav.TrialExamName,
                         TrialExamDescription=sinav.TrialExamDescription,
                         LessonName=sinav.LessonName
                    });
                }
                return sinavlar;
            }
        }
        public TrialExam Get(string name)
        {
            return _TrialExamrepository.Get(x => x.TrialExamName == name);
        }
    }
}
