using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer.ViewModel
{
    public class TrialExamResultViewModel
    {
        public int TrialExamResultId { get; set; }
        public int StudentId { get; set; }
        public Nullable<int> Notu { get; set; }
        public string TrialExamName { get; set; }
        public string Firstname { get; set; }
        public string Character  { get; set; }
    }
}
