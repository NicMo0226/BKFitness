namespace BKFitness.ViewModels.Session 
{
    public class AddSessionModel 
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal NonMemberPrice { get; set; }
        public decimal MemberPrice { get; set; }
    }
}