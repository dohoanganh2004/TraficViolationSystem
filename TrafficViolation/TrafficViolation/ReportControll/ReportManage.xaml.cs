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

        private void gridReport_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gridReport.SelectedItem is Report selectedReport)
            {
                ReportDetail reportDetail = new ReportDetail(selectedReport);
                reportDetail.Show();
            }
        }
    }
}
