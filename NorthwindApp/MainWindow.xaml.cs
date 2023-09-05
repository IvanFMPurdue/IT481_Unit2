using System.Windows;

namespace NorthwindApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private BusinessLayer _bl = new BusinessLayer(@"Data Source=IVANPC\IT350_2301C;Initial Catalog=Northwind;Integrated Security=True");

        private void LoadDataBtn_Click(object sender, RoutedEventArgs e)
        {
            NumberOfCustomersTbx.Text = $"{_bl.GetNumberOfCustomers()}";
            CustomerNamesLbx.ItemsSource = _bl.GetCustomerLastName();
        }
    }
}
