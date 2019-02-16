using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BKFitness.Data;
using BKFitness.Models;
using Microsoft.EntityFrameworkCore;

namespace BKFitness.IServices
{
    public class ApplicationRoleService : IApplicationRole
    {
        private readonly ApplicationDbContext _context;
        public ApplicationRoleService (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddRole (ApplicationRole role)
        {
            _context.Add (role);
            await _context.SaveChangesAsync ();
        }
        public IEnumerable<ApplicationRole> GetAll ()
        {
            return _context.ApplicationRoles;
        }

        public ApplicationRole GetById (string roleId)
        {
            return _context.ApplicationRoles.Where (user => user.Id == roleId)
                .FirstOrDefault ();
        }

    }
}