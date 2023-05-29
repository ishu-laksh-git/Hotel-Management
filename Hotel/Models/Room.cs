using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Room
    {
        [Key]
        public int Room_id { get; set; }
        //public int Hotel_id { get; set; }
        //[ForeignKey("Hotel_id")]
        public Hotel? Hotels { get; set; }
        public double Price { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
