﻿using System;
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
    }
}
