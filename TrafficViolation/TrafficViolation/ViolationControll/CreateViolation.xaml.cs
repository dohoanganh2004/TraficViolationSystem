﻿using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for CreateViolation.xaml
    /// </summary>
    public partial class CreateViolation : Window
    {
        private  VehicleService vehicleService = new VehicleService();
        private ViolationService violationService = new ViolationService(); 
        private NotificationService notificationService = new NotificationService();
        public CreateViolation(Report report)
        {
            InitializeComponent();
            LoadData(report);
            DataContext = report;
        }

        // Load Data

        public void LoadData(Report report)
        {
            txtReportID.Text = report.ReportId.ToString();
            txtLocation.Text = report.Location;
            txtPlateNumber.Text = report.PlateNumber;
            txtDescription.Text = report.Description;
            txtViolationType.Text = report.ViolationType;
            string validator = vehicleService.GetUserByPlateNumber(txtPlateNumber.Text);
            txtViolator.Text = validator;
            if (!string.IsNullOrEmpty(report.ImageUrl) && File.Exists(report.ImageUrl))
            {
                imgViolation.Source = new BitmapImage(new Uri(report.ImageUrl, UriKind.Absolute));
            }
            else
            {
                imgViolation.Source = null; 
            }

        }
        // Add Violation
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {   
            
            
            int reportID = int.Parse(txtReportID.Text);
            string plateNumber = txtPlateNumber.Text;
            
            int validatorID = vehicleService.GetUserIDByPlateNumber(plateNumber);
            DateTime fineDate = DateTime.Now;
            if (string.IsNullOrEmpty(txtFineAmount.Text))
            {
                MessageBox.Show("Vui lòng nhập phải lơn hơn 0!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            decimal fineAmount = Decimal.Parse(txtFineAmount.Text);

            bool paidStatus = false;

            // Validate before add
            if (fineAmount < 0 )
            {
                MessageBox.Show("Vui lòng nhập phải lơn hơn 0!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
 // 
            Violation violation = new Violation()
            {

                ReportId = reportID,
                ViolatorId = validatorID,
                PlateNumber = plateNumber,
                FineDate = fineDate,
                FineAmount = fineAmount,
                PaidStatus = paidStatus,

            };
             violationService.AddViolation(violation);
            MessageBox.Show("Thêm vi phạm thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            string notificationMessage = $"Bạn đã bị phạt {fineAmount:N0} VNĐ cho xe {plateNumber}.  Vui lòng kiểm tra chi tiết!";
            notificationService.SendNotification(validatorID, notificationMessage, plateNumber);
            violationService.GetAllViolation();
}


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ViolationManage violationManage = new ViolationManage();
            violationManage.Show();
        }
        


           
        


        
    }
}
