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
    /// Логика взаимодействия для VacancyByDep.xaml
    /// </summary>
    public partial class VacancyByDep : Window
    {
        Service1Client client;
        public VacancyByDep()
        {
            InitializeComponent();
        }

        public async void RefreshTwo()
        {
            try
            {
                client = new Service1Client();
                dataGrid1.ItemsSource = null;
                var result = await client?.GetVacancyAsync();
                dataGrid1.ItemsSource = result;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
