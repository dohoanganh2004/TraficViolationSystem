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

namespace TrafficViolation.ViolationControll
{
    /// <summary>
    /// Interaction logic for ViolationDetail.xaml
    /// </summary>
    public partial class ViolationDetail : Window
    {
        private Violation _violation;
        private ViolationService violationService = new ViolationService();
        public ViolationDetail(Violation violation)
        {
            InitializeComponent();
            _violation = violation;
            DataContext = _violation;
        }

       

       

        private void Close_Click(object sender, RoutedEventArgs e)
        {
          this.Close();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {   // Lấy dữ liệu từ UI
            int reportId = Int32.Parse(txtReportId.Text);
            int violationId = Int32.Parse(txtViolationID.Text);
            string plateNumber = txtPlateNumber.Text;
            int violatorID = Int32.Parse(txtViolatorId.Text);
            
            decimal fineAmount;
            DateTime fineDate;
            bool isPaid = cbPaidStatus.IsChecked ?? false;

            if ( string.IsNullOrEmpty(plateNumber))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!decimal.TryParse(txtFineAmount.Text, out fineAmount))
            {
                MessageBox.Show("Số tiền phạt không hợp lệ!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!txtFineDate.SelectedDate.HasValue)
            {
                MessageBox.Show("Vui lòng chọn ngày phạt!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            fineDate = txtFineDate.SelectedDate.Value;

            
            var updatedViolation = new Violation
            {
                ReportId = reportId,
                ViolationId = violationId,
                PlateNumber = plateNumber,
                ViolatorId = violatorID,
                FineAmount = fineAmount,
                FineDate = fineDate,
                PaidStatus = isPaid
            };

         violationService.UpdateViolation(updatedViolation);
            MessageBox.Show("Cập nhật vi phạm thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);




        }
    }
}
