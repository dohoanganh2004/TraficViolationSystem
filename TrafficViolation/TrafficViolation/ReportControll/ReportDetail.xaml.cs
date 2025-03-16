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
using TrafficViolation.ViolationControll;

namespace TrafficViolation.ReportControll
{
    /// <summary>
    /// Interaction logic for ReportDetail.xaml
    /// </summary>
    public partial class ReportDetail : Window
    {
        private User user = App.LoggedInUser;
        private Report _report;
        private ReportService _reportService = new ReportService();
        private ReportManage reportManage = new ReportManage();
     
        public ReportDetail(Report report)
        {
            InitializeComponent();
            _report = report;
            DataContext = _report;
        }

        
        

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ReportManage reportManage = new ReportManage();
            reportManage.Show();
        }

        private void btConfirm_Click(object sender, RoutedEventArgs e)
        {
            _report.Status = "Đã duyệt";
            _report.ProcessedBy = user.UserId; // Lưu ID người xử lý

            _reportService.UpdateReport(_report);
             reportManage.GetAllReport();
                CreateViolation createViolation = new CreateViolation(_report);
        createViolation.Show();
            this.Close();

         

           

        }

        private void btRefuse_Click(object sender, RoutedEventArgs e)
        {
            _report.Status = "Bị từ chối";
            _report.ProcessedBy = user.UserId; 

            _reportService.UpdateReport(_report);

            MessageBox.Show("Phản ánh đã được duyệt!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            reportManage.GetAllReport();
            reportManage.Show();
            this.Close();
        }
    }
}
