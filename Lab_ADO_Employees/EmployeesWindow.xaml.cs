using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Employees.xaml
    /// </summary>
    public partial class EmployeesWindow : Window
    {
        public EmployeesWindow()
        {
            InitializeComponent();
            RefreshOne();
        }

        Service1Client client;
        public async void RefreshOne()
        {
            client = new Service1Client();
            dataGrid1.ItemsSource = null;
            try
            {
                var result = await client?.GetEmployeesAsync();
                dataGrid1.ItemsSource = (System.Collections.IEnumerable)result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {            
            dataGrid1.ItemsSource = null;
            if (search_pers_n.Text == "")
                MessageBox.Show("Set personel number...");
            else
            {
                try
                {
                    dataGrid1.Items.Clear();
                    dataGrid1.Items.Add(client?.SearchEmployee(search_pers_n.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void dataGrid1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                MyEmployee selectedEmpRow = dataGrid1.SelectedItem as MyEmployee;
                if (!File.Exists(@"c:\Images\" + selectedEmpRow.EmployeeId + ".jpg"))
                {
                    byte[] arr = await client.GetArrayAsync(@"c:\temper\Images2\" + selectedEmpRow.EmployeeId + ".jpg");
                    File.WriteAllBytes(@"c:\Images\" + selectedEmpRow.EmployeeId + ".jpg", arr);
                }
                EmployeeCardWindow employeeCardWindow = new EmployeeCardWindow();               
                employeeCardWindow.IDText = selectedEmpRow.EmployeeId;
                employeeCardWindow.Refresh();
                employeeCardWindow.Show();
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            AddEmplWindow addEmplWindow = new AddEmplWindow();
                if (addEmplWindow.ShowDialog() == true)
                {

                if (addEmplWindow.passportBox.Text == "" || addEmplWindow.phoneBox.Text == "" || addEmplWindow.positionBox.SelectedItem == null
                || addEmplWindow.departmentBox.SelectedItem == null || addEmplWindow.nameBox.Text == "" || addEmplWindow.IdBox.Text == "")
                {

                    MessageBox.Show("Set all new employee's data...");
                }

                else
                {
                    try
                    {
                        MyFullEmployee emp = new MyFullEmployee
                        {
                            FId = addEmplWindow.IdBox.Text,
                            FName = addEmplWindow.nameBox.Text,
                            FPassport = addEmplWindow.passportBox.Text,
                            FPhone = addEmplWindow.phoneBox.Text,
                            FPosId = addEmplWindow.positionBox.SelectedItem.ToString(),
                            FPhoto = addEmplWindow.photoBox.SelectedItem.ToString(),
                            FAge = (int)(int?)addEmplWindow.ageBox.SelectedItem,
                            FDepId = addEmplWindow.departmentBox.SelectedItem.ToString(),
                            
                        };

                        client?.AddEmployee(emp);

                        RefreshOne(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                 
                }
                }


        }

        private void del_btn_Click(object sender, RoutedEventArgs e)
        {
            MyEmployee selectedEmpRow = dataGrid1.SelectedItem as MyEmployee;
            if (dataGrid1.SelectedItem != null)
            {
                //// Получение id редактируемого объекта
                string selectedId = selectedEmpRow.EmployeeId;
                
                try
                {
                    client?.DeleteEmployee(selectedId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                RefreshOne();

            }

            else MessageBox.Show("You are didn't select employee...");
        }
    }
    
}
