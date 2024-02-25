using COMP2139___Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP2139___Assignment_1.Controllers
{
    public class FlightController : Controller
    {
        public IActionResult Book()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Book(FlightBooking model)
        {
            return RedirectToAction("Confirmation", new { bookingType = "Flight", bookingId = model.Id });
        }

        public IActionResult Confirmation(string bookingType, int bookingId)
        {

            return View();
        }
    }

}

