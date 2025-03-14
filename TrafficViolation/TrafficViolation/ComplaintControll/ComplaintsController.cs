using System.Collections.ObjectModel;
using System.Windows.Input;
using TrafficViolation.BLL.Services;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.ComplaintControll
{
    public class ManageComplaintsViewModel : ViewModelBase
    {
        private readonly ComplaintService _complaintService;
        public ObservableCollection<Complaint> Complaints { get; set; }

        public ICommand ViewComplaintCommand { get; }

        public ManageComplaintsViewModel()
        {
            _complaintService = new ComplaintService();
            Complaints = new ObservableCollection<Complaint>(_complaintService.GetAllComplaints());

            ViewComplaintCommand = new RelayCommand<int>(ViewComplaint);
        }

        private void ViewComplaint(int complaintId)
        {
            Complaint complaint = _complaintService.GetComplaintById(complaintId);
            // Mở cửa sổ chi tiết khiếu nại
            ViewComplaint viewComplaint = new ViewComplaint(complaint);
            viewComplaint.Show();
        }
    }
}