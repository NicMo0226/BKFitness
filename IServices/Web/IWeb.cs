using BKFitness.Models;

namespace BKFitness.IServices
{
    public interface IWeb
    {
        object GetProduct (long id);

        object GetProducts (int skip, int take);

        long StoreProduct (Product product);

        void UpdateProduct (Product product);

        void DeleteProduct (long id);
    }
}