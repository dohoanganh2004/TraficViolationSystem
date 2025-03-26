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
    /// Interaction logic for ComplaintDetail.xaml
    /// </summary>
    public partial class ComplaintDetail : Window
    {
        private ComplaintsService complaintsService= new ComplaintsService();
        private int _complaintId;
        public ComplaintDetail(int complaintId)
        {
            InitializeComponent();
            _complaintId = complaintId;
            LoadComplaintDetail();
        }
        void LoadComplaintDetail()
        {
            Complaint complaint = complaintsService.GetComplaintByID(_complaintId);
            this.DataContext = complaint;
        }
        public void Close_Click(object sender, RoutedEventArgs e) { 
        this.Close();
        }

    }
}
