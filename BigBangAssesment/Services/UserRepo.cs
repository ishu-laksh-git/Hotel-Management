using BigBangAssesment.Interfaces;
using BigBangAssesment.Models;
using BigBangAssesment.Models.DTO;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace BigBangAssesment.Services
{
    public class UserRepo : IBaseRepo<string, User>
    {
        private readonly UserContext _context;

        public UserRepo(UserContext context)
        {
            _context = context;
        }

        public User add(User item)
        {
            try
            {
                _context.Users.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Debug.WriteLine(item);
            }
            return null;
        }

        public User get(string Key)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == Key);
            return user;
        }
    }
}
