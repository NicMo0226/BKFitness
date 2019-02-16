using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BKFitness.Models
{
    public class Membership
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Membership Type")]
        public string MembershipType { get; set; }

        [Required]
        public string MembershipImageUrl { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string MembershipDescription { get; set; }

        [Required]
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

       
    }
}