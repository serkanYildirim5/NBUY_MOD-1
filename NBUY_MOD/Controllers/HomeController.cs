using System.Collections.Generic;

using NBUY_MOD.Services;
using System.Web.Mvc;

using NBUY_MOD.Entities;
using NBUY_MOD.Entities.DTO;
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

        public ActionResult Index()
        {
            List<NewsDTO> newList = _newsServices.GetNewsDTOs();
            List<CategoryDTO> categoryList = _categoryServices.GetTopCategoriesDTO();

            var model = new HomeIndexViewModel
            {
                News = newList,
                Categories = categoryList
            };

            return View(model);
        }
    }
}