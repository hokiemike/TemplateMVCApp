using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMVCApp.Model
{
    public class Employee
    {

        [Key]
        public int EMP_RECORD_NUMBER { get; set; }
        public string EMP_USER_PROFILE { get; set; }
        public string EMP_LAST_NAME { get; set; }
        public string EMP_ACTIVE_CODE { get; set; }
        public Nullable<int> EMP_EXTENSION { get; set; }
        public string EMP_FIRST_NAME { get; set; }
        public string EMP_MIDDLE_NAME { get; set; }
        public string EMP_PREFIX { get; set; }
        public Nullable<int> EMP_BRANCH_NUMBER { get; set; }
        public Nullable<int> EMP_DEPARTMENT_NUMBER { get; set; }
        public string EMP_EMAIL_ADDRESS { get; set; }
        public string EMP_FAXNUMBER { get; set; }
        public Nullable<decimal> PaymentAuthority { get; set; }
        public Nullable<int> EmployeeTypeKey { get; set; }
        public bool IsExempt { get; set; }
        public bool IsOnPayroll { get; set; }
        public Nullable<int> DefaultUnderwriter { get; set; }
        public bool IsExecutive { get; set; }
        public string Signature { get; set; }
        public Nullable<bool> AllowCompressed { get; set; }
        public Nullable<System.DateTime> CompressedStatusDate { get; set; }
        public bool WorkOtherDepartmentTasks { get; set; }
        public Nullable<decimal> IndemnityReserveAuthority { get; set; }
        public Nullable<decimal> ExpenseReserveAuthority { get; set; }
        public string Initials { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string STATE_ABBREVIATION { get; set; }
        public string ZipCode { get; set; }
    }
}
