using Lab_ADO_Employees.Classes;
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
    /// Логика взаимодействия для EditEmployeeWindow.xaml
    /// </summary>
    public partial class EditEmployeeWindow : Window
    {
        public String IDEdit { get; set; }
        List<string> photo = new List<string>();
        int[] a = Enumerable.Range(18, 55).ToArray();
        Service1Client client;
        public EditEmployeeWindow()
        {
            InitializeComponent();
            client = new Service1Client();
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Images");
            var files = dinfo.GetFiles();
            foreach (var item in files)
            {
                photo.Add(item.FullName);
            }
            photoBox.ItemsSource = photo;
            departmentBox.ItemsSource = client?.GetDepsID();
            positionBox.ItemsSource = client.GetPosID();
            ageBox.ItemsSource = a;

        }

        public void Refresh()
        {
            client = new Service1Client();
                 
            try
            {
            var selectedEmp = client?.GetFullEmployee(IDEdit);
            IdBox.Text = selectedEmp.FId;
            nameBox.Text = selectedEmp.FName;
            phoneBox.Text = selectedEmp.FPhone;
            passportBox.Text = selectedEmp.FPassport;
            positionBox.SelectedItem = selectedEmp.FPosId;
            departmentBox.SelectedItem = selectedEmp.FDepId;
            photoBox.SelectedItem = selectedEmp.FPhoto;
            ageBox.SelectedItem = selectedEmp.FAge;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if (passportBox.Text == "" || phoneBox.Text == "" || positionBox.SelectedItem == null
                || departmentBox.SelectedItem == null || nameBox.Text == "" || photoBox.Text == "")
            {
                MessageBox.Show("Set Employee's data...");
            }

            else
            {
                try
                {
                    MyFullEmployee selectedEmp = new MyFullEmployee
                    {
                        FPassport = passportBox.Text,
                        FDepId = departmentBox.SelectedItem.ToString(),
                        FName = nameBox.Text,
                        FPosId = positionBox.SelectedItem.ToString(),
                        FPhone = phoneBox.Text,
                        FAge = Convert.ToInt32(ageBox.SelectedItem),
                        FPhoto = photoBox.SelectedItem.ToString(),
                        FId = IdBox.Text,
                    };

                    client?.EditEmployee(selectedEmp);
                    this.Close();
                    EmployeeCardWindow employeeCardWindow = new EmployeeCardWindow();
                    employeeCardWindow.IDText = IDEdit;
                    employeeCardWindow.Refresh();
                    employeeCardWindow.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
         }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
