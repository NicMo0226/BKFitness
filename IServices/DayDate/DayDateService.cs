using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BKFitness.Data;
using BKFitness.Models;

namespace BKFitness.IServices
{
    public class DayDateService : IDayDate
    {
        private ApplicationDbContext _context;

        public DayDateService (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddDayDate (DayDate dayDate)
        {
            _context.Add (dayDate);
            await _context.SaveChangesAsync ();
        }

        public DayDate GetById (int id)
        {
            return _context.DayDates.Where (p => p.Id == id)
                .FirstOrDefault ();
        }

        public IEnumerable<DayDate> GetAll ()
        {
            return _context.DayDates;

        }
    }
}