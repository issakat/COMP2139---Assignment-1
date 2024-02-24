using COMP2139___Assignment_1.Models;

namespace COMP2139___Assignment_1.Interface
{
    public interface IHotelService
    {
        List<Hotel> GetHotelListings();
        Hotel GetHotelById(int id);
        void AddHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);
        List<Hotel> SearchHotels(string location, DateTime checkInDate, DateTime checkOutDate, int numberOfGuests, decimal priceRangeMin, decimal priceRangeMax);
    }
}
