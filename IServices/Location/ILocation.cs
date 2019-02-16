using BKFitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKFitness.IServices
{ 
    public interface ILocation
    {
        IEnumerable<Location> GetAll();
        //  IEnumerable<BKFitnessAsset>GetAssets(int locationId);
        Location GetById(int id);
        Task AddLocation(Location location);
    //  IEnumerable<string> GetDayTimes(int locationId);
    }
}
