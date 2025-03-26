using System;
using System.Collections.Generic;
using System.Configuration;
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
using Microsoft.Win32;

namespace TrafficViolation
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {

        private UserService userService= new UserService();
        private RoleService roleService= new RoleService(); 
        public CreateAccount()
        {
            InitializeComponent();
            GetRole();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string fullname = this.txtFullName.Text.Trim();
            string email = this.txtEmail.Text.Trim();
            string phone = this.txtPhone.Text.Trim();
            string password = this.txtPassword.Password.Trim();
            string confirmPasswod = this.txtConfirmPassword.Password.Trim();
            int roleID = Int32.Parse(this.cbRole.SelectedValue.ToString());

            string address = this.txtAddress.Text.Trim();
            string image = this.txtImage.Text.Trim();
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(image))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            // Check confirm password
            if(password != confirmPasswod)
            {
                MessageBox.Show("Mật khẩu xác nhận không chính xác","Thông báo",MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            // Check trung
            User checkUser = userService.GetUserByPhoneAndEmail(phone, email);
            if (checkUser != null)
            {
                MessageBox.Show("Người dùng này đã tồn tại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            User user = new User()
            {
                FullName = fullname,
                Email = email,
                Phone = phone,
                Password = password,
                RoleId = roleID,
                Address = address,
                Image = image
            };
            userService.CreateUser(user);
            MessageBox.Show("Đăng Ký Thành Công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void BrowseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Chọn hình ảnh",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };
             if (openFileDialog.ShowDialog() == true)
            {
                txtImage.Text = openFileDialog.FileName;
                imgProfile.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }

        }

        public void GetRole()
        {
            var role = roleService.getAllRole();
            this.cbRole.ItemsSource = role;
            this.cbRole.DisplayMemberPath = "RoleName ";
            this.cbRole.SelectedValuePath = "RoleId";
            this.cbRole.SelectedIndex = 0;
        }
    }
}
