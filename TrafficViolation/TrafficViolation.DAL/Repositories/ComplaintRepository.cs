using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.DAL.Repositories
{
    public class ComplaintRepository
    { 
        public List<Complaint> GetAllComplaint()
        {
            TrafficViolationContext context = new TrafficViolationContext();
            return context.Complaints.Include(u => u.User).Include(r => r.Report).
                Include(v => v.Violation).Include(p => p.ProcessedByNavigation).ToList();
        }
    }
}
