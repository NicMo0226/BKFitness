using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BKFitness.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        public List<OrderDetail> OrderLines { get; set; }

        [BindNever]
        [ScaffoldColumn (false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn (false)]
        public DateTime OrderPlaced { get; set; }
    }
}