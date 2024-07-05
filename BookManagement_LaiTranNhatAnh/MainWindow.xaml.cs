using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL.Services;
using DAL.Models;
using Microsoft.IdentityModel.Tokens;

namespace BookManagement_LaiTranNhatAnh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UserAccount CurrentUser { get; set; }
        private BookService _bookService = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(UserAccount userAccount)
        {
            InitializeComponent();
            CurrentUser = userAccount;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Gọi trước khi load lại
            ResetListBookDataGrid();
        }

        //Reset DataGrid
        private void ResetListBookDataGrid() //Reset DataGrid source trước khi làm mới lại
        {
            ListBookDataGrid.ItemsSource = null;
            ListBookDataGrid.ItemsSource = _bookService.GetAllBooks();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string bookName = BookNameTextBox.Text;
            string description = DescriptionTextBox.Text;
            var list = _bookService.SearchBooksByNameOrDescriptionContaining(bookName, description);
            if (!list.IsNullOrEmpty())
            {
                ListBookDataGrid.ItemsSource = list;
            }
            else
            {
                MessageBox.Show($"Not found any books with book name: {bookName} and description: {description}");
            }
        }
    }
}