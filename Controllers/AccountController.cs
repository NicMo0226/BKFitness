using System.Linq;
using System.Threading.Tasks;
using BKFitness.Data;
using BKFitness.Models;
using BKFitness.ViewModels.Account.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BKFitness.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
          
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Register ()
        {
            var model = new RegisterViewModel ();
            return View (model);
        }

        [HttpPost]
        public async Task<IActionResult> Register (RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = register.Email,
                    Email = register.Email,
                    FirstName = register.FirstName,
                    LastName = register.LastName,

                };

                var result = await _userManager.CreateAsync (user, register.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync (user, false);
                    return RedirectToAction ("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                        ModelState.AddModelError ("", error.Description);
                }
            }

            return View (register);
        }

        [HttpGet]
        public IActionResult Login ()
        {

            return View ();
        }

        [HttpPost]
        public async Task<IActionResult> Login (LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync (login.Email, login.Password, login.RememberMe, false);
                if (result.Succeeded)
                {

                    return RedirectToAction ("Index", "Home");
                }

                ModelState.AddModelError ("", "Invalid Login Attempt.");
                return View (login);
            }
            return View (login);
        }
    }
}