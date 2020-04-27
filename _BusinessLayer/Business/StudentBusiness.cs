using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _BusinessLayer.Repository.Concrete
{
    public class StudentBusiness
    {
        private IDatabaseRepository<Student> _Studentrepository;
        private IUnitOfWork _StudentUnitofwork;
        private DbContext _dbContext;
        public StudentBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _StudentUnitofwork = new PCUnitOfWork(_dbContext);
            _Studentrepository = _StudentUnitofwork.GetRepository<Student>();
        }

        public List<Student> GetStudents()
        {
            return _Studentrepository.GetAll().ToList();
        }
       
        public void Add(Student t)
        {
            _Studentrepository.Insert(t);
            _StudentUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _Studentrepository.Delete(id);
            _StudentUnitofwork.SaveChanges();
        }

        public void Edit(Student t)
        {
            _Studentrepository.Update(t);
            _StudentUnitofwork.SaveChanges();
        }

        public void Delete(Student t)
        {
                _Studentrepository.Delete(t);
                _StudentUnitofwork.SaveChanges();
        }

        public Student Get(int id)
        {
                return _Studentrepository.Get(x=>x.StudentId == id);
        }
        public Student GetByStudentNo(int id)
        {
            return _Studentrepository.Get(x=>x.StudentNo==id);
        }
    }
}
