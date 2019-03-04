using BKFitness.IServices;
using BKFitness.Models;
using BKFitness.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategory repository;

        public CategoriesController (ICategory repo) => repository = repo;

        public IActionResult Index (QueryOptions options) => View (repository.GetCategories (options));

        [HttpPost]
        public IActionResult AddCategory (Category category)
        {
            repository.AddCategory (category);
            return RedirectToAction (nameof (Index));
        }

        public IActionResult EditCategory (long id)
        {
            ViewBag.EditId = id;
            return View ("Index", repository.Categories);
        }

        [HttpPost]
        public IActionResult UpdateCategory (Category category)
        {
            repository.UpdateCategory (category);
            return RedirectToAction (nameof (Index));
        }

        [HttpPost]
        public IActionResult DeleteCategory (Category category)
        {
            repository.DeleteCategory (category);
            return RedirectToAction (nameof (Index));
        }
    }
}