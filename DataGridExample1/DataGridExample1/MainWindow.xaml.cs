using System.Collections.ObjectModel;
using System.Windows;

namespace DataGridExample1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { 
            InitializeComponent();

            Customer cust1 = new Customer()
            {
                FirstName = "firstname1",
                LastName = "lastname1",
                IsMember = true
            };
            Customer cust2 = new Customer()
            {
                FirstName = "firstname2",
                LastName = "lastname2",
                IsMember = true
            };
            Customer cust3 = new Customer()
            {
                FirstName = "firstname3",
                LastName = "lastname3",
                IsMember = false
            };

            ObservableCollection<Customer> custdata = new ObservableCollection<Customer>()
            {
                cust1,
                cust2,
                cust3
            };

            CustomerGrid.DataContext = custdata;
        }
    }
}
