using HotelsAPI.Interfaces;
using HotelsAPI.Models;
using HotelsAPI.Models.DTO;

namespace HotelsAPI.Services
{
    public class HotelServices : IHotel
    {
        private readonly IBasic<Hotel, int> _hotelRepo;
        private readonly IBasic<Room,int> _roomRepo;

        public HotelServices(IBasic<Hotel,int> hotelrepo,IBasic<Room,int> RoomRepo)
        {
            _hotelRepo = hotelrepo;
            _roomRepo = RoomRepo;
        }
        public Hotel AddHotel(Hotel hotel)
        {
            var hotels = _hotelRepo.GetAll();
            foreach (var h in hotels)
            {
                if (hotel.Equals(h))
                    return null;
            }
            return _hotelRepo.Add(hotel);
        }

        public Room AddRoom(Room room)
        {
            var htl = _hotelRepo.Get(room.HotelId);
            if (htl != null)
            {
                return _roomRepo.Add(room);
                return room;
            }
            return null;
        }

        public Room DelRoom(Room room)
        {
            return _roomRepo.Delete(room);
        }

        public Hotel DelteHotel(Hotel hotel)
        {
            var rooms = _roomRepo.GetAll().Where(r => r.HotelId == hotel.Id).ToList();
            foreach (var room in rooms)
            {
                _roomRepo.Delete(room);
            }
            return _hotelRepo.Delete(hotel);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepo.GetAll().ToList();
        }

        public List<Room> GetAllRooms(Hotel hotel)
        {
            return _roomRepo.GetAll().Where(r => r.HotelId == hotel.Id).ToList();
        }

        public List<Room> GetRoomsByAC(Hotel hotel)
        {
            return _roomRepo.GetAll().Where(r => r.HotelId == hotel.Id && r.Type == "AC").ToList();
        }

        public List<Hotel> SortHotelByCity(HotelFilters hotelFilterDTO)
        {
            return _hotelRepo.GetAll().Where(h => h.City == hotelFilterDTO.City).ToList();
        }

        public List<Room> SortRoomsByPrice(RoomFilters roomFiltersDTO)
        {
            return _roomRepo.GetAll().Where(r => r.HotelId == roomFiltersDTO.HotelId && r.Price >= roomFiltersDTO.MinPrice && r.Price <= roomFiltersDTO.MaxPrice).ToList();
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepo.Update(hotel);
        }

        public Room UpdateRoom(Room room)
        {
            return _roomRepo.Update(room);
        }
    }
}
