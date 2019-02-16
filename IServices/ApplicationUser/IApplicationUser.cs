using BKFitness.Models;
using System.Collections.Generic;

namespace BKFitness.IServices
{
    public interface IApplicationUser
    {
        IEnumerable<ApplicationUser> GetAll();


        //return individual assets
        ApplicationUser GetById(string id);
        void Add(ApplicationUser newUser);


       
    }
}
