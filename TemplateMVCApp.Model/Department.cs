using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMVCApp.Model
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int DEPARTMENT_NUMBER { get; set; }
        public string DEPARTMENT_DESCRIPTION { get; set; }
        public string UNDERWRITING_FLAG { get; set; }
        public string CLAIMS_FLAG { get; set; }
        public string PROGRAM_FLAG { get; set; }
        public Nullable<int> DEDUCTIBLE_BILLING_FLAG { get; set; }
        public Nullable<int> PROFITCENTERKEY { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> AccountingGroupTypeKey { get; set; }
        public Nullable<bool> CreateNewSubmissions { get; set; }
    }
}
