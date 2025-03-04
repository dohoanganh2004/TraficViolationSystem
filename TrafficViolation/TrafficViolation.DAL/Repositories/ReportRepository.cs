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
            return context.Reports.Include(r => r.Reporter).ToList();
        }

        public Report? GetReportByID(int id)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            return context.Reports.Where(r => r.ReportId == id).FirstOrDefault();
        }
    }
}
