﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DEV3Entities : DbContext
    {
        public DEV3Entities()
            : base("name=DEV3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BRANCH> BRANCHES { get; set; }
        public DbSet<DEPARTMENT> DEPARTMENTS { get; set; }
        public DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
        public DbSet<Employee_OrgUnit_XRef> Employee_OrgUnit_XRef { get; set; }
        public DbSet<Employee_Type> Employee_Type { get; set; }
        public DbSet<EmployeeCalendarYear> EmployeeCalendarYears { get; set; }
        public DbSet<EmployeePersonalContact> EmployeePersonalContacts { get; set; }
        public DbSet<EmployeeStatu> EmployeeStatus { get; set; }
        public DbSet<EmployeeStatusHistory> EmployeeStatusHistories { get; set; }
    }
}
