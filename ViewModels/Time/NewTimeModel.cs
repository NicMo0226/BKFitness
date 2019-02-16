using System;
using System.ComponentModel.DataAnnotations;

namespace BKFitness.ViewModels.Time
{
    public class NewTimeModel
    {
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