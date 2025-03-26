using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrafficViolation.DAL.Models;

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


    { 
        public List<Complaint> GetAllComplaint()
        {
            TrafficViolationContext context = new TrafficViolationContext();
            return context.Complaints.Include(u => u.User).Include(r => r.Report).
                Include(v => v.Violation).Include(p => p.ProcessedByNavigation).ToList();
        }

        public void Update(Complaint complaint)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            context.Update(complaint);
            context.SaveChanges();
        }


        public void CreateComplaint(Complaint complaint)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            context.Add(complaint);
            context.SaveChanges();  

        }
    }
}
