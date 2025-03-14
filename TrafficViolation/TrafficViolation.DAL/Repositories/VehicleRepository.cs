using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.DAL.Repositories
{
    public  class VehicleRepository
    {
        public string GetOwnerByPlateNumber(string plateNumber)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            var vehicle = context.Vehicles
             .Include(v => v.Owner) 
             .FirstOrDefault(v => v.PlateNumber == plateNumber);

             return vehicle?.Owner?.FullName ?? "Không tìm thấy";
        }

        public int GetOnerIDByPlateNumber(string plateNumber) {
            TrafficViolationContext context = new TrafficViolationContext();
            var vehicle = context.Vehicles.Include(v => v.Owner).FirstOrDefault(v => v.PlateNumber == plateNumber);
            return vehicle?.Owner?.UserId ?? 0;

                }

    }
}
