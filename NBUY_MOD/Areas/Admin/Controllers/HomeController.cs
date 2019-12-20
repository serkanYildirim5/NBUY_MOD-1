using System.Web.Mvc;

using NBUY_MOD.Models;

namespace NBUY_MOD.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}