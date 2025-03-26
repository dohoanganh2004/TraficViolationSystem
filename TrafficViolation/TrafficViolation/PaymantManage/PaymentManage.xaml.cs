using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TrafficViolation.BLL.Services;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.NotificationControll
{
    /// <summary>
    /// Interaction logic for NotificationsViewDetail.xaml
    /// </summary>
    public partial class NotificationsViewDetail : Window
    {
        private int _notificationId;
        private NotificationService notificationService = new NotificationService();
        private User user = App.LoggedInUser;
        public NotificationsViewDetail(int notificationId)
        {
            InitializeComponent();
            _notificationId= notificationId;
            LoadUserNotification();
        }

        void LoadUserNotification()
        {
            var notification = notificationService.GetNotificationByUserId(user.UserId, _notificationId);
            dgNotification.ItemsSource = new List<Notification> { notification };
        }


    }
}
