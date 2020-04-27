using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _BusinessLayer.Repository.Concrete
{
    public class LessonBusiness
    {
        private IDatabaseRepository<Lesson> _Lessonrepository;
        private IUnitOfWork _LessonUnitofwork;
        private DbContext _dbContext;
        public LessonBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _LessonUnitofwork = new PCUnitOfWork(_dbContext);
            _Lessonrepository = _LessonUnitofwork.GetRepository<Lesson>();
        }

        public List<Lesson> GetLessons()
        {
            return _Lessonrepository.GetAll().ToList();
        }

        public void Add(Lesson t)
        {
            _Lessonrepository.Insert(t);
            _LessonUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _Lessonrepository.Delete(id);
            _LessonUnitofwork.SaveChanges();
        }

        public void Edit(Lesson t)
        {
            Lesson result = Get(t.LessonId);
            result.LessonId = t.LessonId;
            result.LessonName = t.LessonName;
            result.ExamResults = t.ExamResults;
            result.Classes = t.Classes;
            result.TrialExams = t.TrialExams;
            _Lessonrepository.Update(result);
            _LessonUnitofwork.SaveChanges();
        }

        public void Delete(Lesson t)
        {
                _Lessonrepository.Delete(t);
                _LessonUnitofwork.SaveChanges();
        }

        public Lesson Get(int id)
        {
                return _Lessonrepository.GetById(id);
        }
    }
}
