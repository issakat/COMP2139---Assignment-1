using COMP2139___Assignment_1.Data;
using COMP2139___Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace COMP2139___Assignment_1.Controllers
{
    public class HotelBookingController : Controller
    {
        private readonly BookingDbContext _dbContext;

        public HotelBookingController(BookingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var bookings = _dbContext.HotelBookings.ToList();
            return View(bookings);
        }

        [HttpGet]
        public IActionResult Book()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Book(HotelBooking model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.HotelBookings.Add(model);
                _dbContext.SaveChanges();
                return RedirectToAction("Confirmation", new { id = model.Id });
            }

            return View(model);
        }

        public IActionResult Confirmation(int id)
        {
            var booking = _dbContext.HotelBookings.Find(id);
            return View(booking);
        }
    }
}
