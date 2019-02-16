using System.Collections.Generic;
using System.Threading.Tasks;

using BKFitness.Models;

namespace BKFitness.IServices
{
    public interface ITime
    {
        IEnumerable<Time> GetAll ();
        Time GetById (int id);
        Task AddTime (Time time);
    }
}