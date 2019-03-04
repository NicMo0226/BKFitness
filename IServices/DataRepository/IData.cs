using System.Collections.Generic;
using BKFitness.Models;
using BKFitness.Models.Pages;

namespace BKFitness.IServices
{
    public interface IData
    {
        IEnumerable<Product> Products { get; }

        PagedList<Product> GetProducts ( QueryOptions options, long category = 0);

        Product GetProduct (long key);

        void AddProduct (Product product);

        void UpdateProduct (Product product);

        void UpdateAll (Product[] products);

        void Delete (Product product);
      //  object GetProducts (int options, int category);
        // object GetProducts(long productOptions, int category);
    }
}