using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Components
    {
   
            public class CartSummaryViewComponent : ViewComponent
            {
                private Cart cart;
                public CartSummaryViewComponent (Cart cartService)
                {
                    cart = cartService;
                }
                public IViewComponentResult Invoke ()
                {
                    return View (cart);
                }
            }
        }