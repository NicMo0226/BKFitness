using BKFitness.IServices;
using BKFitness.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    public class StoreController : Controller
    {
        private readonly IData _dataService;
        private readonly ICategory _categoryService;

        public StoreController (IData dataService, ICategory categoryService)
        {
            _dataService = dataService;
            _categoryService = categoryService;
        }
        public IActionResult Index ([FromQuery (Name = "options")] QueryOptions productOptions,
            QueryOptions catOptions,
            long category)
        {
            ViewBag.Categories = _categoryService.GetCategories (catOptions);
            ViewBag.SelectedCategory = category;
            return View (_dataService.GetProducts (productOptions, category));
        }
    }
}