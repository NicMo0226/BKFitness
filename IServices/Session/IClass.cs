using System.Collections.Generic;
using System.Threading.Tasks;
using BKFitness.Models;

namespace BKFitness.IServices 
{
    public interface IClass
    {

        IEnumerable<Session> GetAll ();

        //return individual assets
        Session GetById (int id);
        Task Create (Session session);

       //0 Location GetLocation (int id);

        //IEnumerable<string> GetDayTime (int locationId);
    }
}