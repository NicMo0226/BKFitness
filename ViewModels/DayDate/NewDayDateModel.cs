using System;
using System.ComponentModel.DataAnnotations;

namespace BKFitness.ViewModels.DayDate
{
    public class NewDayDateModel
    {

        public string DayOfWeek { get; set; }

        [Display (Name = "Date")]
        [DisplayFormat (DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ClassDate { get; set; }
    }
}