using Ezy.Airport.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezy.Airport.Interfaces
{
    public interface IAirportManager
    {
        Task<IEnumerable<DestinationDto>> GetDestinationsAsync(string originAirportCode);
    }
}
