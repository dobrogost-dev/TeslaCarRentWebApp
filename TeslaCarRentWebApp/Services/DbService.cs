using TeslaCarRentWebApp.Models;

namespace TeslaCarRentWebApp.Services
{
    public interface IDbService
    {

    }
    public class DbService : IDbService
    {
        private readonly DatabaseContext _databaseContext;

        public DbService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
    }
}
