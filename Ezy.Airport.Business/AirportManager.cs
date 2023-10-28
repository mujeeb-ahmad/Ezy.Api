using Ezy.Airport.Entities.Dtos;
using Ezy.Airport.Interfaces;

namespace Ezy.Airport.Business
{
    public class AirportManager : IAirportManager
    {
        private readonly IAirportRepository repo;

        public AirportManager(IAirportRepository repo)
        {
            this.repo = repo;
        }
        public async Task<IEnumerable<DestinationDto>> GetDestinationsAsync(string originAirportCode)
        {
            var airlineRoutes = await repo.GetDestinationsAsync(originAirportCode);
            var destDto = airlineRoutes.Select(d => new DestinationDto
            {
                DestinationAirportCode = d.DestinantionAirport
            }).ToList();
            return destDto;
        }
    }
}
