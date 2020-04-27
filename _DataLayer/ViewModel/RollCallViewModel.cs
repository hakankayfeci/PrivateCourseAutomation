using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer.ViewModel
{
    public class RollCallViewModel
    {
        public int RollCallId { get; set; }
        public Nullable<int> NumberOfDays { get; set; }
        public Nullable<int> StudentId { get; set; }
        public string StudentName { get; set; }
    }
}
