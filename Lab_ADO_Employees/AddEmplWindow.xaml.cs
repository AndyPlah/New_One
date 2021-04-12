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
    /// Логика взаимодействия для AddEmplWindow.xaml
    /// </summary>
    public partial class AddEmplWindow : Window
    {
        int[] a = Enumerable.Range(18, 55).ToArray();
        List<string> photo = new List<string>();

        public AddEmplWindow()
        {
            InitializeComponent();
            Service1Client client = new Service1Client();
            DirectoryInfo dinfo = new DirectoryInfo(@"c:\temper\Images2");
            try
            {
                var files = dinfo.GetFiles();
            foreach (var item in files)
            {
                photo.Add(item.FullName);
            }
            photoBox.ItemsSource = photo;            
            departmentBox.ItemsSource = client?.GetDepsID();            
            positionBox.ItemsSource = client?.GetPosID();
            ageBox.ItemsSource = a;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
