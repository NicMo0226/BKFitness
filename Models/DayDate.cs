using System;
using System.ComponentModel.DataAnnotations;

namespace BKFitness.Models
{
    public class DayDate
    {
        public int Id { get; set; }

        public string DayOfWeek { get; set; }

        [Display (Name = "Date")]
        [DisplayFormat (DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ClassDate { get; set; }

    }
}