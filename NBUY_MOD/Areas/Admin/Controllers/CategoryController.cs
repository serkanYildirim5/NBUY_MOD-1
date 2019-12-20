using System.Web.Mvc;

using NBUY_MOD.Entities.DTO;
using NBUY_MOD.Entities.Entity;
using NBUY_MOD.Helpers.Extensions;
using NBUY_MOD.Services;

namespace NBUY_MOD.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryServices _categoryServices;

        public CategoryController()
        {
            _categoryServices = new CategoryServices();
        }

        // GET: Admin/Category
        //[HttpPatch]
        //[HttpPut]
        //[HttpDelete]
        //[HttpPost]
        //[HttpGet]

        //[AcceptVerbs("GET", "POST")]
        //[AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]

        public ActionResult Index()
        {
            var categories = _categoryServices.GetCategories();

            return View(categories);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = _categoryServices.GetCategory(id);

            if (category == null)
                return HttpNotFound();

            return View(category.GetCategoryDto());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CategoryDTO categoryDto)
        {
            if (id != categoryDto.Id)
                return new HttpNotFoundResult();

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Gerekli alanları doldurun!");
                return View();
            }

            var category = categoryDto.GetCategory();

            _categoryServices.EditCategory(category);

            return RedirectToAction(nameof(Index));
        }
    }
}