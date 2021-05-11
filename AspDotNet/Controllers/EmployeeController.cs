using System.Web.Mvc;

namespace AspDotNet.Controllers
{
    public class EmployeeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}