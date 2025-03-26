using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Models;
using TrafficViolation.DAL.Repositories;

namespace TrafficViolation.BLL.Services
{
    public  class ReportService
    {
        private ReportRepository reportRepository = new ReportRepository();
        // Get All Report
        public List<Report> GetAllReport()
        {
            return reportRepository.GetAllReport();
        }

        // Get Report By ID
        private Report? GetReportByID(int id)
        {
            return reportRepository.GetReportByID(id);
        }



        public void UpdateReport(Report report)
        {
            reportRepository.UpdateReport(report);
        }
        public bool ReportAdd(Report report)
        {
            return reportRepository.AddReport(report);
        }

        // Delete report by ID
        public bool DeleteReport(int id)
        {
            return reportRepository.DeleteReport(id);
        }

        public List<Report> GetAllReportsByUserID(int userId)
        {
            return reportRepository.GetAllReportsByReporterId(userId);
        }
       
        public bool AddReport(Report report) 
        {
            return reportRepository.AddReportByUser3(report);

        }

        public Report GetReportByReportId(int reportId)
        {
            return reportRepository.GetReportByReportId(reportId);
        }

    }
}
