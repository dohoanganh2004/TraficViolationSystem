using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace TrafficViolation.DAL.Repositories
{
    public class ComplaintRepository
    {

        public List<Complaint> GetComplaintsByUserID(int userId)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            return context.Complaints.Where(a=> a.UserId==userId).ToList();
        }
        
    }
}
