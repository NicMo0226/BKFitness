using Microsoft.AspNetCore.Mvc.Rendering;

namespace BKFitness.ViewModels.Booking
{
    public class NewBookingModel
    {

        public int DayDateId { get; set; }
        public SelectList DayDateList { get; set; }
        public int TimeId { get; set; }
        public SelectList TimeList { get; set; }
        public int SessionId { get; set; }
        public SelectList SessionList { get; set; }
        public int LocationId { get; set; }
        public SelectList LocationList { get; set; }
    }
}