﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Models;
using TrafficViolation.DAL.Repositories;

namespace TrafficViolation.BLL.Services
{

    
    public class ViolationService
    {
        private ViolationReponsitory violationReponsitory = new();


        public List<Violation> GetAllViolation()
        {
             
            return violationReponsitory.GetAllViolations();
        }

        public void AddViolation(Violation violation)
        {
             violationReponsitory.AddViolation(violation);
        }

        public void UpdateViolation(Violation violation)
        {
            violationReponsitory.UpdateViolation(violation);
        }
        public List<Violation> GetAllViolationById(int violationId)
        {

            return violationReponsitory.GetViolationsById(violationId);
        }
        public void UpdateViolationPay(Violation violation)
        {
            violationReponsitory.UpdateViolationPay(violation);
        }
    }


}
