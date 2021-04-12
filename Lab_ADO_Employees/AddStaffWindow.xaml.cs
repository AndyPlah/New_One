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
using Lab_ADO_Employees.ServiceReference1;
namespace Lab_ADO_Employees
{
    /// <summary>
    /// Логика взаимодействия для AddStaffWindow.xaml
    /// </summary>
    public partial class AddStaffWindow : Window
    {
        List<string> deps = new List<string>();
        Service1Client client;
        int[] a = Enumerable.Range(0, 7).ToArray();

        public AddStaffWindow()
        {
            InitializeComponent();
            client = new Service1Client();  
            depBox.ItemsSource = client?.GetDepsID();
            quanBox.ItemsSource = a;
            nowBox.ItemsSource = a;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
