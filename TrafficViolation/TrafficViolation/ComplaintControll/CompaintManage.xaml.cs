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
    /// Interaction logic for CompaintManage.xaml
    /// </summary>
    public partial class CompaintManage : Window
    {
        private ComplaintService complaintService = new ComplaintService();
        public CompaintManage()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var complaint = complaintService.GetAllComplaint();
            this.gridComplaint.ItemsSource = complaint;
        }

        private void gridComplaint_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gridComplaint.SelectedItem is Complaint complaint)
            {
                ComplaintDetailAdmin complaintDetailAdmin = new ComplaintDetailAdmin(complaint);
                complaintDetailAdmin.Show();

            }
        }
    }
}
