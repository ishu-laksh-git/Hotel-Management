using BookingAPIBB.Interfaces;
using BookingAPIBB.Models;

namespace BookingAPIBB.Services
{
    public class BookingService : IBookings
    {
        private readonly IBasic _resrepo;
        public BookingService(IBookings resrepo)
        {
            _resrepo = resrepo;
        }
        public Booking BookReservation(Booking reservation)
        {
            var reservations = _resrepo.GetAll();
            
            foreach (var item in reservations)
            {
                if (item.RoomId == reservation.RoomId && item.HotelId == reservation.HotelId)
                {
                    return _resrepo.Add(reservation);
                }
            }
            return null;
        }

        public Booking CancelReservation(Booking reservation)
        {
            return _resrepo.Delete(reservation.ID);
        }
    }
}
