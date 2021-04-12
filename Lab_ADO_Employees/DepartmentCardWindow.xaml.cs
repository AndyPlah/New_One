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
    /// Логика взаимодействия для DepartmentCardWindow.xaml
    /// </summary>
    public partial class DepartmentCardWindow : Window
    {
        DepartmentsWindow employeesWindow = new DepartmentsWindow();
        public String IdDep { get; set; }
        Service1Client client;
        public DepartmentCardWindow()
        {
            InitializeComponent();
        }

        public async void Refresh3()
        { 
            client = new Service1Client();
            dataGrid1.ItemsSource = null;
            try
            {
                var result = await client?.GetDepartmentCardAsync(IdDep);
                dataGrid1.ItemsSource = (System.Collections.IEnumerable)result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void vac_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                client = new Service1Client();
            VacancyByDep vw = new VacancyByDep();
            vw.dataGrid1.ItemsSource = null;
            var result = client?.GetVacancyByDepId(IdDep);
            vw.dataGrid1.ItemsSource = result;            
            vw.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void staff_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                client = new Service1Client();
            StaffByDepWindow st = new StaffByDepWindow();
            st.dataGrid1.ItemsSource = null;
            var result = client?.GetStaffByDepId(IdDep);
            st.dataGrid1.ItemsSource = result;           
            st.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
