using BKFitness.Data;
using BKFitness.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BKFitness.IServices
{
    public class ApplicationUserService : IApplicationUser
    {

        private ApplicationDbContext _context;

        public ApplicationUserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(ApplicationUser newUser)
        {
            _context.Add(newUser);
            _context.SaveChanges();
        }

        public ApplicationUser GetById(string id)
        {

            return _context.ApplicationUsers
                  .Include(m => m.Membership)
                  //  .Include(m => m.Checkouts)
                  .FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return _context.ApplicationUsers
                .Include(m => m.Membership);
            //  .Include(m => m.Checkouts);

        }

        //public IEnumerable<CheckoutHistory> GetCheckoutHistory(int applicationUserId)
        //{
        //    var membershiptypeId = Get(applicationUserId).applicationUser.Id;

        //    return _context.CheckoutHistories
        //      .Include(co => co.ApplicationUser)
        //      .Include(co => co.BKFitnessAsset)
        //      .Where(co => co.ApplicationUser.Id == membershiptypeId)
        //      .OrderByDescending(co => co.DateOfPurchase);
        //}

        //public IEnumerable<Checkout> GetCheckouts(int applicationUserId)
        //{
        //    var membershiptypeId = Get(applicationUserId).Membership.Id;

        //    return _context.Checkouts
        //      .Include(co => co.ApplicationUser)
        //      .Include(co => co.BKFitnessAsset)
        //      .Where(co => co.ApplicationUser.Id == membershiptypeId);
        //    // .OrderByDescending(co => co.DateOfPurchase);
        //}

    }
}

