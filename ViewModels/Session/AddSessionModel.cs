using Microsoft.AspNetCore.Http;

namespace BKFitness.ViewModels.Session
{
    public class AddSessionModel
    {
        public string Name { get; set; }
        public IFormFile Image { get; set; }
        public string SessionImageUrl { get; set; }
        public string Description { get; set; }
        public decimal ClassPriceNoMember { get; set; }
        public decimal ClassPriceMember { get; set; }
    }
}