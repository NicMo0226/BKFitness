using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BKFitness.Data;
using BKFitness.Models;

namespace BKFitness.IServices
{
    public class MembershipService : IMembership
    {
        private ApplicationDbContext _context;

        public MembershipService (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddMembership (Membership membership)
        {
            _context.Add (membership);
            await _context.SaveChangesAsync ();
        }

        public IEnumerable<Membership> GetAll ()
        {
            return _context.Memberships;
        }

        public Membership GetById (int id)
        {
            return _context.Memberships.Where (m => m.Id == id)
                .FirstOrDefault ();
        }
    }
}

