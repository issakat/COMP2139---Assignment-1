using COMP2139___Assignment_1.Controllers;

namespace COMP2139___Assignment_1.Models
{
    public class FlightBooking
    {
        public int Id { get; set; }
        public string? FlightNumber { get; set; }
        public string? DepartureCity { get; set; }
        public string? ArrivalCity { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int NumberOfPassengers { get; set; }
        public string? ContactPerson { get; set; }
    }
}
