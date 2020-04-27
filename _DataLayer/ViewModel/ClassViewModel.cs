using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer.ViewModel
{
    public class ClassViewModel
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public Nullable<int> LessonId { get; set; }
        public string LessonName { get; set; }
    }
}
