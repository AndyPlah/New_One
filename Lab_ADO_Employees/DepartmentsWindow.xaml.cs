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
    /// Логика взаимодействия для Departments.xaml
    /// </summary>
    public partial class DepartmentsWindow : Window
    {
        Service1Client client;
        public DepartmentsWindow()
        {
            InitializeComponent();
            RefreshTwo();
        }
        public async void RefreshTwo()
        {
            try
            {
                client = new Service1Client();
            dataGrid1.ItemsSource = null;           
            var result = await client?.GetDepartmentsAsync();
            dataGrid1.ItemsSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                
        private void dataGrid1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                MyDepartment selectDepRow = dataGrid1.SelectedItem as MyDepartment;
            DepartmentCardWindow departmentCardWindow = new DepartmentCardWindow();
            departmentCardWindow.IdDep = selectDepRow.IDdep;
            departmentCardWindow.Refresh3();
            departmentCardWindow.Show();
            this.Close();
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
            //dataGrid1.SelectedItem = null;
            EditDepartmentWindow editDepartmentWindow = new EditDepartmentWindow();
            MyDepartment selectedDepRow = dataGrid1.SelectedItem as MyDepartment;
            //department selecteddep = new department();
            if (dataGrid1.SelectedItem == null)
            {
                MessageBox.Show("You are didn't select department...");
            }
            else
            {                
                editDepartmentWindow.idBox.Text = selectedDepRow.IDdep;
                editDepartmentWindow.titleBox.Text = selectedDepRow.Title;
                editDepartmentWindow.headBox.Text = selectedDepRow.Head;
                editDepartmentWindow.cabinetBox.Text = selectedDepRow.RoomNumber;
                editDepartmentWindow.phoneBox.Text = selectedDepRow.Phone;


                if (editDepartmentWindow.ShowDialog() == true)
                {

                    if (editDepartmentWindow.titleBox.Text == "" || editDepartmentWindow.cabinetBox.Text == "" || editDepartmentWindow.phoneBox.Text == ""
                    || editDepartmentWindow.idBox.Text == "" || editDepartmentWindow.headBox.Text == "")
                    {
                        MessageBox.Show("Set all department's data...");
                    }

                    else
                    {
                        selectedDepRow.IDdep = editDepartmentWindow.idBox.Text;
                        selectedDepRow.Title = editDepartmentWindow.titleBox.Text;
                        selectedDepRow.Head = editDepartmentWindow.headBox.Text;
                        selectedDepRow.RoomNumber = editDepartmentWindow.cabinetBox.Text;
                        selectedDepRow.Phone = editDepartmentWindow.phoneBox.Text;
                        client?.EditDepartment(selectedDepRow);
                    }

                    
                    RefreshTwo();
                }

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            AddDepWindow addDepWindow = new AddDepWindow();
            if (addDepWindow.ShowDialog() == true)
            {

                if (addDepWindow.titleBox.Text == "" || addDepWindow.cabinetBox.Text == "" || addDepWindow.phoneBox.Text == ""
                    || addDepWindow.IdBox.Text == "")
                {

                    MessageBox.Show("Set all new department's data...");
                }

                else
                {
                    MyDepartment sDep = new MyDepartment
                    {
                        Title = addDepWindow.titleBox.Text,
                        Head = addDepWindow.headBox.Text,
                        RoomNumber = addDepWindow.cabinetBox.Text,
                        Phone = addDepWindow.phoneBox.Text,
                        IDdep = addDepWindow.IdBox.Text,
                    };

                    client?.AddDepartment(sDep);
                    RefreshTwo();
                }
            }
        }

        private void del_btn_Click(object sender, RoutedEventArgs e)
        {
            MyDepartment selectedDepRow = dataGrid1.SelectedItem as MyDepartment;
            if (dataGrid1.SelectedItem != null)
            {
                // Получение id редактируемого объекта
                string selectedId = selectedDepRow.IDdep;
                var num_emp = client?.GetEmployeesByDepId(selectedId);
                if (num_emp == 0)
                {
                    // Получить из БД ссылку на редактируемый объект в базе
                    try
                    {
                        client?.DeleteDepartment(selectedId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    RefreshTwo();
                }
                else MessageBox.Show("You can't delete this department (it still has employees)...");
            }
            else MessageBox.Show("You are didn't select department...");
        }
    }
}
