using System.Collections.Generic;

using NBUY_MOD.Services;
using System.Web.Mvc;

using NBUY_MOD.Entities;
using NBUY_MOD.Models;

namespace NBUY_MOD.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewsServices _newsServices;
        private readonly CategoryServices _categoryServices;

        public HomeController()
        {
            _newsServices = new NewsServices();
            _categoryServices = new CategoryServices();
        }

        // GET: Home
        ////////[HttpGet]
        ////////[HttpPost]
        //////[AcceptVerbs("GET", "POST")]
        public ActionResult Index()
        {
            List<News> newList = _newsServices.GetNews();

            List<Category> categoryList = _categoryServices.GetCategories();

            var model = new HomeIndexViewModel
            {
                News = newList,
                Categories = categoryList
            };

            return View(model);
        }
    }
}