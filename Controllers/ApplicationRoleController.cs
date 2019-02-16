using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BKFitness.IServices;
using BKFitness.Models;
using BKFitness.ViewModels.Account.Role;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    public class ApplicationRoleController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IApplicationRole _applicationRoleService;
        private static UserManager<ApplicationUser> _userManager;

        public ApplicationRoleController (RoleManager<ApplicationRole> roleManager, IApplicationRole applicationRoleService, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _applicationRoleService = applicationRoleService;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index (int id)
        {

            var role = _applicationRoleService.GetAll ();

            var listingResult = role
                .Select (r => new ApplicationRoleListModel
                {
                    RoleId = r.RoleId,
                        MembershipName = r.MembershipName,
                        MembershipDescription = r.MembershipDescription,
                        MembershipImageUrl = r.MembershipImageUrl,
                        MembershipPrice = r.MembershipPrice

                });
            var model = new ApplicationRoleIndexModel ()
            {
                RoleList = listingResult
            };
            return View (model);
        }

        public IActionResult Create ()
        {
            var r = new NewApplicationRoleModel ();
            return View (r);
        }

        [HttpPost]
        public async Task<IActionResult> AddRole (NewApplicationRoleModel r)
        {
            var role = new ApplicationRole
            {
                MembershipName = r.MembershipName,
                MembershipDescription = r.MembershipDescription,
                MembershipImageUrl = r.MembershipImageUrl,
                MembershipPrice = r.MembershipPrice
            };
            await _applicationRoleService.AddRole (role);

            return RedirectToAction ("Index", "ApplicationRole");

        }
    }
}