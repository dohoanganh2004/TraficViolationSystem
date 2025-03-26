using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TrafficViolation.BLL.Services;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.UserControll
{
    /// <summary>
    /// Interaction logic for ViewProfile.xaml
    /// </summary>
    public partial class ViewProfile : Window
    {
        private UserService userService = new UserService();
        public ViewProfile(User user)
        {
            DataContext = user;
            InitializeComponent();

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

            User currentUser = (User)DataContext;

            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        string.IsNullOrWhiteSpace(txtPhone.Text) ||
        string.IsNullOrWhiteSpace(txtAddress.Text) ||
        string.IsNullOrWhiteSpace(pwdPassword.Password))
            {
                System.Windows.MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            int id = currentUser.UserId;
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string password = pwdPassword.Password;
            int role = currentUser.RoleId;
            string image = currentUser.Image;

            User user = new User()
            {
                UserId = id,
                FullName = fullName,
                Email = email,
                Phone = phone,
                Address = address,
                Password = password,
                RoleId = role,
                Image = image
            };
            userService.UpdateUser(user);
            System.Windows.MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void ChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|Tất cả tệp (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // Hiển thị ảnh lên giao diện
                profileImage.Source = new BitmapImage(new Uri(imagePath));

                // Lưu đường dẫn ảnh vào User để cập nhật vào database
                ((User)DataContext).Image = imagePath;
            }
        }
    }
}
