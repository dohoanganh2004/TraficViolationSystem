using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TrafficViolation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ViewProfile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Xem Thông Tin Người Dùng");
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đổi Mật Khẩu");
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đăng Xuất");
        }

        private void LeftNavbar_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}