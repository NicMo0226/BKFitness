using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BKFitness.ViewModels.Account.User
{
    public class UserIndexModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }

        [DataType (DataType.Password)]
        public string Password { get; set; }

        [Display (Name = "Confirm Password")]
        [DataType (DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<SelectListItem> ApplicationRoles { get; set; }

        [Display (Name = "Membership")]
        public string ApplicationRoleId { get; set; }
    }
}