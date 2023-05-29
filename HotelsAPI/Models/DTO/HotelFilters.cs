namespace HotelsAPI.Models.DTO
{
    public class HotelFilters
    {
        public string Country { get; set; }
        public string City { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }

        public string amenity { get; set; }
    }
}
