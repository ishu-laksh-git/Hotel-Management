using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Hotel
    {
        
        [Key]
        public int Hotel_id { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Amenities { get; set; }
        [Required]
        public int stars { get; set; }

    }
}
