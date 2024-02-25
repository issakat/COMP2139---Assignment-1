using COMP2139___Assignment_1.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP2139___Assignment_1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<CarRental> CarRentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Flight>().HasData(
                new Flight { Id = 10, FlightNumber = "TOCA123", DepartureCity = "Toronto", ArrivalCity = "Calgary", DepartureDate = DateTime.Now, ArrivalDate = DateTime.Now.AddHours(4), Price = 250.00m },
                new Flight { Id = 20, FlightNumber = "VAMO111", DepartureCity = "Vancouver", ArrivalCity = "Montreal", DepartureDate = DateTime.Now, ArrivalDate = DateTime.Now.AddHours(5), Price = 290.00m },
                new Flight { Id = 30, FlightNumber = "MOVA222", DepartureCity = "Montreal", ArrivalCity = "Vancouver", DepartureDate = DateTime.Now, ArrivalDate = DateTime.Now.AddHours(6), Price = 300.00m },
                new Flight { Id = 40, FlightNumber = "CATO333", DepartureCity = "Calgary", ArrivalCity = "Toronto", DepartureDate = DateTime.Now, ArrivalDate = DateTime.Now.AddHours(4), Price = 280.00m }

            );

            modelBuilder.Entity<CarRental>().HasData(
                new CarRental { Id = 1234, CarModel = "Sedan", PickupLocation = "Toronto", DropOffLocation = "Calgary", PickupDate = DateTime.Now, DropOffDate = DateTime.Now.AddDays(4), DailyRate = 50.00m },
                new CarRental { Id = 4567, CarModel = "SUV", PickupLocation = "Vancouver", DropOffLocation = "Montreal", PickupDate = DateTime.Now, DropOffDate = DateTime.Now.AddDays(6), DailyRate = 60.00m },
                new CarRental { Id = 7890, CarModel = "Civic", PickupLocation = "Montreal", DropOffLocation = "Vancouver", PickupDate = DateTime.Now, DropOffDate = DateTime.Now.AddDays(5), DailyRate = 45.00m },
                new CarRental { Id = 2468, CarModel = "Integra", PickupLocation = "Calgary", DropOffLocation = "Toronto", PickupDate = DateTime.Now, DropOffDate = DateTime.Now.AddDays(5), DailyRate = 65.00m }

            );
        }
    }

}
