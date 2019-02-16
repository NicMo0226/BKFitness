using System;
using BKFitness.Data;
using BKFitness.Models;

namespace BKFitness.IServices
{
    public class OrderService : IOrder
    {
        private ApplicationDbContext _context;

        private readonly ShoppingCart _shoppingCart;

        public OrderService (ApplicationDbContext context, ShoppingCart cart)
        {
            _context = context;
            _shoppingCart = cart;
        }
        public void CreateOrder (Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _context.Orders.Add (order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail ()
                {
                    Amount = shoppingCartItem.Amount,
                   BookingId = shoppingCartItem.Booking.Id,
                    OrderId = order.Id,
                    Price = shoppingCartItem.Booking.BookingCost
                };

                _context.OrderDetails.Add (orderDetail);
            }

            _context.SaveChanges ();
        }
    }
}
}