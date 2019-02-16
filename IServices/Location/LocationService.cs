using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BKFitness;
using BKFitness.Data;
using BKFitness.Models;

using Microsoft.EntityFrameworkCore;

namespace BKFitness.IServices
{
    public class LocationService : ILocation
    {
        private ApplicationDbContext _context;

        public LocationService (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddLocation (Location location)
        {
            _context.Add (location);
            await _context.SaveChangesAsync ();
        }

        public Location GetById (int id)
        {
            return _context.Locations.Where (p => p.Id == id)
                .FirstOrDefault ();
        }

        public IEnumerable<Location> GetAll ()
        {
            return _context.Locations;

        }

    }
}