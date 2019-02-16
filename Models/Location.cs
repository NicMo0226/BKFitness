using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BKFitness.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        [Display (Name = "Location")]
        public string LocationName { get; set; }

        [Required]
        [Display (Name = "Address")]
        public string LocationAddress { get; set; }

        [Required]
        [Display (Name = "Map")]
        public string LocationMapUrl { get; set; }

      

    }
}