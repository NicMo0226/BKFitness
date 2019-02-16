using System;
using System.ComponentModel.DataAnnotations;

namespace BKFitness.Models
{
    public class Time
    {
        public int Id { get; set; }

        [Display (Name = "Start Time")]
        [DisplayFormat (DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DataType (DataType.Time)]
        public DateTime Start { get; set; }

        [Display (Name = "End Time")]
        [DisplayFormat (DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DataType (DataType.Time)]
        public DateTime End { get; set; }
    }
}