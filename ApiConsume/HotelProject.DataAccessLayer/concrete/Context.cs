using HotelProject.EntityLayer.concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Omer-Diricanli\\SQLEXPRESS; initial catalog=ApiDb; integrated security=true; TrustServerCertificate=True ");
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
