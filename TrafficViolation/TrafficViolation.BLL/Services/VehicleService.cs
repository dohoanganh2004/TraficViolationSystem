using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Repositories;

namespace TrafficViolation.BLL.Services
{
    public class VehicleService
    {
        private VehicleRepository vehicleRepository = new VehicleRepository();
        public string GetUserByPlateNumber(string plateNumber)
        {
            return vehicleRepository.GetOwnerByPlateNumber(plateNumber);
        }


        public int GetUserIDByPlateNumber(string plateNumber)
        {
            return vehicleRepository.GetOnerIDByPlateNumber(plateNumber);
        }
    }
}
