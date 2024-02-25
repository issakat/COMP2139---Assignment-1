using COMP2139___Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP2139___Assignment_1.Controllers
{
    public class CarRentalController : Controller
    {

        public IActionResult Book()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Book(CarRentalBooking model)
        {

            return RedirectToAction("Confirmation", new { bookingType = "CarRental", bookingId = model.Id });
        }

        public IActionResult Confirmation(string bookingType, int bookingId)
        {

            return View();
        }
    }

}

