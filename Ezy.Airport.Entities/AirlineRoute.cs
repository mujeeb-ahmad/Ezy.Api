using System.ComponentModel.DataAnnotations;

namespace Ezy.Airport.Entities
{
    public class AirlineRoute: BaseEntity
    {
        [Required]
        [StringLength(10)]
        public string OriginAirportCode { get; set; }
        [Required]
        [StringLength(10)]
        public string DestinantionAirport { get; set; }
    }
}
