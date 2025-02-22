using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.DAL.Repositories
{
    public class UserRepository
    {
        // Get user by phone and password
        public User? GetUserByPhoneAndPassword(string phoneNumber,string password)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            User user = new User();
            user = context.Users.Where(u => u.Phone == phoneNumber && u.Password == password).FirstOrDefault();
            return user;
        }
        
    }
}
