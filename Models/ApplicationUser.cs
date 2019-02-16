using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Identity;

namespace BKFitness.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string UserId { get; set; }

        [Required]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display (Name = "Surname")]
        public string LastName { get; set; }

        public DateTime Joined { get; set; }

      

        [ForeignKey ("MembershipId")]
        public virtual Membership Membership { get; set; }
        public int MembershipId { get; set; }
    }
}