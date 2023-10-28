using Ezy.Airport.Api.Error;
using Ezy.Airport.Api.Extensions;
using Ezy.Airport.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Ezy.Airport.Api.Controllers
{
    public class AirportController : BaseController
    {
        private readonly IAirportManager airportManager;

        public AirportController(IAirportManager airportManager)
        {
            this.airportManager = airportManager;
        }
        // GET api/airport/getdestinations
        [HttpGet("GetDestinations/{originAirportCode}")]
        public async Task<IActionResult> GetDestinations(string originAirportCode)
        {
            //Input validations
            if (originAirportCode.IsEmpty() 
                || originAirportCode.Trim().Length < 3 || originAirportCode.Trim().Length > 10 
                || originAirportCode.Trim().All(Char.IsLetter) == false)
            {
                var apiError = new ApiError(
                    (int)HttpStatusCode.BadRequest,
                    "Origin airport code is invalid",
                    "Airport code must be alphabets only and minimum of 3 characters and maximum of 10 characters long"
                    );
                return BadRequest(apiError);
            }

            //Get destinations by origin airport code
            var destinationsDto = await airportManager.GetDestinationsAsync(originAirportCode.Trim());

            //If data not found
            if (destinationsDto == null || destinationsDto.Count() == 0)
            {
                var apiError = new ApiError(
                    (int)HttpStatusCode.NotFound,
                    "Destination airport codes not found"
                    );
                return NotFound(apiError);
            }
            return Ok(destinationsDto);
        }
    }
}
