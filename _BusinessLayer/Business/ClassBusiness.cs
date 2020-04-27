using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;
using _DataLayer.ViewModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _BusinessLayer.Repository.Concrete
{
    public class ClassBusiness
    {
        private IDatabaseRepository<Class> _Classrepository;
        private IUnitOfWork _ClassUnitofwork;
        private DbContext _dbContext;
        public ClassBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _ClassUnitofwork = new PCUnitOfWork(_dbContext);
            _Classrepository = _ClassUnitofwork.GetRepository<Class>();
        }

        public List<Class> GetClasss()
        {
            return _Classrepository.GetAll().ToList();
        }

        public void Add(Class t)
        {
            _Classrepository.Insert(t);
            _ClassUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _Classrepository.Delete(id);
            _ClassUnitofwork.SaveChanges();
        }

        public void Edit(Class t)
        {
            var result = Get(t.ClassId);
            result.ClassId = t.ClassId;
            result.ClassName = t.ClassName;
            result.LessonId = t.LessonId;
            _Classrepository.Update(t);
            _ClassUnitofwork.SaveChanges();
        }

        public void Delete(Class t)
        {
                _Classrepository.Delete(t);
                _ClassUnitofwork.SaveChanges();
        }

        public Class Get(int id)
        {
                return _Classrepository.GetById(id);
        }
        public List<ClassViewModel> GetClassViewModel()
        {
            using (PrivacyCourseDBEntities db = new PrivacyCourseDBEntities())
            {
                var sinavlar = new List<ClassViewModel>();
                var result = from c in db.Classes
                             join l in db.Lessons on c.LessonId equals l.LessonId
                             select new
                             {
                                c.ClassId,
                                c.ClassName,
                                c.LessonId,
                                l.LessonName
                             };
                foreach (var sinav in result)
                {
                    sinavlar.Add(new ClassViewModel
                    {
                        ClassId=sinav.ClassId,
                        ClassName=sinav.ClassName,
                        LessonId=sinav.LessonId,
                        LessonName=sinav.LessonName
                    });
                }
                return sinavlar;
            }
        }
    }
}
