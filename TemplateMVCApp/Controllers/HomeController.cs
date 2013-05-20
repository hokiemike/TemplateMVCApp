using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateMVCApp.Data;
using TemplateMVCApp.Model;

namespace TemplateMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var emps = GetEmployees();
            return View(emps);
        }

        private IEnumerable<Employee> GetEmployees()
        {

            var ctx = new TemplateDbContext();
           // Database.SetInitializer(new CreateDatabaseIfNotExists<TemplateDbContext>());
            //ctx.Database.Initialize(false);
            
           
            var emps = ctx.Employees;
            var cnt = emps.Count();
            return emps;
        }
    }
}
