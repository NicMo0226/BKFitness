using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        
        public string MembershipId { get; set; }
        

    }
}