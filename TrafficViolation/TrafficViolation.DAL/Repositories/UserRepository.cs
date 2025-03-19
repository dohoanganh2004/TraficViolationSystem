using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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

        // Get User By ID
        public User? GetUserByID(int id)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            User user = new User();
            user = context.Users.Where(u => u.UserId == id).FirstOrDefault();
            return user;

        }
        // Get all Customer
        public List<User> getAllUser()
        {
            TrafficViolationContext context = new TrafficViolationContext();
            return context.Users.Include(u => u.Role).ToList();
        }
        // Update User
        public  void UpdateUser(User user)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            context.Users.Update(user);
            context.SaveChanges();
        }
        public  void AddUser(User user)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            context.Users.Add(user);
            context.SaveChanges();
        }

       

        public User? GetUserByPhoneAndEmail(string phoneNumber, string email)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            User user = new User();
            user = context.Users.Where(u => u.Phone == phoneNumber && u.Email== email).FirstOrDefault();
            return user;
        }

        public String GetUserImage(int userId)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            var user = context.Users.FirstOrDefault(u => u.UserId == userId);
            return user?.Image;
        }


    }
}
