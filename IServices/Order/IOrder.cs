using System.Collections.Generic;
using BKFitness.Models;

namespace BKFitness.IServices
{
    public interface IOrder
    {
        IEnumerable<Order> Orders { get; }
        Order GetOrder (long key);
        void AddOrder (Order order);
        void UpdateOrder (Order order);
        void DeleteOrder (Order order);
    }
}