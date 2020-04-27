using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataLayer.ViewModel
{
    public class PaymentViewModel
    {
        public int EmployeePaymentId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<decimal> Maaslar { get; set; }
        public string RoleName { get; set; }

    }
}
