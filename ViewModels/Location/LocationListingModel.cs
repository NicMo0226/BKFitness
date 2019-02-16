using System.Collections.Generic;


namespace BKFitness.ViewModels.Location
{
    public class LocationListingModel
    {
        public int Id { get; set; }

        public string LocationName { get; set; }

        public string LocationAddress { get; set; }

        public string LocationMap { get; set; }

        public int SessionId { get; set; }

        public string SessionName { get; set; }
      //  public IEnumerable<DayTimesModel> HoursOpen { get; set; }
    }
}