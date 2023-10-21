namespace TeslaCarRentWebApp.Models.DTOs
{
    public class GetCarsDTO
    {
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public int NumberOfSeats { get; set; }
        public decimal Price { get; set; }
    }
}
