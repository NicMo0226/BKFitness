using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BKFitness.ViewModels.Membership
{
    public class MembershipListingModel
    {
        public int Id { get; set; }
        public string MembershipName { get; set; }
    

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