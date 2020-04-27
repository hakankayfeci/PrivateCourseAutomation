using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;
using _DataLayer.ViewModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _BusinessLayer.Repository.Concrete
{
    public class ExamResultBusiness
    {
        private IDatabaseRepository<ExamResult> _ExamResultrepository;
        private IUnitOfWork _ExamResultUnitofwork;
        private DbContext _dbContext;
        public ExamResultBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _ExamResultUnitofwork = new PCUnitOfWork(_dbContext);
            _ExamResultrepository = _ExamResultUnitofwork.GetRepository<ExamResult>();
        }

        public List<ExamResult> GetExamResults()
        {
            return _ExamResultrepository.GetAll().ToList();
        }

        public void Add(ExamResult t)
        {
            _ExamResultrepository.Insert(t);
            _ExamResultUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _ExamResultrepository.Delete(id);
            _ExamResultUnitofwork.SaveChanges();
        }

        public void Edit(ExamResult t)
        {
            var result = Get(t.ExamId);
            result.LessonId = t.LessonId;
            result.Notu = t.Notu;
            result.Session = t.Session;
            result.StudentId = t.StudentId;
            result.CharacterNoteId = t.CharacterNoteId;
            _ExamResultrepository.Update(result);
            _ExamResultUnitofwork.SaveChanges();
        }

        public void Delete(ExamResult t)
        {
                _ExamResultrepository.Delete(t);
                _ExamResultUnitofwork.SaveChanges();
        }

        public ExamResult Get(int id)
        {
                return _ExamResultrepository.GetById(id);
        }
        public List<ExamResultViewModel> GetExamResultView()
        {
            using (PrivacyCourseDBEntities db = new PrivacyCourseDBEntities())
            {
                var classlar = new List<ExamResultViewModel>();
                var result = from er in db.ExamResults
                             join l in db.Lessons on er.LessonId equals l.LessonId
                             join s in db.Students on er.StudentId equals s.StudentId
                             join cn in db.CharacterNotes on er.CharacterNoteId equals cn.CharacterNoteId
                             select new
                             {
                                 er.ExamId,
                                 er.Notu,
                                 er.Session,
                                 er.StudentId,
                                 s.Firstname,
                                 cn.Character,
                                 l.LessonName
                             };
                foreach (var sinif in result)
                {
                    classlar.Add(new ExamResultViewModel
                    {
                        ExamId = sinif.ExamId,
                        Notu = sinif.Notu,
                        Session=sinif.Session,
                        Firstname = sinif.Firstname,
                        Character = sinif.Character,
                        LessonName=sinif.LessonName,

                        StudentId = sinif.StudentId,
                    });
                }
                return classlar;
            }
        }
    }
}
