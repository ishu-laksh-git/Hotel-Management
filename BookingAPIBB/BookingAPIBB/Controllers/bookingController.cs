using BookingAPIBB.Interfaces;
using BookingAPIBB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingAPIBB.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class bookingController : ControllerBase
    {
        private IBookings _bookings;
        public bookingController(IBookings bookings)
        {
            _bookings = bookings;
        }
        [HttpPost]
       
        public IActionResult BookReservation([FromBody] Booking reservation)
        {
            var result = _bookings.BookReservation(reservation);
            if (result == null)
            {
                return BadRequest(new { message = "Room is not available" });
            }
            return Ok(result);
        }
        [HttpDelete]

        public IActionResult CancelReservation([FromBody] Booking reservation)
        {
            var result = _bookings.CancelReservation(reservation);
            if (result == null)
            {
                return BadRequest(new { message = "Reservation is not available" });
            }
            return Ok(result);
        }
    }
}
