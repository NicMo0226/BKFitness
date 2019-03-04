using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace BKFitness.ViewModels.Membership
{
    public class NewMembershipModel
    {
      //  public string UserId { get; set; }

        public string MembershipName { get; set; }

        public string MembershipImageUrl { get; set; }
        public IFormFile Image { get; set; }

        [Required]
        [Display (Name = "Description")]
        public string MembershipDescription { get; set; }

        [Required]
        [Display (Name = "Price")]
        [Column (TypeName = "decimal(18,2)")]
        public decimal MembershipPrice { get; set; }

    }
}