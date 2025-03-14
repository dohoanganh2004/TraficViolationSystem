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

namespace TrafficViolation.UserControll
{
    /// <summary>
    /// Interaction logic for ManageUser.xaml
    /// </summary>
    public partial class ManageUser : Window
    {
        UserService userService = new UserService();
        RoleService roleService = new RoleService();
        
        public ManageUser()
        {
            InitializeComponent();
            LoadUserCbRole();
            LoadDataGridUser();
        }



        public void LoadUserCbRole()
        {
            var role = roleService.getAllRole();
            this.cbRole.ItemsSource = role;
            this.cbRole.DisplayMemberPath = "RoleName ";
            this.cbRole.SelectedValuePath = "RoleId";
            this.cbRole.SelectedIndex = 0;  
        }


        public void LoadDataGridUser()
        {
            var user = userService.getAllUser();
            this.GridUser.ItemsSource = user;
        }

        private void addUser_Click(object sender, RoutedEventArgs e)
        {
            string fullname = this.txtFullName.Text.Trim();
            string email = this.txtEmail.Text.Trim();
            string phone = this.txtPhone.Text.Trim();
            string password = this.txtPassword.Password.Trim();
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
            // Check trung
            User checkUser = userService.GetUserByPhoneAndEmail(phone,email);
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
            LoadDataGridUser();
        }
    }
}
