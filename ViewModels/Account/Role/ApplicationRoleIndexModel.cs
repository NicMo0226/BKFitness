using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BKFitness.ViewModels.Account.Role
{
    public class ApplicationRoleIndexModel
    {
        public IEnumerable<ApplicationRoleListModel> RoleList { get; set; }
    }
}