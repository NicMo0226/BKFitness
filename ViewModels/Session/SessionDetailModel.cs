using System.Collections.Generic;

namespace BKFitness.ViewModels.Session
{
    public class SessionDetailModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string SessionImageUrl { get; set; }
        public string Description { get; set; }
        public decimal ClassPriceNoMember { get; set; }
    public decimal ClassPriceMember { get; set; }


       
    }
}