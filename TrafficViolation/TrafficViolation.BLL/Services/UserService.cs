using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Models;
using TrafficViolation.DAL.Repositories;

namespace TrafficViolation.BLL.Services
{
    public class UserService
    {
        
        private UserRepository _repository = new();

        public User? GetUserByPhoneAndPassword(string phone, string password)
        {
            return _repository.GetUserByPhoneAndPassword(phone, password);

        }


        // Get User By ID
        public User? GetUserByID(int id)
        {
            return _repository.GetUserByID(id);

        }
        // get All User 
        public List<User> getAllUser()
        {
            return _repository.getAllUser();

        }

        public  void UpdateProfile(User user)
        {
             _repository.UpdateUser(user);
        }

        public void CreateUser(User user)
        {
            _repository.AddUser(user);
        }

        public User? GetUserByPhoneAndEmail(string phone, string email)
        {
            return _repository.GetUserByPhoneAndEmail(phone, email);
        }

        public void UpdateUser(User user)
        {
            _repository.UpdateUser(user);
        }

        public string GetUserImage(int userId)
        {
            return _repository.GetUserImage(userId);
        }

    }
}
