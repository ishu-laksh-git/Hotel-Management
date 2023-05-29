using HotelsAPI.Interfaces;
using HotelsAPI.Models;

namespace HotelsAPI.Services
{
    public class HotelRepo : IBasic<Hotel, int>
    {
        private readonly HotelContext _context;
        public HotelRepo(HotelContext context)
        {
            _context = context;
        }
        public Hotel Add(Hotel item)
        {
            _context.Hotels.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Hotel Delete(Hotel item)
        {
            var hotel = _context.Hotels.SingleOrDefault(h => h.Id == item.Id);
            if (hotel != null)
            {
                _context.Hotels.Remove(hotel);
                _context.SaveChanges();
            }
            return hotel;
        }

        public Hotel Get(int id)
        {
            return _context.Hotels.SingleOrDefault(h => h.Id == id);
        }

        public ICollection<Hotel> GetAll()
        {
            return _context.Hotels.ToList();
        }

        public Hotel Update(Hotel item)
        {
            var htl= _context.Hotels.SingleOrDefault(h=>h.Id == item.Id);
            if (htl != null)
            {
                htl.Phone = item.Phone;
                htl.City = item.City;
                htl.Country=item.Country;
                htl.Phone = item.Phone;
                _context.SaveChanges();
                return htl;
            }
            return null;
        }
    }
}
