namespace BKFitness.Models
{
    public class OrderDetail
    {

        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BookingId { get; set; }
        public int ApplicationRoleId { get; set; }
        public int ApplicationUserId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Order Order { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ApplicationRole ApplicationRole { get; set; }
    }
}