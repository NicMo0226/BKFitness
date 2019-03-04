namespace BKFitness.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Booking Booking { get; set; }
        public Membership Membership { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public decimal PurchasePrice { get; set; }
        //public string Category { get; set; }
        public decimal RetailPrice { get; set; }
    }
}