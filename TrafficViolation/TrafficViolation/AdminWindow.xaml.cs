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
using TrafficViolation.ComplaintControll;
using TrafficViolation.NotificationControll;
using TrafficViolation.ReportControll;
using TrafficViolation.UserControll;
using TrafficViolation.ViolationControll;

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

     

        private void UserManage_Click(object sender, RoutedEventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
            
        }

    

       
        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           NotificationManage notificationManage = new NotificationManage();
            notificationManage.Show();
            
        }

        

        private void btVolation_Click(object sender, RoutedEventArgs e)
        {
            ViolationManage violationManage = new ViolationManage();
            violationManage.ShowDialog();
            
        }

        private void btReport_Click(object sender, RoutedEventArgs e)
        {
            ReportManage reportManage = new ReportManage(); 
            reportManage.ShowDialog();
           
        }

        private void btComplaint_Click(object sender, RoutedEventArgs e)
        {
            ComplaintManage complaintManage = new ComplaintManage();
            complaintManage.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}