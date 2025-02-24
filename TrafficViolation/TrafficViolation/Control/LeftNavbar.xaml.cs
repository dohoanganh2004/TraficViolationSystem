using System.Windows;
using System.Windows.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using TrafficViolation.BLL.Services;
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
        public User LogedInUser { get; set; }

        private UserService _userService = new();
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to logout?",
                "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                LogedInUser = null;

                // Mở cửa sổ Login trước khi đóng tất cả cửa sổ khác
                Login login = new Login();
                login.Show();

                // Đóng tất cả cửa sổ hiện tại (trừ cửa sổ Login vừa mở)
                foreach (var window in Application.Current.Windows.Cast<Window>().ToList())
                {
                    if (window != login)
                    {
                        window.Close();
                    }
                }

                // Đặt Login làm cửa sổ chính
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
         ViewProfile viewProfile = new ViewProfile(); 
            
            viewProfile.Show();
        }
    }
}
