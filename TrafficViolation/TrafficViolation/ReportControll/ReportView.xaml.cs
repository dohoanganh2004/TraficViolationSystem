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
using Microsoft.VisualBasic.ApplicationServices;
using TrafficViolation.BLL.Services;
using TrafficViolation.DAL.Models;
using User = TrafficViolation.DAL.Models.User;

namespace TrafficViolation.ReportControll
{
    /// <summary>
    /// Interaction logic for ReportView.xaml
    /// </summary>
    public partial class ReportView : Window
    {
        private ReportService reportService = new ReportService();
        //int userId = App.LoggedInUser?.UserId ?? 0;
        private User user = App.LoggedInUser;
        public ReportView()
        {
            InitializeComponent();
            GetAllReportByUserId();
        }

        public void GetAllReportByUserId()
        {
            var reports = reportService.GetAllReportsByUserID(user.UserId);
            dgReports.ItemsSource = reports;
        }
       

        
        public void CreateReportButton_Click(object sender, RoutedEventArgs e)
        {
            ReportAdd reportAdd = new ReportAdd();
            reportAdd.Show();
            
        }
        public void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow3 mainWindow3 = new MainWindow3();
            mainWindow3.Show();
            this.Close();
        }
        public void dgReports_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgReports.SelectedItem is Report selectedReport)
            {
                ReportViewDetail reportViewDetail = new ReportViewDetail(selectedReport.ReportId);
                reportViewDetail.Show();
            }
        }

    }
}
