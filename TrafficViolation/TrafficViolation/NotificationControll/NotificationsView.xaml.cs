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
using TrafficViolation.BLL.Services;
using TrafficViolation.DAL.Models;
using User = TrafficViolation.DAL.Models.User;

namespace TrafficViolation.NotificationControll
{
    /// <summary>
    /// Interaction logic for NotificationsView.xaml
    /// </summary>
    public partial class NotificationsView : Window
    {
        private NotificationService notificationService = new NotificationService();
        private User user = App.LoggedInUser;

        public NotificationsView()
        {
            InitializeComponent();
            LoadUserNofication();
        }

        void LoadUserNofication()
        {
           var notification =  notificationService.GetNoficationById(user.UserId);
            dgNotification.ItemsSource = notification;
        }

        public void Back_button(Window sender, RoutedEventArgs e)
        {
            MainWindow3 mainWindow3 = new MainWindow3();
            mainWindow3.Show();
            this.Close();
        }

        private void Back_Button(object sender, RoutedEventArgs e)
        {

        }
        
private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
