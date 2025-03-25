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
    /// Interaction logic for ComplaintView.xaml
    /// </summary>
    public partial class ComplaintView : Window
    {
        private User user = App.LoggedInUser;
        private ComplaintsService complaintsService= new ComplaintsService();
        public ComplaintView()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            var complaint = complaintsService.GetComplaints(user.UserId);
            //var complaints = ComplaintsService.GetComplaints(user.UserId);
            dgComplaint.ItemsSource = complaint;
        }
    }
}
