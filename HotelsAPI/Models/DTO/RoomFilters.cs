namespace HotelsAPI.Models.DTO
{
    public interface RoomFilters
    {
        public int HotelId { get; set; }
        public int Capacity { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
    }
}
