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

namespace TrafficViolation.ReportControll
{
    /// <summary>
    /// Interaction logic for ReportManage.xaml
    /// </summary>
    public partial class ReportManage : Window
    {
        private ReportService reportService = new ReportService();
        public ReportManage()
        {
            InitializeComponent();
            GetAllReport();
        }

       public void GetAllReport()
        {
            var report = reportService.GetAllReport();
            this.gridReport.ItemsSource = report;
            
        }

  

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchReporter = txtReporter.Text.ToLower();
            string searchPlateNumber = txtPlateNumber.Text.ToLower();

            var report = reportService.GetAllReport();

            if (string.IsNullOrEmpty(searchReporter) && string.IsNullOrEmpty(searchPlateNumber))
            {
                MessageBox.Show("Vui lòng nhập ít nhất một tiêu chí tìm kiếm!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

           
            if (!string.IsNullOrEmpty(searchReporter))
            {
                report = report.Where(v => v.Reporter.FullName.ToLower().Contains(searchReporter)).ToList();
            }

           
            if (!string.IsNullOrEmpty(searchPlateNumber))
            {
                report = report.Where(v => v.PlateNumber.ToLower().Contains(searchPlateNumber)).ToList();
            }

            this.gridReport.ItemsSource = report;

            if (report.Count == 0)
            {
                MessageBox.Show("Không tìm thấy báo cáo nào phù hợp!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            var reportList = reportService.GetAllReport();

            
            string selectedStatus = (cbStatusFilter.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (selectedStatus == "Bị từ chối")
            {
                reportList = reportList.Where(r => r.Status == "Bị từ chối").ToList();
            }
            else if (selectedStatus == "Đã duyệt")
            {
                reportList = reportList.Where(r => r.Status == "Đã duyệt").ToList();
            } else if (selectedStatus == "Chờ xử lý")
            {
                reportList = reportList.Where(r => r.Status == "Chờ xử lý").ToList();
            } else if (selectedStatus == "Tất cả")
            {
                reportList = reportList.ToList();
            }
            

            
           
            gridReport.ItemsSource = reportList;

            
            if (reportList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy báo cáo nào phù hợp!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void gridReport_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (gridReport.SelectedItem is Report selectedReport)
            {
                ReportDetail reportDetail = new ReportDetail(selectedReport);

                reportDetail.Show();
                this.Close();


            }
        }


        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            var reportList = gridReport.ItemsSource as List<Report>;
            if (reportList == null || reportList.Count == 0) return;

            
            string sortOrder = (cbSortOrder.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (sortOrder == "Mới nhất")
            {
                reportList = reportList.OrderByDescending(r => r.ReportDate).ToList();
            }
            else if (sortOrder == "Cũ nhất")
            {
                reportList = reportList.OrderBy(r => r.ReportDate).ToList();
            }

            
            gridReport.ItemsSource = reportList;
        }

    }
}
