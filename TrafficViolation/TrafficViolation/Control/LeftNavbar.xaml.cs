using System.Windows;
using System.Windows.Controls;

using TrafficViolation.BLL.Services;
using TrafficViolation.DAL.Models;
using TrafficViolation.UserControll;

namespace TrafficViolation.Control
{
    /// <summary>
    /// Interaction logic for LeftNavbar.xaml
    /// </summary>
    public partial class LeftNavbar : UserControl // Sửa từ Window thành UserControl
    {


       
        public LeftNavbar()
        {
            InitializeComponent();
        }
       

        private UserService _userService = new();
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to logout?",
                "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                // Xóa session
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

                // Đặt cửa sổ chính là Login
                Application.Current.MainWindow = login;
            }
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            if (App.LoggedInUser!= null)
            {
                User user = _userService.GetUserByID(App.LoggedInUser.UserId);
                ViewProfile viewProfile = new ViewProfile(user);
                viewProfile.Show();
            }
            else
            {
                MessageBox.Show("User profile not found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void ToggleNavbar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
