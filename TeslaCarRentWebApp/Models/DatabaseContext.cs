using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace TeslaCarRentWebApp.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    Model = "Tesla S",
                    NumberOfSeats = 5,
                    Price = 120
                },
                new Car
                {
                    Id = 2,
                    Model = "Tesla 3",
                    NumberOfSeats = 5,
                    Price = 150
                }, new Car
                {
                    Id = 3,
                    Model = "Tesla X",
                    NumberOfSeats = 5,
                    Price = 140
                },
                new Car
                {
                    Id = 4,
                    Model = "Tesla Y",
                    NumberOfSeats = 5,
                    Price = 200
                }

            };
            var orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    CarId = 1,
                    PickUpDate = DateTime.Now,
                    DropOffDate = DateTime.Now,
                    FinalPrice = 0
                }

            };
            //modelBuilder.Entity<Car>().Property(p => p.Price).HasColumnType("decimal(18,2)");
            //modelBuilder.Entity<Order>().Property(p => p.FinalPrice).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Car>().HasData(cars);
            modelBuilder.Entity<Order>().HasData(orders);

        }
    }
}
