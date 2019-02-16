using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BKFitness.Models;

namespace BKFitness.IServices
{
    public interface IApplicationRole
    {
        ApplicationRole GetById (string roleId);
        IEnumerable<ApplicationRole> GetAll ();

        Task AddRole (ApplicationRole role);

    }
}