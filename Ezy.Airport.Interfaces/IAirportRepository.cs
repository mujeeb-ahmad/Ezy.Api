using Ezy.Airport.Entities;

namespace Ezy.Airport.Interfaces
{
    public interface IAirportRepository
    {
        Task<IEnumerable<AirlineRoute>> GetDestinationsAsync(string originAirportCode);
    }
}
