using System.Collections.Generic;
using System.Threading.Tasks;
using BKFitness.Models;

namespace BKFitness.IServices
{
    public interface IDayDate
    {
        IEnumerable<DayDate> GetAll ();
        DayDate GetById (int id);
        Task AddDayDate (DayDate time);
    }
}