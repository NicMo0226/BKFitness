using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BKFitness.ViewModels.Account.User
{
    public class EditUserRoleModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string Email { get; set; }
        public List<SelectListItem> ApplicationRoles { get; set; }

        [Display (Name = "Role")]
        public string ApplicationRoleId { get; set; }
    }
}