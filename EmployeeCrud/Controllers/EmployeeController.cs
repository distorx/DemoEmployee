using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeCrud.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult List()
        {
            return View();
        }

        public ActionResult NewEdit()
        {
            return View();
        }
    }
}