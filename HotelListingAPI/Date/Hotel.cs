using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.Date
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelAdress { get; set; }
        public double HotelRating { get; set; }
        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }

        public Country Country { get; set; }

    }
}
