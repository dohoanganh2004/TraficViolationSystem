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
using TrafficViolation.DAL.Models;
using TrafficViolation.DAL.Repositories;

namespace TrafficViolation.ReportControll
{
    /// <summary>
    /// Interaction logic for ReportAdd.xaml
    /// </summary>
    public partial class ReportAdd : Window
    {
        public ReportAdd()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            ReportRepository reportRepository = new ReportRepository();
            Report newReport= new Report()
            {

                PlateNumber = txtPlateNumber.Text,
                ViolationType = (cbViolationType.SelectedItem as ComboBoxItem)?.Content.ToString(),
                Description = txtDescription.Text,
                ImageUrl = txtImageUrl.Text,
                VideoUrl = txtVideoUrl.Text,
                Location = txtLocation.Text,
                ReportDate = DateTime.Now
            };


            reportRepository.AddReport(newReport);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

