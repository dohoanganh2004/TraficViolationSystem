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
        public User? ViewProfile(int id)
        {
            return _repository.GetUserByID(id);

        }

    }
}
