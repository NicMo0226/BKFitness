using BKFitness.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    public class CartController : Controller
    {
        private ICart _cartService;

        public CartController (ICart cartService)
        {
            _cartService = cartService;
        }

    }
}