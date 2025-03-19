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
        private User user = App.LoggedInUser;
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
                ReporterId = user.UserId,
                PlateNumber = txtPlateNumber.Text,
                ViolationType = cbViolationType.Text,
                Description = txtDescription.Text,
                ImageUrl = string.IsNullOrWhiteSpace(txtImageUrl.Text) ? null : txtImageUrl.Text,
                VideoUrl = string.IsNullOrWhiteSpace(txtVideoUrl.Text) ? null : txtVideoUrl.Text,
                //string.IsNullOrWhiteSpace(txtVideoUrl.Text) ? null : txtVideoUrl.Text
                //Status = "Chờ xử lí",
                Location = txtLocation.Text,
                ReportDate = DateTime.Now
            };
            if (string.IsNullOrWhiteSpace(txtImageUrl.Text) && string.IsNullOrWhiteSpace(txtVideoUrl.Text))
            {
                MessageBox.Show("Please enter at least an Image URL or a Video URL.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            reportRepository.AddReportByUser3(newReport);
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

