using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeslaCarRentWebApp.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int CarId { get; set; }
        [Required]
        public virtual Car OrderedCar { get; set; } = null!;
        [Required]
        public DateTime PickUpDate { get; set; }
        [Required]
        public DateTime DropOffDate { get; set; }
        [Precision(10, 2), Required]
        public decimal FinalPrice { get; set; }
    }
}
