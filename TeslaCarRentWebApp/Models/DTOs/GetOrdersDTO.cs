using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TeslaCarRentWebApp.Models.DTOs
{
    public class GetOrdersDTO
    {
        public int Id { get; set; }
        public GetCarsDTO OrderedCar { get; set; } = null!;
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
