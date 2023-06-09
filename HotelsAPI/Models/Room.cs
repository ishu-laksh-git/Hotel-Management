﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HotelsAPI.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        [ForeignKey("Hotels")]
        public Hotel? Hotel { get; set; }
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
    }
}
