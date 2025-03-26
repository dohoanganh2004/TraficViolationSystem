using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.DAL.Repositories
{
    public class ViolationReponsitory
    {
        public List<Violation> GetAllViolations()
        {
            TrafficViolationContext context = new TrafficViolationContext();
            return context.Violations.Include(v => v.Report).Include(v => v.Violator).ToList();
        }

        public void AddViolation(Violation violation)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            context.Violations.Add(violation);
            context.SaveChanges();

            
        }

        public void UpdateViolation(Violation violation)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            context.Violations.Update(violation);
            context.SaveChanges();
        }

        public List<Violation> GetViolationsById(int violatorId)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            return context.Violations.Where(a=> a.ViolatorId == violatorId).ToList();

        }
        public void UpdateViolationPay(Violation violation)
        {
            using (var context = new TrafficViolationContext())
            {
                context.Violations.Update(violation);
                context.SaveChanges(); 
            }
        }





    }
}
