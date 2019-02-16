using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BKFitness.Data;
using BKFitness.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BKFitness.IServices
{
    public class ClassService : IClass
    {
        private ApplicationDbContext _context;

        public ClassService (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create (Session session)
        {
            _context.Add (session);
            await _context.SaveChangesAsync ();
        }
        public Session GetById (int id)
        {
            var session = _context.Classes.Where (c => c.Id == id)
                .FirstOrDefault ();

            return session;
        }

        //Class navigation properties, return all
        public IEnumerable<Session> GetAll ()
        {
            return _context.Classes;
            //    .Include (session => session.Locations);
            //.ThenInclude (c => c.HoursOpen);

        }
     
    }
}