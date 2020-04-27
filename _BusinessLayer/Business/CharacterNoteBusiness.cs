using _BusinessLayer.Repository.Abstract;
using _BusinessLayer.UnitOfWork;
using _DataLayer.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _BusinessLayer.Repository.Concrete
{
    public class CharacterNoteBusiness
    {
        private IDatabaseRepository<CharacterNote> _CharacterNoterepository;
        private IUnitOfWork _CharacterNoteUnitofwork;
        private DbContext _dbContext;
        public CharacterNoteBusiness()
        {
            _dbContext = new PrivacyCourseDBEntities();
            _CharacterNoteUnitofwork = new PCUnitOfWork(_dbContext);
            _CharacterNoterepository = _CharacterNoteUnitofwork.GetRepository<CharacterNote>();
        }

        public List<CharacterNote> GetCharacterNotes()
        {
            return _CharacterNoterepository.GetAll().ToList();
        }

        public void Add(CharacterNote t)
        {
            _CharacterNoterepository.Insert(t);
            _CharacterNoteUnitofwork.SaveChanges();
        }

        public void Delete(int id)
        {
            _CharacterNoterepository.Delete(id);
            _CharacterNoteUnitofwork.SaveChanges();
        }

        public void Edit(CharacterNote t)
        {
            _CharacterNoterepository.Update(t);
            _CharacterNoteUnitofwork.SaveChanges();
        }

        public void Delete(CharacterNote t)
        {
                _CharacterNoterepository.Delete(t);
                _CharacterNoteUnitofwork.SaveChanges();
        }

        public CharacterNote Get(int id)
        {
                return _CharacterNoterepository.GetById(id);
        }
        public int GetCharacter(int note)
        {
           var cnote =  _CharacterNoterepository.GetAll();
            var deger = cnote.FirstOrDefault(x => x.Result >= note);
            if (deger!=null)
            {
                if (deger.Result<=50)
                {
                    return 1;
                }
                else if (deger.Result <= 60)
                {
                    return 2;
                }
                else if(deger.Result <= 70)
                {
                    return 3;
                }
                else if (deger.Result <= 85)
                {
                    return 4;
                }
                else if (deger.Result <= 100)
                {
                    return 5;
                }
            }
                    return 0;

        }
    }
}
