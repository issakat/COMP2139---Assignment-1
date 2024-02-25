namespace COMP2139___Assignment_1.Models
{
    public class CarRental
    {
        public int Id { get; set; }
        public string? CarModel { get; set; }
        public string? PickupLocation { get; set; }
        public string? DropOffLocation { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public decimal DailyRate { get; set; }
    }
}
