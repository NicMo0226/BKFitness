using System.Collections.Generic;
using BKFitness.Data;
using BKFitness.Models;
using BKFitness.Models.Pages;

namespace BKFitness.IServices
{
    public interface ICategory
    {
        IEnumerable<Category> Categories { get; }

        PagedList<Category> GetCategories (QueryOptions options);

        void AddCategory (Category category);
        void UpdateCategory (Category category);
        void DeleteCategory (Category category);
    }

    public class CategoryService : ICategory
    {
        private ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context) => _context = context;

        public IEnumerable<Category> Categories => _context.Categories;

        public PagedList<Category> GetCategories (QueryOptions options)
        {
            return new PagedList<Category> (_context.Categories, options);
        }

        public void AddCategory (Category category)
        {
            _context.Categories.Add (category);
            _context.SaveChanges ();
        }

        public void UpdateCategory (Category category)
        {
            _context.Categories.Update (category);
            _context.SaveChanges ();
        }

        public void DeleteCategory (Category category)
        {
            _context.Categories.Remove (category);
            _context.SaveChanges ();
        }
    }
}