using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BKFitness.IServices;
using BKFitness.Models;
using BKFitness.ViewModels.Session;
using Microsoft.AspNetCore.Mvc;


namespace BKFitness.Controllers 
{
    public class SessionController : Controller 
    {
        private IClass _sessionService;
        private ILocation _locationService;
        public SessionController (IClass sessionService, ILocation locationService) 
        {
            _sessionService = sessionService;
            _locationService = locationService;
        }

        public IActionResult Index (int id) 
        {

            var session = _sessionService.GetAll ();

            var listingResult = session
                .Select (c => new SessionListingModel 
                {
                    Id = c.Id,
                        SessionName = c.SessionName,
                        Image = c.SessionImageUrl,
                        NonMemberPrice = c.NoMembershipPrice,
                        MemberPrice = c.MembershipPrice,

                });

            var model = new SessionIndexModel () 
            {
                SessionListing = listingResult
            };
            return View (model);
        }

        public IActionResult Detail (int id) 
        {

            var session = _sessionService.GetById (id);

            var model = new SessionDetailModel 
            {
                Id = id,
                Name = session.SessionName,
                Image = session.SessionImageUrl,
                Description = session.SessionDescription,
                NonMemberPrice = session.NoMembershipPrice,
                MemberPrice = session.MembershipPrice,
         
            };
            return View (model);
        }

        
        public IActionResult Create () 
        {
            var model = new AddSessionModel ();
            return View (model);
        }

        [HttpPost]
        public async Task<IActionResult> AddSession (AddSessionModel model) 
        {
            var session = new Session {
            SessionName = model.Name,
            SessionDescription = model.Description,
            SessionImageUrl = model.Image,
           NoMembershipPrice = model.NonMemberPrice,
             MembershipPrice = model.MemberPrice,
      };

           await _sessionService.Create (session);

        return RedirectToAction ("Index", "Session");
        }
    }
}