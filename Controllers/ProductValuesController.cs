using System.Collections.Generic;
using System.Linq;
using BKFitness.IServices;
using BKFitness.Models;
using BKFitness.Models.Pages;
using BKFitness.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    [Route ("api/products")]
    public class ProductValuesController : Controller
    {

        private readonly IWeb _webService;
       
        public ProductValuesController (IWeb webService)
        {
            _webService = webService;
    
        }

        [HttpGet ("{id}")]
        public object GetProduct (long id)
        {
            return _webService.GetProduct (id) ?? NotFound ();
        }

        [HttpGet]
        public object Products (int skip, int take)
        {
            return _webService.GetProducts (skip, take);
        }

        [HttpPost]
        public long StoreProduct ([FromBody] Product product)
        {
            return _webService.StoreProduct (product);
        }

        [HttpPut]
        public void UpdateProduct ([FromBody] Product product)
        {
            _webService.UpdateProduct (product);
        }

        [HttpDelete ("{id}")]
        public void DeleteProduct (long id)
        {
            _webService.DeleteProduct (id);
        }
    }
}