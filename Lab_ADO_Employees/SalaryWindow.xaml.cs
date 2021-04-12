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
    /// Логика взаимодействия для Salary.xaml
    /// </summary>
    public partial class SalaryWindow : Window
    {
        Service1Client client;
        public SalaryWindow()
        {
            InitializeComponent();
            Refresh();
        }

        public async void Refresh()
        {
            try
            {
                client = new Service1Client();
                dataGrid1.ItemsSource = null;
                var result = await client?.GetSalaryAsync();
                dataGrid1.ItemsSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void edit_btn_Click(object sender, RoutedEventArgs e)
        {
            try { 
            EditSalaryWindow editSalaryWindow = new EditSalaryWindow();
            MySalary selectedSalRow = dataGrid1.SelectedItem as MySalary;
                if (dataGrid1.SelectedItem == null)
                {
                    MessageBox.Show("You are didn't select employee...");
                }
                else
                {

                    editSalaryWindow.hoursBox.Text = selectedSalRow.Hours.ToString();
                    editSalaryWindow.awardBox.Text = selectedSalRow.Award.ToString();
                    editSalaryWindow.nameBox.Text = selectedSalRow.EmplName;

                    if (editSalaryWindow.ShowDialog() == true)
                    {

                        if (editSalaryWindow.hoursBox.Text == "" || editSalaryWindow.awardBox.Text == "")
                        {
                            MessageBox.Show("Set all salary's data...");
                        }

                        else
                        {
                            selectedSalRow.Hours = Convert.ToDouble(editSalaryWindow.hoursBox.Text);
                            selectedSalRow.Award = Convert.ToDouble(editSalaryWindow.awardBox.Text);
                            client?.EditSalary(selectedSalRow);
                            Refresh();
                        }

                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void avg_btn_Click(object sender, RoutedEventArgs e)
        {            
            MessageBox.Show($"Average salary equals {client.GetAvgSalary()} $");
        }

        private void fund_btn_Click(object sender, RoutedEventArgs e)
        {            
            MessageBox.Show($"Payment fund equals {client.GetTotalSalary()} $");
        }
    }
}

