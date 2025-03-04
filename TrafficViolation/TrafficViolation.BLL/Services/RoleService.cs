using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Models;
using TrafficViolation.DAL.Repositories;

namespace TrafficViolation.BLL.Services
{

  
    public class RoleService
    {
        private RoleRepository _roleRepository = new();

        // Get All Role
        public List<Role> getAllRole()
        {
            return _roleRepository.GetRoles();

        }
    }
}
