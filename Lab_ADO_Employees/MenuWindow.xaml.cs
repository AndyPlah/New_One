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

namespace Lab_ADO_Employees
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }
        
        private void emp_btn_Click(object sender, RoutedEventArgs e)
        {
            EmployeesWindow employeesWindow = new EmployeesWindow();
            employeesWindow.Show();
           
        }

        private void dep_btn_Click(object sender, RoutedEventArgs e)
        {
            DepartmentsWindow departmentsWindow = new DepartmentsWindow();
            departmentsWindow.Show();
        }

        private void pos_btn_Click(object sender, RoutedEventArgs e)
        {
            PositionsWindow positionsWindow = new PositionsWindow();
            positionsWindow.Show();
        }

        private void salary_btn_Click(object sender, RoutedEventArgs e)
        {
            SalaryWindow salaryWindow = new SalaryWindow();
            salaryWindow.Show();
        }

        private void staff_btn_Click(object sender, RoutedEventArgs e)
        {
            Staff_TableWindow staff_TableWindow = new Staff_TableWindow();
            staff_TableWindow.Show();
        }

        private void vac_btn_Click(object sender, RoutedEventArgs e)
        {
            VacanciesWindow vacanciesWindow = new VacanciesWindow();
            vacanciesWindow.Show();
        }
    }
}
