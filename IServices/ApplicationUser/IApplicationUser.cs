using System.Collections.Generic;
using BKFitness.Models;

namespace BKFitness.IServices
{
    public interface IApplicationUser
    {
        IEnumerable<ApplicationUser> GetAll ();

        //return individual assets
        ApplicationUser GetById (string id);
        void Add (ApplicationUser newUser);

    

    }
}