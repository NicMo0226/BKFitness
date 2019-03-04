using BKFitness.IServices;
using BKFitness.Models;
using BKFitness.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    public class CatalogController : Controller
    {
        private IData _dataService;
        private ICategory _catService;

        public CatalogController (ICategory catService, IData dataService)
        {
            _dataService = dataService;
            _catService = catService;
        }

        public IActionResult Index (QueryOptions options)
        {
            return View (_dataService.GetProducts (options));
        }

        public IActionResult UpdateProduct (long key)
        {
            ViewBag.Categories = _catService.Categories;
            return View (key == 0 ? new Product () : _dataService.GetProduct (key));
        }

        [HttpPost]
        public IActionResult UpdateProduct (Product product)
        {
            if (product.Id == 0)
            {
                _dataService.AddProduct (product);
            }
            else
            {
                _dataService.UpdateProduct (product);
            }
            return RedirectToAction (nameof (Index));
        }

        [HttpPost]
        public IActionResult Delete (Product product)
        {
            _dataService.Delete (product);
            return RedirectToAction (nameof (Index));
        }
    }
}