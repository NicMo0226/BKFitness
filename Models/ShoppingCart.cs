using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BKFitness.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }

        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public virtual ApplicationRole ApplicationRole { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [BindNever]
        [ScaffoldColumn (false)]
        public int Amounts { get; set; }
 

        [BindNever]
        [ScaffoldColumn (false)]
        public DateTime DateBooked { get; set; }
    }
}