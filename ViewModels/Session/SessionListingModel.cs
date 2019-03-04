using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BKFitness.ViewModels.Session
{
    public class SessionListingModel
    {
        public int Id { get; set; }

        public string SessionName { get; set; }

        public string SessionImageUrl { get; set; }

        public decimal ClassPriceNoMember { get; set; }
        public decimal ClassPriceMember { get; set; }

    }
}