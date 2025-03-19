using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficViolation.DAL.Models;
using TrafficViolation.DAL.Repositories;

namespace TrafficViolation.BLL.Services
{
    public  class NotificationService
    {
        private NotificationRepository _notificationRepository = new NotificationRepository();


        public List<Notification> GetAll()
        {
            return _notificationRepository.GetAllNotification();
        }
        public void SendNotification(int userID,string message,string plateNumber)
        {
        _notificationRepository.AddNotification(userID,message,plateNumber);
        }

        public void  EditNotification(Notification notification) { 
            _notificationRepository.EditNotification(notification);
        }
        public List<Notification> GetNoficationById(int userId)
        {
            return _notificationRepository.GetAllNotificationByUserId(userId);
        }
    }
}
