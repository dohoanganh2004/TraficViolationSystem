using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.DAL.Repositories
{
    public class RoleRepository
    {
        public List<Role> GetRoles()
        {
           TrafficViolationContext context = new TrafficViolationContext();
            return context.Roles.ToList();
        }
    }
}
