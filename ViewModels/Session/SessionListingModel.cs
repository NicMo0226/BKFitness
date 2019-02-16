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

        public string Image { get; set; }

        public decimal NonMemberPrice { get; set; }
        public decimal MemberPrice { get; set; }

    }
}