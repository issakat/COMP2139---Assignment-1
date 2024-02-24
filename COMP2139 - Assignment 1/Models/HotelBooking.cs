namespace COMP2139___Assignment_1.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }
        public string? GuestName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
