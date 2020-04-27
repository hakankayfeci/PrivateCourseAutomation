using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer.ViewModel
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Phone { get; set; }
        public string IdentityNo { get; set; }
        public string Email { get; set; }
        public string LowerEmail { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string RoleName { get; set; }
        public int? AuthorizeNumber { get; set; }

    }
}
