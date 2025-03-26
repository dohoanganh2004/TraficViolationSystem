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
using User = TrafficViolation.DAL.Models.User;

namespace TrafficViolation.ReportControll
{
  
    /// <summary>
    /// Interaction logic for ReportViewDetail.xaml
    /// </summary>
    public partial class ReportViewDetail : Window
    {
        private ReportService reportService = new ReportService();
        private User user = App.LoggedInUser;
        private int reportId;

        public ReportViewDetail(int reportId)
        {
            InitializeComponent();
            this.reportId = reportId;
            load(reportId);
        }
        void load(int reportId)
        {
            var data = reportService.GetReportByReportId(reportId);
            dgReports.ItemsSource = new List<Report> { data };
        }
        public void EditButton_Click(object sender, RoutedEventArgs e)
        {
            dgReports.CommitEdit();
            if (dgReports.SelectedItem is Report selectedReport)
            {
                reportService.UpdateReport(selectedReport);
                
            }
        }
        public void DeleteButton_Click(Object sender, RoutedEventArgs e)
        {
            if (dgReports.SelectedItem is Report selectedReport)
            {
                reportService.DeleteReport(selectedReport.ReportId);
                
            }
        }
    }
}
