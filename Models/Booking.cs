using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BKFitness.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int DayDateId { get; set; }
              public int TimeId { get; set; }

        public int SessionId { get; set; }
    
        public int LocationId { get; set; }
  
        public int MembershipId { get; set; }
      

        public DateTime DateBooked { get; set; }

    }
}