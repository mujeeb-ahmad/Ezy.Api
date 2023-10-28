using Ezy.Airport.Entities;
using Ezy.Airport.Interfaces;
using Ezy.Airport.Repository.Data;
using Microsoft.EntityFrameworkCore;

namespace Ezy.Airport.Repository
{
    public class AirportRepository : IAirportRepository
    {
        private readonly DataContext dataContext;

        public AirportRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task<IEnumerable<AirlineRoute>> GetDestinationsAsync(string originAirportCode)
        {
            return await dataContext.AirlineRoutes.Where(ar => ar.OriginAirportCode == originAirportCode).ToListAsync();            
        }
    }
}
