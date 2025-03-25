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

namespace TrafficViolation.ComplaintControll
{
    /// <summary>
    /// Interaction logic for ComplaintDetail.xaml
    /// </summary>
    public partial class ComplaintDetail : Window
    {
        public ComplaintDetail(Complaint complaint)
        {

            InitializeComponent();
        }

       

        private void Accept_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancle_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
