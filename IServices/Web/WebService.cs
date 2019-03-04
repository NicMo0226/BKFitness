using System.Linq;
using BKFitness.Data;
using BKFitness.Models;
using Microsoft.EntityFrameworkCore;

namespace BKFitness.IServices
{
    public class WebService : IWeb
    {
        private ApplicationDbContext _context;

        public WebService (ApplicationDbContext context)
        {
            _context = context;
        }
        public object GetProduct (long id)
        {
            return _context.Products.Include (p => p.Category)
                .Select (p => new
                {
                    Id = p.Id, Name = p.Name, PurchasePrice = p.PurchasePrice,
                        Description = p.Description, RetailPrice = p.RetailPrice,
                        CategoryId = p.CategoryId,
                        Category = new
                        {
                            Id = p.Category.Id,
                                Name = p.Category.Name,
                                Description = p.Category.Description
                        }
                })
                .FirstOrDefault (p => p.Id == id);
        }

        public object GetProducts (int skip, int take)
        {
            return _context.Products.Include (p => p.Category)
                .OrderBy (p => p.Id)
                .Skip (skip)
                .Take (take)
                .Select (p => new
                {
                    Id = p.Id, Name = p.Name, PurchasePrice = p.PurchasePrice,
                        Description = p.Description, RetailPrice = p.RetailPrice,
                        CategoryId = p.CategoryId,
                        Category = new
                        {
                            Id = p.Category.Id,
                                Name = p.Category.Name,
                                Description = p.Category.Description
                        }
                });
        }

        public long StoreProduct (Product product)
        {
            _context.Products.Add (product);
            _context.SaveChanges ();
            return product.Id;
        }

        public void UpdateProduct (Product product)
        {
            _context.Products.Update (product);
            _context.SaveChanges ();
        }

        public void DeleteProduct (long id)
        {
            _context.Products.Remove (new Product { Id = id });
            _context.SaveChanges ();
        }
    }
}
