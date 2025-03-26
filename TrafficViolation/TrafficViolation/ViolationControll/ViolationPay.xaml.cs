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
    /// Interaction logic for ViolationPay.xaml
    /// </summary>
    public partial class ViolationPay : Window
    {
        private ViolationService violationService = new ViolationService();
        private User user = App.LoggedInUser;

        public ViolationPay()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            var violations = violationService.GetAllViolation();
            dgViolation.ItemsSource = violations;
        }

        public void dgViolation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgViolation.SelectedItem is Violation selectedReport)
            {

                this.Close();
            }
        }
        

    }

}
