using System.Collections.Generic;
using System.Threading.Tasks;
using BKFitness.Models;

namespace BKFitness.IServices
{
    public interface IBooking
    {
        Booking GetById (int id);
        IEnumerable<Booking> GetAll ();

        Task AddBooking (Booking booking);
    }
}