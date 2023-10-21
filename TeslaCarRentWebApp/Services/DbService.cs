using Microsoft.EntityFrameworkCore;
using TeslaCarRentWebApp.Models;
using TeslaCarRentWebApp.Models.DTOs;

namespace TeslaCarRentWebApp.Services
{
    public interface IDbService
    {
        Task<ICollection<GetOrdersDTO>> GetOrdersData();
        Car GetCarById(int id);
    }
    public class DbService : IDbService
    {
        private readonly DatabaseContext _databaseContext;

        public DbService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Car GetCarById(int id)
        {
            return _databaseContext.Cars.Select(c => c).Where(c => c.Id == id).FirstOrDefault();
        }

        public async Task<ICollection<GetOrdersDTO>> GetOrdersData()
        {
            var orders =  await _databaseContext.Orders.ToListAsync();
            var ordersDTO = new List<GetOrdersDTO>();
            orders.ForEach(o => ordersDTO.Add(
                new GetOrdersDTO
                {
                    Id = o.Id,
                    OrderedCar = new GetCarsDTO
                    {
                        Id = o.CarId,
                        Model = GetCarById(o.CarId).Model,
                        NumberOfSeats = GetCarById(o.CarId).NumberOfSeats,
                        Price = GetCarById(o.CarId).Price
                    },
                    PickUpDate = o.PickUpDate,
                    DropOffDate = o.DropOffDate,
                    FinalPrice = o.FinalPrice
                }
                ));
            return ordersDTO;

        }
    }
}
