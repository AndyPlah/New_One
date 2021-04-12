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
    /// Логика взаимодействия для Staff_Table.xaml
    /// </summary>
    public partial class Staff_TableWindow : Window
    {
        Service1Client client;
        public Staff_TableWindow()
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
                var result = await client?.GetStaffTableAsync();
                dataGrid1.ItemsSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            AddStaffWindow addStaffWindow = new AddStaffWindow();
            if (addStaffWindow.ShowDialog() == true)
            {

                if (addStaffWindow.titleBox.Text == "" || addStaffWindow.IdBox.Text == "" || addStaffWindow.depBox.Text == "" || addStaffWindow.quanBox.SelectedItem == null
                    || addStaffWindow.nowBox.SelectedItem == null || addStaffWindow.tariffBox.Text == "")

                {

                    MessageBox.Show("Set all new staff's data...");
                }

                else
                {
                    MyStaffTable sSt = new MyStaffTable
                    {
                        IdPosFor = addStaffWindow.IdBox.Text,
                        DepFor = addStaffWindow.depBox.SelectedItem.ToString(),
                        Quantity = (int)addStaffWindow.quanBox.SelectedItem,
                        Now = (int)addStaffWindow.nowBox.SelectedItem,
                    };
                    client?.AddStaff(sSt);
                    MyPosition sPs = new MyPosition

                    {
                        PosId = addStaffWindow.IdBox.Text,
                        PosTitle = addStaffWindow.titleBox.Text,
                        PosTariff = Convert.ToDouble(addStaffWindow.tariffBox.Text),
                    };
                    client?.AddPosition(sPs);
                    RefreshTwo();
                }
            }
        }

        private void del_btn_Click(object sender, RoutedEventArgs e)
        {
            MyStaffTable selectedStaffRow = dataGrid1.SelectedItem as MyStaffTable;
            if (dataGrid1.SelectedItem != null)
            {
                // Получение id редактируемого объекта
                string selectedId = selectedStaffRow.IdPosFor;
                var num_emp = client?.GetEmployeesByPosId(selectedId);

                if (num_emp == 0)
                {
                    client?.DeleteStaff(selectedId);
                    RefreshTwo();
                }
                else MessageBox.Show("You can't delete this staff (it still has employees)...");
            }
            else MessageBox.Show("You are didn't select staff...");
        }

        private void edit_btn_Click(object sender, RoutedEventArgs e)
        {
            EditStaffWindow editStaffWindow = new EditStaffWindow();
            MyStaffTable selectedStRow = dataGrid1.SelectedItem as MyStaffTable;
            if (dataGrid1.SelectedItem != null)
            {
                // Получение id редактируемого объекта
                string selectedId = selectedStRow.IdPosFor;
                
                editStaffWindow.IdBox.Text = selectedStRow.IdPosFor.ToString();
                editStaffWindow.quanBox.SelectedItem = selectedStRow.Quantity;
                editStaffWindow.nowBox.SelectedItem = selectedStRow.Now;

                if (editStaffWindow.ShowDialog() == true)
                {

                    if (editStaffWindow.quanBox.SelectedItem == null || editStaffWindow.nowBox.SelectedItem == null)
                    {
                        MessageBox.Show("Set all staff's data...");
                    }

                    else
                    {
                        selectedStRow.IdPosFor = editStaffWindow.IdBox.Text;
                        selectedStRow.Quantity = (int)editStaffWindow.quanBox.SelectedItem;
                        selectedStRow.Now = (int)editStaffWindow.nowBox.SelectedItem;

                        client?.EditStaff(selectedStRow);
                        RefreshTwo();
                    }                   
                    
                }
            }
            else MessageBox.Show("You are didn't select position...");
        }

    }
}
