using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace BKFitness.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string RoleId { get; set; }
        public string MembershipName { get; set; }
        public DateTime CreatedDate { get; set; }

        public string MembershipImageUrl { get; set; }

        [Required]
        [Display (Name = "Description")]
        public string MembershipDescription { get; set; }

        [Required]
        [Display (Name = "Price")]
        [Column (TypeName = "decimal(18,2)")]
        public decimal MembershipPrice { get; set; }

    }
}