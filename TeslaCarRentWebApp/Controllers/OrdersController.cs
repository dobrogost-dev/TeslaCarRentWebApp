using Microsoft.AspNetCore.Mvc;
using TeslaCarRentWebApp.Services;

namespace TeslaCarRentWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IDbService _dbService;

        public OrdersController(IDbService dbService)
        {
            _dbService = dbService;
        }


        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _dbService.GetOrdersData();
            return Ok(orders);
        }
    }
}