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


        public void EditReport(Report report)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            context.Reports.Update(report);
            context.SaveChanges();
        }

        public bool AddReport(Report report)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            try
            {
                context.Reports.Add(report);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Delete report by ID
        public bool DeleteReport(int id)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            try
            {
                var report = context.Reports.Find(id);
                if (report == null) return false;

                context.Reports.Remove(report);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Report> GetAllReportsByReporterId(int reporterId)
        {
            using (TrafficViolationContext context = new TrafficViolationContext())
            {
                return context.Reports
                              .Where(r => r.ReporterId == reporterId)
                              .Include(r => r.Reporter) // Nếu cần thông tin của người báo cáo
                              .ToList();
            }
        }
        public List<Report> GetAllReportsByUserID(int reportId)
        {
            using (TrafficViolationContext context = new TrafficViolationContext()) 
            {
                return context.Reports.Where(r => r.ReporterId == reportId).ToList();
            }
        }
        public void UpdateReport(Report report)
        {
            using (TrafficViolationContext context = new TrafficViolationContext())
            {
                var existingReport = context.Reports.FirstOrDefault(r => r.ReportId == report.ReportId);
                if (existingReport != null)
                {
                    existingReport.ViolationType = report.ViolationType;
                    existingReport.Description = report.Description;
                    existingReport.PlateNumber = report.PlateNumber;
                    existingReport.Location = report.Location;
                    existingReport.ReportDate = report.ReportDate;
                    existingReport.Status = report.Status;

                    context.SaveChanges();
                }
            }
        }
        public void DelelteReport(int reportId)
        {
            using (TrafficViolationContext context = new TrafficViolationContext())
            {
                var report = context.Reports.Find(reportId);
                if (report != null)
                {
                    context.Reports.Remove(report);
                    context.SaveChanges();
                }
            }
        }
            
        
        public bool AddReportByUser3(Report report)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            try
            {
                context.Reports.Add(report);
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
