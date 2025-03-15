using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.DAL.Repositories
{
    public class ReportRepository
    {
        public List<Report> GetAllReport()
        {
            TrafficViolationContext context = new TrafficViolationContext();
            return context.Reports.Include(r => r.Reporter).Include(r => r.ProcessedByNavigation).ToList();
        }

        public Report? GetReportByID(int id)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            return context.Reports.Where(r => r.ReportId == id).FirstOrDefault();
        }

        public void UpdateReport(Report report)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            context.Reports.Update(report);
            context.SaveChanges();
        }

    }
}
