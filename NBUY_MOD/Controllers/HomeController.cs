using System.Collections.Generic;

using NBUY_MOD.Services;
using System.Web.Mvc;

using NBUY_MOD.Entities;

namespace NBUY_MOD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<News> list = new NewsServices().GetNews();
            return View();
        }
    }
}