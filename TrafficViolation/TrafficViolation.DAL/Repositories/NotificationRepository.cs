using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.DAL.Repositories
{
    public  class NotificationRepository
    {
        public List<Notification> GetAllNotification()
        {
            TrafficViolationContext context = new TrafficViolationContext();
            return context.Notifications.Include(u => u.User).ToList();
        }

        public void AddNotification(int userID, string message ,string plateNumber) {
            TrafficViolationContext context = new TrafficViolationContext();
            Notification notification = new Notification()
            {
                UserId = userID,
                Message = message,
                PlateNumber = plateNumber,
                SentDate = DateTime.Now,
                IsRead = false,

            };
            context.Notifications.Add(notification);
            context.SaveChanges();
        }


        public void EditNotification(Notification notification)
        {
            TrafficViolationContext context = new TrafficViolationContext();
            context.Notifications.Update(notification);
            context.SaveChanges();
        }
    }
}
