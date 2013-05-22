using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateMVCApp.Data;
using TemplateMVCApp.Data.Contracts;
using TemplateMVCApp.Model;

namespace TemplateMVCApp.Controllers
{
    public class DBExampleController : Controller
    {


        public DBExampleController(IEmployeeMaintUow uow)
        {
            Uow = uow;
        }

        public IEmployeeMaintUow Uow { get; set; }
        
        //
        // GET: /DBExample/EFExample

        public ActionResult EFExample()
        {
            var emps = Uow.Employees.GetAll();
            return View(emps);
        }

        

    }
}
