using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AspDotNet.Models;

namespace AspDotNet.Controllers
{
    public class EmployeeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployee()
        {
            Dal dal = new Dal();
            List<Employee> Employeelist = dal.MyEntities.ToList();

            return Json(Employeelist, JsonRequestBehavior.AllowGet);
        }
    }
}