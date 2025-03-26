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
using TrafficViolation.DAL.Repositories;

namespace TrafficViolation.ComplaintControll
{
    /// <summary>
    /// Interaction logic for ComplaintDetailAdmin.xaml
    /// </summary>
    public partial class ComplaintDetailAdmin : Window
    {
        private ComplaintService complaintService = new ComplaintService();
        private NotificationService notificationService = new NotificationService();
        private NotificationRepository notificationRepository = new NotificationRepository();
        private User user = App.LoggedInUser;
        private Models.Complaint complaint;
        public ComplaintDetailAdmin(Complaint complaint)
        {
            InitializeComponent();
            DataContext = complaint;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            int complaintId = Int32.Parse(txtComplaintID.Text);
            int userId = Int32.Parse(txtUserID.Text);
            int reportId = Int32.Parse(txtReportID.Text);
            int violationId = Int32.Parse(txtViolationId.Text);
            string complaintText = txtComplaintText.Text;
            DateTime? reportDate = dpReportDate.SelectedDate;
            string status = "Đã giải quyết";
            int processerID = user.UserId;
            string plateNumber = txtPlateNumber.Text;
            Complaint complaint = new Complaint()
            {
                ComplaintId = complaintId,
                UserId = userId,
                ReportId = reportId,
                ViolationId = violationId,
                ComplaintText = complaintText,
                ComplaintDate = reportDate,
                Status = status,
                ProcessedBy = processerID
            };
            complaintService.UpdateComplaint(complaint);
            MessageBox.Show("Khiếu nại đã được duyệt!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

            string message = "Chúng tôi đã xử lý khiếu nại của bạn, xin lỗi về sự sai sót.";


            notificationRepository.AddNotification(userId, message, plateNumber);






        }

        private void Cancle_Click(object sender, RoutedEventArgs e)
        {
            int complaintId = Int32.Parse(txtComplaintID.Text);
            int userId = Int32.Parse(txtUserID.Text);
            int reportId = Int32.Parse(txtReportID.Text);
            int violationId = Int32.Parse(txtViolationId.Text);
            string complaintText = txtComplaintText.Text;
            DateTime? reportDate = dpReportDate.SelectedDate;
            string status = "Bị từ chối";
            int processerID = user.UserId;
            string plateNumber = txtPlateNumber.Text;
            Complaint complaint = new Complaint()
            {
                ComplaintId = complaintId,
                UserId = userId,
                ReportId = reportId,
                ViolationId = violationId,
                ComplaintText = complaintText,
                ComplaintDate = reportDate,
                Status = status,
                ProcessedBy = processerID
            };
            complaintService.UpdateComplaint(complaint);
            MessageBox.Show("Khiếu nại đã được duyệt!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

            string message = "Chúng tôi đã xử lý khiếu nại của bạn, bạn vẫn vi phạm !";


            notificationRepository.AddNotification(userId, message, plateNumber);
        }
    }
}