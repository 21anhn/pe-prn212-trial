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
using Microsoft.IdentityModel.Tokens;

namespace AirConditionerShop_LaiTranNhatAnh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        AirConditionerService _service = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListAirConditionerDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            ListAirConditionerDataGrid.ItemsSource = null;
            ListAirConditionerDataGrid.ItemsSource = _service.GetAllAirConditioners();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var featureFunction = FeatureFunctionTextBox.Text;

            var quantityTextBox = QuantityTextBox.Text;
            if(quantityTextBox.IsNullOrEmpty())
            {
                quantityTextBox = "0";
            }
            int? quantity = int.Parse(quantityTextBox);
            var list = _service.SearchlAirConditionersByFeatureFunctionOrQuantity(featureFunction, quantity);

            if(list != null && list.Count > 0)
            {
                ListAirConditionerDataGrid.ItemsSource = null;
                ListAirConditionerDataGrid.ItemsSource = list;
            }

        }
    }
}