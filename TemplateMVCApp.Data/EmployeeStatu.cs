//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TemplateMVCApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeStatu
    {
        public EmployeeStatu()
        {
            this.EmployeeStatusHistories = new HashSet<EmployeeStatusHistory>();
        }
    
        public int EmployeeStatusKey { get; set; }
        public string EmployeeStatusName { get; set; }
        public string EmployeeStatusDesc { get; set; }
    
        public virtual ICollection<EmployeeStatusHistory> EmployeeStatusHistories { get; set; }
    }
}
