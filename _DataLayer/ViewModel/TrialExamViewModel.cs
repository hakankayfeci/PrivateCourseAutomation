using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer.ViewModel
{
     public class TrialExamViewModel
    {
        public int TrialExamId { get; set; }
        public Nullable<short> Session { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public string TrialExamName { get; set; }
        public Nullable<int> LessonId { get; set; }
        public string TrialExamDescription { get; set; }
        public string LessonName { get; set; }
    }
}
