﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Models;
using TrafficViolation.DAL.Repositories;

namespace TrafficViolation.BLL.Services
{
   
    public class ComplaintsService
    {
    private ComplaintRepository complaintRepository = new ComplaintRepository();
        public List<Complaint> GetComplaints(int userId) 
        { 
        return complaintRepository.GetComplaintsByUserID(userId);
        }
    }
}
