//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _DataLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeePayment
    {
        public int EmployeePaymentId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<decimal> Maaslar { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
