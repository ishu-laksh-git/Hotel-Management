using Microsoft.EntityFrameworkCore;

namespace Hotel.Models
{
    public class HotelContextcs:DbContext
    {
        public HotelContextcs(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Hotel> Hotels { get; set; }
        //public DbSet<Room> Rooms { get; set; }
    }
}
