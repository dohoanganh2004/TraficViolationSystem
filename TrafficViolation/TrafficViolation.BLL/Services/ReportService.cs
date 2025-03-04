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
    }
}
