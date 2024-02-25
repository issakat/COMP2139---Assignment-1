namespace COMP2139___Assignment_1.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string? FlightNumber { get; set; }
        public string? DepartureCity { get; set; }
        public string? ArrivalCity { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public decimal Price { get; set; }
    }
}
