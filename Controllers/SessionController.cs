using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BKFitness.IServices;
using BKFitness.Models;
using BKFitness.ViewModels.Session;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    public class SessionController : Controller
    {
        private readonly IClass _sessionService;
        private readonly ILocation _locationService;
        private readonly IHostingEnvironment _environment;
        public SessionController (IClass sessionService, ILocation locationService, IHostingEnvironment environment)
        {
            _sessionService = sessionService;
            _locationService = locationService;
            _environment = environment;
        }

        public IActionResult Index (int id)
        {

            var session = _sessionService.GetAll ();

            var listingResult = session
                .Select (c => new SessionListingModel
                {
                    Id = c.Id,
                        SessionName = c.SessionName,
                        SessionImageUrl = c.SessionImageUrl,
                        ClassPriceNoMember = c.ClassPriceNoMember,
                        ClassPriceMember = c.ClassPriceMember,

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
                SessionImageUrl = session.SessionImageUrl,
                Description = session.SessionDescription,
                ClassPriceNoMember = session.ClassPriceNoMember,
                ClassPriceMember = session.ClassPriceMember,

            };
            return View (model);
        }

        public IActionResult Create ()
        {
            var model = new AddSessionModel ();
            return View (model);
        }

        [HttpPost]
        public async Task<IActionResult> AddSession (AddSessionModel model, IFormCollection image)
        {
           

            string storePath = "/images/session/";
            var path = Path.Combine (
                Directory.GetCurrentDirectory (), "wwwroot", "images", "session",
                image.Files[0].FileName);
            using (var stream = new FileStream (path, FileMode.Create))
            {
                await image.Files[0].CopyToAsync (stream);
            }

            var session = new Session
            {
                SessionName = model.Name,
                SessionDescription = model.Description,
                SessionImageUrl = storePath + model.Image.FileName,
                ClassPriceNoMember = model.ClassPriceNoMember,
                ClassPriceMember = model.ClassPriceMember,
            };

            await _sessionService.Create (session);

            return RedirectToAction ("Index", "Session");
        }
    }
}