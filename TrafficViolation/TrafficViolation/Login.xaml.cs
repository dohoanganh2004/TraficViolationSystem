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

namespace TrafficViolation
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private UserService _userService = new();

        public Login()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string phone = phoneNumber.Text;
            string pass = Password.Password;
            // Check Rong
            if (string.IsNullOrEmpty(phone) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Phone or Password is not null", "Field requre", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            User? user = _userService.GetUserByPhoneAndPassword(phone, pass);
            // Check tai khoan
            if (user == null)
            {
                MessageBox.Show("Invalid email or password!", "Wrong credential", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Application.Current.Properties["LoginUser"] = user;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
