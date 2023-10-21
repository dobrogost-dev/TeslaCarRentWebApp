using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeslaCarRentWebApp.Models
{
    [Table("Car")] 
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; } = null!;
        [Required]
        public int NumberOfSeats { get; set; }
        [Precision(10, 2), Required]
        public decimal Price { get; set; }
    }
}
