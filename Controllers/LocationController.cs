using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BKFitness.IServices;
using BKFitness.Models;
using BKFitness.ViewModels.Location;

using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    public class LocationController : Controller
    {
        private ILocation _locationService;
        private IClass _classService;

        public LocationController (ILocation locationService, IClass classService)
        {
            _locationService = locationService;
            _classService = classService;
        }

        public IActionResult Index (int id)
        {
            var location = _locationService.GetAll ();

            var listingResult = location
                .Select (l => new LocationListingModel
                {
                    Id = l.Id,
                        LocationName = l.LocationName,
                        LocationAddress = l.LocationAddress,
                        LocationMap = l.LocationMapUrl
                });
            var model = new LocationIndexModel ()
            {
                LocationListing = listingResult
            };
            return View (model);

        }

        public IActionResult Create ()
        {
            var model = new NewLocationModel ();
            return View (model);
        }

        [HttpPost]
        public async Task<IActionResult> AddLocation (NewLocationModel model)
        {
            var location = new Location
            {
                LocationName = model.LocationName,
                LocationAddress = model.LocationAddress,
                LocationMapUrl = model.LocationMap
            };
            await _locationService.AddLocation (location);

            return RedirectToAction ("Index", "Location");

        }

    }

}