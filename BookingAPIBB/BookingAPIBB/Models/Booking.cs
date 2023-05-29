using System.ComponentModel.DataAnnotations;

namespace BookingAPIBB.Models
{
    public class Booking
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string HotelId { get; set; }
        public string RoomId { get; set; }
        public DateTime date { get; set; }
    }
}
