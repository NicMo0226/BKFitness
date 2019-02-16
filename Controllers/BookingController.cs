using System;
using System.Linq;
using System.Threading.Tasks;

using BKFitness.Data;
using BKFitness.IServices;
using BKFitness.Models;
using BKFitness.ViewModels.Booking;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BKFitness.Controllers
{
    public class BookingController : Controller
    {

        private readonly IBooking _bookingService;

        private readonly ApplicationDbContext _context;

        public BookingController (ApplicationDbContext context, IBooking bookingService)
        {

            _bookingService = bookingService;
            _context = context;
        }
        public IActionResult Index (int id)
        {

            var booking = (
                from b in _context.Bookings
                join s in _context.Classes on b.SessionId equals s.Id
                join l in _context.Locations on b.LocationId equals l.Id
                join d in _context.DayDates on b.DayDateId equals d.Id
                join t in _context.Times on b.TimeId equals t.Id
                select new BookingListModel
                {
                    SessionName = s.SessionName,
                    LocationName = l.LocationName,
                    Day = d.DayOfWeek,
                    ClassDate = d.ClassDate,
                    Start = t.Start,
                    End = t.End
                });
            var model = new BookingIndexModel
            {
                BookingList = booking
            };
            return View (model);

        }
        public IActionResult Create ()
        {
            var model = new NewBookingModel ();
            {

                var session = _context.Classes.OrderBy (s => s.SessionName)
                    .Select (x => new { Id = x.Id, Value = x.SessionName });
                model.SessionList = new SelectList (session, "Id", "Value");

                var location = _context.Locations.OrderBy (l => l.LocationName)
                    .Select (x => new { Id = x.Id, Value = x.LocationName });
                model.LocationList = new SelectList (location, "Id", "Value");

                var daydate = _context.DayDates.OrderBy (d => d.ClassDate)
                    .Select (x => new { Id = x.Id, Value = x.ClassDate });
                model.DayDateList = new SelectList (daydate, "Id", "Value");

                var time = _context.Times.OrderBy (t => t.Start)
                    .Select (x => new { Id = x.Id, Value = x.Start });
                model.TimeList = new SelectList (time, "Id", "Value");
            };
            return View (model);
        }
[HttpPost]
        public async Task<IActionResult> AddBooking (NewBookingModel model)
        {
            var booking = new Booking
            {
                SessionId = model.SessionId,
                LocationId = model.SessionId,
                DayDateId = model.DayDateId,
                TimeId = model.TimeId,
                DateBooked = DateTime.Now

            };

            await _bookingService.AddBooking (booking);

            return RedirectToAction ("Index", "Booking");
        }

    }
}