using HotelsAPI.Interfaces;
using HotelsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HotelsAPI.Models.DTO;

namespace HotelsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotel _hotelAction;
        public HotelController(IHotel htl)
        {
            _hotelAction = htl;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Hotel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetHotelsList()
        {
            var htls = _hotelAction.GetAllHotels();
            if (htls.Count == 0)
            {
                return BadRequest(new { message = "No hotels available :(" });
            }
            return Ok(htls);
        }


        [HttpPost]
        [ProducesResponseType(typeof(Hotel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddAHotel([FromBody] Hotel hotel)
        {
            var result = _hotelAction.AddHotel(hotel);
            if (result == null)
            {
                return BadRequest(new { message = "Hotel already exists" });
            }
            return Ok(result);
        }



        [HttpPut]
        [ProducesResponseType(typeof(Hotel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateHotelDetails([FromBody] Hotel hotel)
        {
            var htl = _hotelAction.UpdateHotel(hotel);
            if (htl == null)
            {
                return BadRequest(new { message = "Hotel is not available" });
            }
            return Ok(htl);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Hotel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteHotel([FromBody] Hotel hotel)
        {
            var result = _hotelAction.DelteHotel(hotel);
            if (result == null)
            {
                return BadRequest(new { message = "Hotel is not available :(" });
            }
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Room), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddRoom([FromBody] Room room)
        {
            var result = _hotelAction.AddRoom(room);
            if (result == null)
            {
                return BadRequest(new { message = "No hotel found!" });
            }
            return Ok(result);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Room), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateRoomDetails([FromBody] Room room)
        {
            var result = _hotelAction.UpdateRoom(room);
            if (result == null)
            {
                return BadRequest(new { message = "Room not Exist" });
            }
            return Ok(result);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Room), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteRoom([FromBody] Room room)
        {
            var result = _hotelAction.DelRoom(room);
            if (result == null)
            {
                return BadRequest(new { message = "Room not Exist" });
            }
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Room), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<Room>> GetAllRooms([FromBody] Hotel hotel)
        {
            var result = _hotelAction.GetAllRooms(hotel);
            if (result.Count == 0)
            {
                return BadRequest(new { message = "No rooms available" });
            }
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<Hotel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<Hotel>> GetHotelByCity([FromBody] HotelFilters hotelFilterDTO)
        {
            var result = _hotelAction.SortHotelByCity(hotelFilterDTO);
            if (result.Count == 0)
            {
                return BadRequest(new { message = "No Hotel available" });
            }
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<Room>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<Room>> GetRoomsByAC([FromBody] Hotel hotel)
        {
            var result = _hotelAction.GetRoomsByAC(hotel);
            if (result.Count == 0)
            {
                return BadRequest(new { message = "No Rooms available" });
            }
            return Ok(result);
        }
    
        

    }
}
