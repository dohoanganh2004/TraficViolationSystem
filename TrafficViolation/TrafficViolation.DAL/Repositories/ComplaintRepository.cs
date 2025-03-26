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

        public Complaint GetComplaintById(int complaintId) 
        {
            TrafficViolationContext context = new TrafficViolationContext();
            return context.Complaints.Where(a => a.ComplaintId == complaintId).FirstOrDefault();
        }
        public bool CreateComplaint(Complaint complaint)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            try
            {
                context.Complaints.Add(complaint);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
