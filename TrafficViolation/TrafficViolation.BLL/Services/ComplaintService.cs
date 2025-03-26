using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Models;
using TrafficViolation.DAL.Repositories;

namespace TrafficViolation.BLL.Services
{
    public class ComplaintService
    {
        private ComplaintRepository complaintRepository = new ComplaintRepository();

        public List<Complaint> GetAllComplaint()
        {
            return complaintRepository.GetAllComplaint();
        }


        public void UpdateComplaint(Complaint complaint)
        {
            complaintRepository.Update(complaint);
        }


        public void CreateComplaint(Complaint complaint)
        {
            complaintRepository.CreateComplaintt(complaint); 
        }
    }
}
