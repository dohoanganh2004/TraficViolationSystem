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
using TrafficViolation.NotificationControll;
using TrafficViolation.ReportControll;
using TrafficViolation.UserControll;
using TrafficViolation.ViolationControll;

namespace TrafficViolation
{
    /// <summary>
    /// Interaction logic for MainWindow3.xaml
    /// </summary>
    public partial class MainWindow3 : Window
    {
        public MainWindow3()
        {
            InitializeComponent();
        }
        private void Avatar_Click(object sender, MouseButtonEventArgs e)
        {
            Border border = sender as Border;
            if (border != null && border.ContextMenu != null)
            {
                border.ContextMenu.IsOpen = true;
            }
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

       // void ShowImage()
        //{
           // UserService userService = new UserService();
           // userService.GetUserImage();
       // }

        private void UserManage_Click(object sender, RoutedEventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
           
        }




        private void btReportView_Click(object sender, RoutedEventArgs e)
        {
            ReportView reportView = new ReportView();
            reportView.ShowDialog();
          
        }

      
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

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
        private void Logout(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}

