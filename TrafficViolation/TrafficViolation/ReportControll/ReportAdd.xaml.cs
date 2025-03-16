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
using TrafficViolation.DAL.Repositories;

namespace TrafficViolation.ReportControll
{
    /// <summary>
    /// Interaction logic for ReportAdd.xaml
    /// </summary>
    public partial class ReportAdd : Window
    {
        public ReportAdd()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (App.LoggedInUser == null)
            {
                MessageBox.Show("You must be logged in to submit a report.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            ReportRepository reportRepository = new ReportRepository();
            Report newReport = new Report()
            {
                ReporterId = 3,
                PlateNumber = txtPlateNumber.Text,
                ViolationType = "Chờ xử lí",
                Description = txtDescription.Text,
                ImageUrl = txtImageUrl.Text,
                VideoUrl = txtVideoUrl.Text,
                Location = txtLocation.Text,
                ReportDate = DateTime.Now
            };
            reportRepository.AddReportByUser3(newReport);
            //ReportAdd report = new ReportAdd();
            //report.Show();
            ReportView reportView = new ReportView();
            reportView.Show();
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            ReportView reportView = new ReportView();
            reportView.Show();
            this.Close();
        }
    }
}

