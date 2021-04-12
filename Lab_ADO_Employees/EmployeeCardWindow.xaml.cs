using Lab_ADO_Employees.Classes;
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
    /// Логика взаимодействия для EmployeeCard.xaml
    /// </summary>
    public partial class EmployeeCardWindow : Window
    {
        EmployeesWindow employeesWindow = new EmployeesWindow();
        public String IDText { get; set; }
        Service1Client client;
        public EmployeeCardWindow()
        {
            InitializeComponent();            
        }

        public void Refresh()
        {            
            dataGrid1.ItemsSource = null;
            try
            {
                client = new Service1Client();
                dataGrid1.Items.Add(client?.GetEmployeeCard(IDText)); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }      

        private void edit_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            EditEmployeeWindow editEmployeeWindow = new EditEmployeeWindow();            
            editEmployeeWindow.IDEdit = IDText;
            editEmployeeWindow.Refresh();
            editEmployeeWindow.Show();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
