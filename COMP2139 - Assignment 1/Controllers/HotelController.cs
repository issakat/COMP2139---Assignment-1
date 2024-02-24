using COMP2139___Assignment_1.Interface;
using COMP2139___Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP2139___Assignment_1.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchHotels(string location, DateTime checkInDate, DateTime checkOutDate, int numberOfGuests, decimal priceRangeMin, decimal priceRangeMax)
        {
            var hotels = _hotelService.SearchHotels(location, checkInDate, checkOutDate, numberOfGuests, priceRangeMin, priceRangeMax);
            return View("SearchResults", hotels);
        }

        public IActionResult HotelListings()
        {
            var hotelListings = _hotelService.GetHotelListings();
            return View(hotelListings);
        }

        [HttpPost]
        public IActionResult CreateHotel(Hotel hotel)
        {
            _hotelService.AddHotel(hotel);

            return RedirectToAction("HotelListings");
        }

    }
}
