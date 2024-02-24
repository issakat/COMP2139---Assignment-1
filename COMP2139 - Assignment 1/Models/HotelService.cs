using COMP2139___Assignment_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace COMP2139___Assignment_1.Models
{
    public class HotelService : IHotelService
    {
        private readonly List<Hotel> _hotels;

        public HotelService()
        {
            _hotels = new List<Hotel>
            {
                new Hotel { Id = 1, Name = "Four Season Hotel", Location = "Toronto", PricePerNight = 100, Rating = 4 },
                new Hotel { Id = 2, Name = "Moss View Hotel", Location = "Vancouver", PricePerNight = 120, Rating = 5 },
                new Hotel { Id = 3, Name = "Oceana Boutique Hotel", Location = "Montreal", PricePerNight = 95, Rating = 3 },
                new Hotel { Id = 4, Name = "The Cozy Cottage", Location = "Calgary", PricePerNight = 105, Rating = 4 }
            };
        }

        public List<Hotel> GetHotelListings()
        {
            return _hotels;
        }

        public Hotel? GetHotelById(int id)
        {
            return _hotels.FirstOrDefault(h => h.Id == id);
        }

        public void AddHotel(Hotel hotel)
        {
            _hotels.Add(hotel);
        }

        public void UpdateHotel(Hotel hotel)
        {
            var existingHotel = _hotels.FirstOrDefault(h => h.Id == hotel.Id);
            if (existingHotel != null)
            {
                existingHotel.Name = hotel.Name;
                existingHotel.Description = hotel.Description;
                existingHotel.Location = hotel.Location;
                existingHotel.PricePerNight = hotel.PricePerNight;
                existingHotel.AvailableFrom = hotel.AvailableFrom;
                existingHotel.AvailableTo = hotel.AvailableTo;
                existingHotel.Images = hotel.Images;
            }
        }

        public void DeleteHotel(int id)
        {
            var hotelToDelete = _hotels.FirstOrDefault(h => h.Id == id);
            if (hotelToDelete != null)
            {
                _hotels.Remove(hotelToDelete);
            }
        }

        public List<Hotel> SearchHotels(string location, DateTime checkInDate, DateTime checkOutDate, int numberOfGuests, decimal priceRangeMin, decimal priceRangeMax)
        {
            var result = _hotels
                .Where(hotel =>
                    hotel.Location != null &&
                    hotel.Location.Equals(location, StringComparison.OrdinalIgnoreCase) &&
                    hotel.PricePerNight >= priceRangeMin &&
                    hotel.PricePerNight <= priceRangeMax)
                .ToList();

            return result;
        }

        public void AddHotel(HotelInputModel hotelInput)
        {
            throw new NotImplementedException();
        }
    }
}
