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
using TrafficViolation.DAL.Models;

namespace TrafficViolation.ReportControll
{
    /// <summary>
    /// Interaction logic for ReportDetail.xaml
    /// </summary>
    public partial class ReportDetail : Window
    {
        private Report _report;
        public ReportDetail(Report report)
        {
            InitializeComponent();
            _report = report;
            DataContext = _report;
        }

        
        

        private void btClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btConfirm_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
