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
using BLL.Services;

namespace BookManagement_LaiTranNhatAnh
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private UserService _userService;

        public LoginWindow()
        {
            InitializeComponent();
            _userService = new();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordPasswordBox.Password;
            var userLogin = _userService.CheckUserLogin(username, password);
            if (userLogin != null)
            {
                //1-Admin, 2-Staff
                if(userLogin.Role == 1 || userLogin.Role == 2)
                {
                    MainWindow mainWindow = new MainWindow(userLogin);
                    mainWindow.Show();
                    Close();
                }
                else //Else role Member
                {
                    MessageBox.Show("You have no permission to access this function!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect email or password!");
            }

        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            UsernameTextBox.Clear();
            PasswordPasswordBox.Clear();
        }
    }
}
