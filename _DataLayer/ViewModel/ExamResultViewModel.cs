using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer.ViewModel
{
    public class ExamResultViewModel
    {
        public int ExamId { get; set; }
        public Nullable<short> Session { get; set; }
        public Nullable<int> Notu { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> LessonId { get; set; }
        public Nullable<int> CharacterNoteId { get; set; }
        public string Firstname { get; set; }
        public string LessonName { get; set; }
        public string Character { get; set; }

    }
}
