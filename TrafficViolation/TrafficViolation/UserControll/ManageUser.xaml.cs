using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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
            LoadUserFilerRole();
        }



        public void LoadUserCbRole()
        {
            var role = roleService.getAllRole();
            this.cbRole.ItemsSource = role;
            this.cbRole.DisplayMemberPath = "RoleName ";
            this.cbRole.SelectedValuePath = "RoleId";
            this.cbRole.SelectedIndex = 0;  
        }

        public void LoadUserFilerRole()
        {
            var role = roleService.getAllRole();
            role.Add(new Role() { RoleId = 0,RoleName ="All"});
            this.cbFilterRole.ItemsSource = role;
            this.cbFilterRole.DisplayMemberPath = "RoleName ";
            this.cbFilterRole.SelectedValuePath = "RoleId";
            this.cbFilterRole.SelectedIndex = 0;
        }


        public void LoadDataGridUser()
        {
            var user = userService.getAllUser();
            this.GridUser.ItemsSource = user;
        }
        // Add user
        private void addUser_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
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
            MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            LoadDataGridUser();
        }
        // Select user
        private void GridUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = GridUser.SelectedItem as User;
            if (user != null)
            {
                
                txtFullName.Text = user.FullName;
                txtEmail.Text = user.Email;
                txtPhone.Text = user.Phone;
                txtPassword.Password = user.Password;
                cbRole.SelectedValue = user.RoleId;

                txtAddress.Text = user.Address;
                txtImage.Text = user.Image;


               
            }

        }
        // Update user
        private void btnUpdateUser_Click(object sender, RoutedEventArgs e)
        {
            
            if(GridUser.SelectedItem is not User selectedUser )
            {
                MessageBox.Show("Vui lòng chọn người dùng cần cập nhật!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            int userId = selectedUser.UserId;
            string fullname = this.txtFullName.Text;
            string email = this.txtEmail.Text;
            string phone = this.txtPhone.Text;
            string password = this.txtPassword.Password;
            int roleID = int.Parse(this.cbRole.SelectedValue.ToString());
            string address = this.txtAddress.Text;
            string image = this.txtImage.Text;

            User updateUse = new User()
            {
                UserId = userId,
                FullName = fullname,
                Email = email,
                Phone = phone,
                Password = password,
                RoleId = roleID,
                Address = address,
                Image = image
            };
            userService.UpdateUser(updateUse);
            MessageBox.Show("Cập nhật người dùng thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            LoadDataGridUser();
        }

        private void ClearForm()
        {
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPassword.Password = string.Empty;
            txtAddress.Text = string.Empty;
            txtImage.Text = string.Empty;
            cbRole.SelectedIndex = 0; 
            GridUser.SelectedItem = null; 
        }

        private void cbFilterRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }


}
