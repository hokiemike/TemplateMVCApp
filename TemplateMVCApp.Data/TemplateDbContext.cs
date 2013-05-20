using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMVCApp.Model;

namespace TemplateMVCApp.Data
{
    public class TemplateDbContext : DbContext
    {
        

        public TemplateDbContext()
            : base(nameOrConnectionString: "DEV3ConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            Database.SetInitializer<TemplateDbContext>(null); //existing db

            // Use singular table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Configurations.Add(new SessionConfiguration());
            //modelBuilder.Configurations.Add(new AttendanceConfiguration());
        }

        public DbSet<Employee> Employees { get; set; }
        
    }


   
}
