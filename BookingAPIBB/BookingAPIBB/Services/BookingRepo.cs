using BookingAPIBB.Interfaces;
using BookingAPIBB.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BookingAPIBB.Services
{
    public class BookingRepo : IBasic<Booking, int>
    {
        private BookingContext _context;
        public BookingRepo(BookingContext context)
        {
            _context = context;
        }
        public Booking Add(Booking item)
        {
            try
            {
                _context.Bookings.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public Booking Delete(int id)
        {
            var reservation = _context.Bookings.SingleOrDefault(r => r.ID == id);
            if (reservation != null)
            {
                _context.Bookings.Remove(reservation);
                _context.SaveChanges();
            }
            return reservation;
        }

        public Booking Get(int id)
        {
            return _context.Bookings.SingleOrDefault(r => r.ID == id);
        }

        public ICollection<Booking> GetAll()
        {
            return _context.Bookings.ToList();
        }

    }
}
