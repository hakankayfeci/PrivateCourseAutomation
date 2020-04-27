using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;
using _DataLayer.ViewModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _BusinessLayer.Repository.Concrete
{
    public class TrialExamResultBusiness
    {
        private IDatabaseRepository<TrialExamResult> _trialexamresultrepository;
        private IUnitOfWork _trialexamresultUnitofwork;
        private DbContext _dbContext;
        public TrialExamResultBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _trialexamresultUnitofwork = new PCUnitOfWork(_dbContext);
            _trialexamresultrepository = _trialexamresultUnitofwork.GetRepository<TrialExamResult>();
        }

        public List<TrialExamResult> GetTrialExamResults()
        {
            return _trialexamresultrepository.GetAll().ToList();
        }

        public void Add(TrialExamResult t)
        {
            _trialexamresultrepository.Insert(t);
            _trialexamresultUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _trialexamresultrepository.Delete(id);
            _trialexamresultUnitofwork.SaveChanges();
        }

        public void Edit(TrialExamResult t)
        {
            _trialexamresultrepository.Update(t);
            _trialexamresultUnitofwork.SaveChanges();
        }

        public void Delete(TrialExamResult t)
        {
                _trialexamresultrepository.Delete(t);
                _trialexamresultUnitofwork.SaveChanges();
        }

        public TrialExamResult Get(int id)
        {
             return _trialexamresultrepository.GetById(id);
        }
        public List<TrialExamResultViewModel> GetViewTrialExamResult()
        {
            using (PrivacyCourseDBEntities db = new PrivacyCourseDBEntities())
            {
                var sinavlar = new List<TrialExamResultViewModel>();
                var result = from ter in db.TrialExamResults
                             join te in db.TrialExams on ter.TrialExamId equals te.TrialExamId
                             join s in db.Students on ter.StudentId equals s.StudentId
                             join cn in db.CharacterNotes on ter.CharacterNoteId equals cn.CharacterNoteId
                             select new
                             {
                                 ter.TrialExamResultId,
                                 ter.Notu,
                                 te.TrialExamName,
                                 s.Firstname,
                                 cn.Character,
                                 s.StudentId
                             };
                foreach (var sinav in result)
                {
                    sinavlar.Add(new TrialExamResultViewModel
                    {
                        TrialExamResultId=sinav.TrialExamResultId,
                        Notu=sinav.Notu,
                        Firstname=sinav.Firstname,
                        TrialExamName=sinav.TrialExamName,
                        Character=sinav.Character,
                        StudentId=sinav.StudentId
                    });
                }
                return sinavlar;
            }
        }
    }
}
