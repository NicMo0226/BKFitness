namespace BKFitness.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
       
        public Booking Booking { get; set; }
        public ApplicationRole ApplicationRole{ get; set; }
     
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}