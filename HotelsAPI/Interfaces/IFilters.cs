using HotelsAPI.Models;
using HotelsAPI.Models.DTO;

namespace HotelsAPI.Interfaces
{
    public interface IFilters
    {
        List<Hotel> SortHotelByCity(HotelFilters hotelFilterDTO);
        List<Room> GetRoomsByAC(Hotel hotel);
    }
}
