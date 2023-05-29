using BookingAPIBB.Models;

namespace BookingAPIBB.Interfaces
{
    public interface IBookings
    {
        Booking BookReservation(Booking reservation);
        Booking CancelReservation(Booking reservation);
    }
}
