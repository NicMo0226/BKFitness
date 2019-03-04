using System.Collections.Generic;
using System.Linq;
using BKFitness.IServices;
using BKFitness.Models;
using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    public class OrderController : Controller
    {
        private IData _dataService;
        private IOrder _orderService;

        public OrderController (IData dataService,
            IOrder orderService)
        {
            _dataService = dataService;
            _orderService = orderService;
        }

        public IActionResult Index () => View (_orderService.Orders);

        public IActionResult EditOrder (long id)
        {
            var products = _dataService.Products;
            Order order = id == 0 ? new Order () : _orderService.GetOrder (id);
            IDictionary<long, OrderLine> linesMap = order.Lines?.ToDictionary (l => l.ProductId)
                ?? new Dictionary<long, OrderLine> ();
            ViewBag.Lines = products.Select (p => linesMap.ContainsKey (p.Id)
                ? linesMap[p.Id]
                : new OrderLine { Product = p, ProductId = p.Id, Quantity = 0 });
            return View (order);
        }

        [HttpPost]
        public IActionResult AddOrUpdateOrder (Order order)
        {
            order.Lines = order.Lines
                .Where (l => l.Id > 0 || (l.Id == 0 && l.Quantity > 0)).ToArray ();
            if (order.Id == 0)
            {
                _orderService.AddOrder (order);
            }
            else
            {
                _orderService.UpdateOrder (order);
            }
            return RedirectToAction (nameof (Index));
        }

        [HttpPost]
        public IActionResult DeleteOrder (Order order)
        {
            _orderService.DeleteOrder (order);
            return RedirectToAction (nameof (Index));
        }
    }
}