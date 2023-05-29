using HotelsAPI.Models;

namespace HotelsAPI.Interfaces
{
    public interface IHotel:IFilters
    {
        Hotel AddHotel(Hotel hotel);
        List<Hotel> GetAllHotels();

        Hotel DelteHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);

        Room AddRoom(Room room);
        Room DelRoom(Room room);
        List<Room> GetAllRooms(Hotel hotel);
        Room UpdateRoom(Room room);
    }
}
