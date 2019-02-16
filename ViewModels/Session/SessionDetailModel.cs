using System.Collections.Generic;

namespace BKFitness.ViewModels.Session 
{
    public class SessionDetailModel 
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal NonMemberPrice { get; set; }
        public decimal MemberPrice { get; set; }

        public string LocationName { get; set; }
        public string LocationAddress { get; set; }
        public IEnumerable<string> HoursOpen { get; set; }
    }
}