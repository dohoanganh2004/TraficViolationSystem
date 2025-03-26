using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.DAL.Repositories
{
    public class PaymentRepository
    {
        public List<Payment> GetAll()
        {
           TrafficViolationContext context = new TrafficViolationContext();
            return context.Payments.ToList();
        }
    }
}
