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
    /// Interaction logic for ViolationManage.xaml
    /// </summary>
    public partial class ViolationManage : Window
    {

        private ViolationService violationService = new ViolationService();
        public ViolationManage()
        {
            InitializeComponent();
            GetAllViolation();
        }




        public void GetAllViolation()
        {
         var violations = violationService.GetAllViolation();
         this.GridViolation.ItemsSource = violations;
         
        }

        private void GridViolation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(GridViolation.SelectedItem is Violation selectedViolation)
            {
             ViolationDetail violationDetail = new ViolationDetail(selectedViolation);
                violationDetail.Show();
            }
           
        }




        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchPlateNumber = txtSearchPlate.Text.Trim().ToLower();
            string searchViolator = txtSearchName.Text.Trim().ToLower();

            // Kiểm tra nếu cả hai ô đều trống
            if (string.IsNullOrEmpty(searchPlateNumber) && string.IsNullOrEmpty(searchViolator))
            {
                MessageBox.Show("Vui lòng nhập ít nhất một tiêu chí tìm kiếm!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

           
            var violations = violationService.GetAllViolation();

            
            if (!string.IsNullOrEmpty(searchPlateNumber))
            {
                violations = violations.Where(v => v.PlateNumber.ToLower().Contains(searchPlateNumber)).ToList();
            }
            if (!string.IsNullOrEmpty(searchViolator))
            {
                violations = violations.Where(v => v.Violator.FullName.ToLower().Contains(searchViolator)).ToList();
            }

            
            if (violations.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }

          
            GridViolation.ItemsSource = violations;
        }
            
        

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            string selectedSort = (cbSortByDate.SelectedItem as ComboBoxItem)?.Content.ToString();
            var violations = violationService.GetAllViolation();
            if(selectedSort.Equals("Mới nhất"))
            {
                violations = violations.OrderByDescending(v => v.FineDate).ToList();
            }
            else if(selectedSort.Equals("Cũ nhất")) 
            {
                violations = violations.OrderBy(v => v.FineDate).ToList();
            }

            GridViolation.ItemsSource = violations;

        }
    }
}
