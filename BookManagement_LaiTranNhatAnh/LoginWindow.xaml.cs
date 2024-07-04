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
            bool checkLogin = _userService.checkUserLogin(username, password);
            if (checkLogin)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Hide();
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
