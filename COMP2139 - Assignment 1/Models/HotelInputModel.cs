namespace COMP2139___Assignment_1.Models
{
    public class HotelInputModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public decimal PricePerNight { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
    }
}
