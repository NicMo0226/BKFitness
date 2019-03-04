using System.Collections.Generic;
using BKFitness.Models;

namespace BKFitness.ViewModels.Cart
{
    public class CartIndexModel
    {
        public IEnumerable<CartListModel> CartList { get; set; }
    }
}