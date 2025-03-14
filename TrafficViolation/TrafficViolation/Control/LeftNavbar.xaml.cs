using System.Windows;
using System.Windows.Controls;
using TrafficViolation.BLL.Services;
using TrafficViolation.DAL.Models;
using TrafficViolation.UserControll;

namespace TrafficViolation.Control
{
    public partial class LeftNavbar : UserControl
    {
        public LeftNavbar()
        {
            InitializeComponent();
        }

        private UserService _userService = new();

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to logout?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.LoggedInUser = null;

                Login login = new Login();
                login.Show();

                foreach (Window window in Application.Current.Windows.Cast<Window>().ToList())
                {
                    if (window != login)
                    {
                        window.Close();
                    }
                }

                Application.Current.MainWindow = login;
            }
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            // Chuyển đến Dashboard
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            // Thay đổi mật khẩu
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            if (App.LoggedInUser != null)
            {
                User user = _userService.GetUserByID(App.LoggedInUser.UserId);
                ViewProfile viewProfile = new ViewProfile(user);
                viewProfile.Show();
            }
            else
            {
                MessageBox.Show("User profile not found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Complaints_Click(object sender, RoutedEventArgs e)
        {
            ManageComplaints manageComplaints = new ManageComplaints();
            manageComplaints.Show();
        }

        private void Payments_Click(object sender, RoutedEventArgs e)
        {
            ManagePayments managePayments = new ManagePayments();
            managePayments.Show();
        }

        private void AuditLogs_Click(object sender, RoutedEventArgs e)
        {
            ViewAuditLogs viewAuditLogs = new ViewAuditLogs();
            viewAuditLogs.Show();
        }
    }
}