//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACME
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public string EmployeeNum { get; set; }
        public System.DateTime EmployedDate { get; set; }
        public Nullable<System.DateTime> TerminatedDate { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
