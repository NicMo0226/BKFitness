using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BKFitness.IServices;
using BKFitness.Models;
using BKFitness.ViewModels.Membership;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    public class MembershipController : Controller
    {
        private readonly IMembership _membershipService;
        private static UserManager<ApplicationUser> _userManager;
        private readonly IHostingEnvironment _environment;

        public MembershipController (IHostingEnvironment environment, UserManager<ApplicationUser> userManager, IMembership membershipService)
        {
            _userManager = userManager;
            _environment = environment;
            _membershipService = membershipService;
        }

        [HttpGet]
        public IActionResult Index (int id)
        {

            var membership = _membershipService.GetAll ();

            var listingResult = membership
                .Select (m => new MembershipListingModel
                {
                    Id = m.Id,
                        MembershipName = m.MembershipName,
                        MembershipDescription = m.MembershipDescription,
                        MembershipImageUrl = m.MembershipImageUrl,
                        MembershipPrice = m.MembershipPrice

                });
            var model = new MembershipIndexModel ()
            {
                MembershipList = listingResult
            };
            return View (model);
        }

        public IActionResult Create ()
        {
            var m = new NewMembershipModel ();
            return View (m);
        }

        [HttpPost]
        public async Task<IActionResult> AddMembership (NewMembershipModel m, IFormCollection image)
        {

            string storePath = "/images/membership/";
            var path = Path.Combine (
                Directory.GetCurrentDirectory (), "wwwroot", "images", "membership",
                image.Files[0].FileName);
            using (var stream = new FileStream (path, FileMode.Create))
            {
                await image.Files[0].CopyToAsync (stream);
            }

            var membership = new Membership
            {
                MembershipName = m.MembershipName,
                MembershipDescription = m.MembershipDescription,
                MembershipImageUrl = storePath + m.Image.FileName,
                MembershipPrice = m.MembershipPrice

            };
            await _membershipService.AddMembership (membership);

            return RedirectToAction ("Index", "Membership");

        }
    }
}