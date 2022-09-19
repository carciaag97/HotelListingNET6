namespace HotelListingAPI.Date
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryShortName { get; set; }
        public virtual IList<Hotel> Hotels { get; set; }
    }
}