using System.Linq;
using System.Threading.Tasks;
using BKFitness.Data;
using BKFitness.IServices;
using BKFitness.Models;
using BKFitness.ViewModels.Time;

using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    public class TimeController : Controller
    {
        private readonly ITime _timeService;
           private readonly ApplicationDbContext _context;

        public TimeController (ApplicationDbContext context, ITime timeService)
        {
            _timeService = timeService;
          
            _context = context;
        }
        public IActionResult Index (int id)
        {
            var time = _timeService.GetAll ();

            var listingResult = time
                .Select (t => new TimeListingModel
                {
                    Id = t.Id,
                    Start = t.Start,
                    End = t.End
                });
            var model = new TimeIndexModel ()
            {
                TimeListing = listingResult
            };
            return View (model);

        }

        public IActionResult Create ()
        {
            var model = new NewTimeModel ();
            return View (model);
        }

        [HttpPost]
        public async Task<IActionResult> AddTime (NewTimeModel model)
        {
            var time = new Time
            {
                Start = model.Start,
                End = model.End,

            };
            await _timeService.AddTime (time);

            return RedirectToAction ("Index", "Time");

        }
    }
}