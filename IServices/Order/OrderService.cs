using System.Collections.Generic;
using System.Linq;
using BKFitness.Data;
using BKFitness.Models;
using Microsoft.EntityFrameworkCore;

namespace BKFitness.IServices
{
    public class OrderService : IOrder
    {
        private ApplicationDbContext _context;

        public OrderService (ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> Orders => _context.Orders
            .Include (o => o.Lines).ThenInclude (l => l.Product);

        public Order GetOrder (long key) => _context.Orders
            .Include (o => o.Lines).First (o => o.Id == key);

        public void AddOrder (Order order)
        {
            _context.Orders.Add (order);
            _context.SaveChanges ();
        }

        public void UpdateOrder (Order order)
        {
            _context.Orders.Update (order);
            _context.SaveChanges ();
        }

        public void DeleteOrder (Order order)
        {
            _context.Orders.Remove (order);
            _context.SaveChanges ();
        }
    }
}