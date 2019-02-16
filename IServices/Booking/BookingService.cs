using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BKFitness.Data;
using BKFitness.Models;

using Microsoft.EntityFrameworkCore;

namespace BKFitness.IServices
{
    public class BookingService : IBooking
    {

        private ApplicationDbContext _context;

        public BookingService (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddBooking (Booking booking)
        {
            _context.Add (booking);
            await _context.SaveChangesAsync ();
        }

        public IEnumerable<Booking> GetAll ()
        {
            return _context.Bookings;

        }

        public Booking GetById (int id)
        {
            return _context.Bookings
                .FirstOrDefault (l => l.Id == id);
        }

    }

}