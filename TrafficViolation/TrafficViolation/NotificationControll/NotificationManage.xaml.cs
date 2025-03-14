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
    /// Interaction logic for NotificationManage.xaml
    /// </summary>
    public partial class NotificationManage : Window
    {
        private NotificationService notificationService = new NotificationService();
        public NotificationManage()
        {
            InitializeComponent();
            LoadDataGirdNotification();
        }

        public void LoadDataGirdNotification()
        {
            var notification = notificationService.GetAll();
            this.dgNotifications.ItemsSource = notification;

        }

        private void dgNotifications_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Notification notification = dgNotifications.SelectedItem as Notification;
            if (notification != null) { 
                txtNotificationID.Text = notification.NotificationId.ToString();
                txtUserId.Text = notification.UserId.ToString();
                txtUser.Text = notification.User.FullName;
                txtPlateNumber.Text = notification.PlateNumber;
                txtMassage.Text = notification.Message;
                txtSendDate.Text = notification.SentDate.ToString();
                if (notification.IsRead.GetValueOrDefault()) 
                {
                    rbRead.IsChecked = true;
                }
                else
                {
                    rbUnread.IsChecked = true;
                }


            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            txtNotificationID.Text = "";
            txtUser.Text = "";
            txtPlateNumber.Text = "";
            txtMassage.Text = "";
            txtSendDate.Text = "";
            rbUnread.IsChecked = true;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            int notificationID = Int32.Parse(txtNotificationID.Text);
            int userId = Int32.Parse(txtUserId.Text);
            string plateNumber = txtPlateNumber.Text;
            string massage = txtMassage.Text;
            DateTime sendDate = DateTime.Now;
             bool? isRead = null;
            if (rbRead.IsChecked == true)
            {
                isRead = true;
            }
            else if (rbUnread.IsChecked == true)
            {
                isRead = false;
            }

            Notification updateNotification = new Notification() { 
                NotificationId = notificationID,
                UserId = userId,
                PlateNumber = plateNumber,
                Message = massage,
                SentDate = sendDate,
                IsRead = isRead
            };
            notificationService.EditNotification(updateNotification);
            LoadDataGirdNotification();

        }
    }
}
