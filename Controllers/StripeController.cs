using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace BKFitness.Controllers
{
    public class StripeController : Controller
    {
        public IActionResult Index ()
        {
            return View ();
        }

        public IActionResult Error ()
        {
            return View ();
        }

        public IActionResult Charge (string stripeEmail, string stripeToken)
        {
            var customers = new CustomerService ();
            var charges = new ChargeService ();

            var customer = customers.Create (new CustomerCreateOptions
            {
                Email = stripeEmail,
                    SourceToken = stripeToken
            });

            var charge = charges.Create (new ChargeCreateOptions
            {
                Amount = 500,
                    Description = "Sample Charge",
                    Currency = "gbp",
                    CustomerId = customer.Id
            });

            return View ();
        }

    }
}