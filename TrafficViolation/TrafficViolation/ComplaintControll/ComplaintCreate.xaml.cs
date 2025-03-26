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

namespace TrafficViolation.ComplaintControll
{
    /// <summary>
    /// Interaction logic for ComplaintCreate.xaml
    /// </summary>
    public partial class ComplaintCreate : Window
    {
        private ComplaintsService complaintsService = new ComplaintsService();
        private User user = App.LoggedInUser;
        public ComplaintCreate()
        {
            InitializeComponent();
        }
        public void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int? reportId = string.IsNullOrWhiteSpace(txtReportId.Text) ? null : int.Parse(txtReportId.Text);
                int? violationId = string.IsNullOrWhiteSpace(txtViolationId.Text) ? null : int.Parse(txtViolationId.Text);
                string complaintText = txtComplaintText.Text;

                if (string.IsNullOrWhiteSpace(complaintText))
                {
                    MessageBox.Show("Complaint Text cannot be empty.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                Complaint newComplaint = new Complaint
                {
                    UserId = user.UserId,
                    ReportId = reportId,
                    ViolationId = violationId,
                    ComplaintText = complaintText,
                    ComplaintDate = DateTime.Now,
                    Status = "Chờ xử lý",
                    ProcessedBy = null
                };

                complaintsService.CreateComplaint(newComplaint);
                MessageBox.Show("Complaint created successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                ComplaintView complaint = new ComplaintView();
                complaint.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
    
}
