using BKFitness.IServices;
using BKFitness.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    public class OrderController : Controller
    {
        private IOrder _orderService;
        private ICart _cartService;

        public OrderController (IOrder orderService, ICart cartService)
        {
            _orderService = orderService;
            _cartService = cartService;
        }

        [Authorize]
        public IActionResult Checkout ()
        {
            return View ();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Checkout (Order order)
        {
            var items = _cartService.GetShoppingCartItems ();
            _cartService.GetShoppingCartItems = items;

            if (_cartService.CartItems.Count == 0)
            {
                ModelState.AddModelError ("", "Your cart is empty, add some pies first");
            }

            if (ModelState.IsValid)
            {
                _orderService.CreateOrder (order);
                _cartService.ClearCart ();
                return RedirectToAction ("CheckoutComplete");
            }
            return View (order);

        }

        public IActionResult CheckoutComplete ()
        {
            ViewBag.CheckoutCompleteMessage = HttpContext.User.Identity.Name
                + ", thanks for your order. You'll soon enjoy our delicious pies!";
            return View ();
        }
    }
}