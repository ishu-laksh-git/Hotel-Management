using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelsAPI.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string amenities { get; set; }


    }
}
