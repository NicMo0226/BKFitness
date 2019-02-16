using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BKFitness.Data;
using BKFitness.Models;

namespace BKFitness.IServices
{
    public class TimeService : ITime
    {
        private ApplicationDbContext _context;

        public TimeService (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddTime (Time time)
        {
            _context.Add (time);
            await _context.SaveChangesAsync ();
        }

        public Time GetById (int id)
        {
            return _context.Times.Where (p => p.Id == id)
                .FirstOrDefault ();
        }

        public IEnumerable<Time> GetAll ()
        {
            return _context.Times;

        }
    }
}