using COMP2139___Assignment_1.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace COMP2139___Assignment_1.Data
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options)
        {
        }

        public DbSet<HotelBooking> HotelBookings { get; set; }
    }
}
