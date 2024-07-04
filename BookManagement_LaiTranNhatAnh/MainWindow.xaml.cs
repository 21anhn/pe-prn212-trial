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
            ListBookDataGrid.ItemsSource = _bookService.GetAllBooks();
        }

        //Reset DataGrid
        private void ResetListBookDataGrid()
        {
            ListBookDataGrid.ItemsSource = null;
        }
    }
}