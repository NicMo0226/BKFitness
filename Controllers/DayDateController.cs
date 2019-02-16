using System.Linq;
using System.Threading.Tasks;
using BKFitness.Data;
using BKFitness.IServices;
using BKFitness.Models;
using BKFitness.ViewModels.DayDate;
using Microsoft.AspNetCore.Mvc;

namespace BKFitness.Controllers
{
    public class DayDateController : Controller
    {
        private readonly IDayDate _dayDateService;

              private readonly ApplicationDbContext _context;

        public DayDateController (ApplicationDbContext context, IDayDate dayDateService)
        {
            _dayDateService = dayDateService;
          
            _context = context;
        }
        public IActionResult Index (int id)
        {
            var daydate = _dayDateService.GetAll ();

            var listingResult = daydate
                .Select (d => new DayDateListingModel
                {
                    Id = d.Id,
                      DayOfWeek = d.DayOfWeek,
                      ClassDate = d.ClassDate
                });
            var model = new DayDateIndexModel ()
            {
                DayDateListing = listingResult
            };
            return View (model);

        }

        public IActionResult Create ()
        {
            var model = new NewDayDateModel ();
            return View (model);
        }

        [HttpPost]
        public async Task<IActionResult> AddDayDate (NewDayDateModel model)
        {
            var dayDate= new DayDate
            {
                DayOfWeek = model.DayOfWeek,
                ClassDate = model.ClassDate,
              
            };
            await _dayDateService.AddDayDate (dayDate);

            return RedirectToAction ("Index", "DayDate");

        }

    }
}