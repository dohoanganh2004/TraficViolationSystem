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
    /// Interaction logic for ComplaintManage.xaml
    /// </summary>
    public partial class ComplaintManage : Window
    {
        private ComplaintService complaintService = new ComplaintService();
        public ComplaintManage()
        {
            InitializeComponent();
            LoadComplaint();
        }

        public void LoadComplaint()
        {
            var complaint = complaintService.GetAllComplaint();
            this.gridComplaint.ItemsSource = complaint;
        }

        private void GridComplaint_SelecionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gridComplaint.SelectedItem is Complaint selectedComplaint)
            {
                ComplaintDetail complaintDetail = new ComplaintDetail(selectedComplaint);
                complaintDetail.Show();
            }
        }

      

        private void txtSearchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchName = txtSearchName.Text.ToLower();
            var searchComplaint = complaintService.GetAllComplaint().
                Where(v => v.User.FullName.ToLower().Contains(searchName));
            this.gridComplaint.ItemsSource = searchComplaint;
        }

      

    }
}
