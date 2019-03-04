using System.Collections.Generic;
using System.Threading.Tasks;
using BKFitness.Models;

namespace BKFitness.IServices
{
    public interface IMembership
    {
        Membership GetById (int id);
        IEnumerable<Membership> GetAll ();
        Task AddMembership (Membership membership);
    }
}