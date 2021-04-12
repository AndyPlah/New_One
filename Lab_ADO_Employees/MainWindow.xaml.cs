using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab_ADO_Employees.ServiceReference1;
namespace Lab_ADO_Employees
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        Service1Client client;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            client = new Service1Client();
            int num = 0;
            num = client.CheckLogin(loginBox.Text, passwordBox.Password);
            if (num == 2)
            {
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.Show();
                this.Close();
            }
            else if (num == 1)
            {
                AddLoginWindow addLogin = new AddLoginWindow();
                if (addLogin.ShowDialog() == true)
                {

                    if (addLogin.loginIDBox.Text == "" || addLogin.loginBox.Text == "" || addLogin.passwordBox.Password == "")

                    {
                        MessageBox.Show("Set all new user's data...");
                    }

                    else
                    {
                        MyLogin nlog = new MyLogin
                        {
                            LoginId = addLogin.loginIDBox.Text,
                            Login = addLogin.loginBox.Text,
                            Password = addLogin.passwordBox.Password,
                        };
                        try
                        {
                            client?.AddLogin(nlog);
                        }

                        catch (FaultException<string> ex)
                        {
                            MessageBox.Show(ex.Detail);
                        }
                         
                    }
                }
                loginBox.Text = "";
                passwordBox.Password = "";
            }

            else
            {
                MessageBox.Show("Wrong Login or Password...");
                loginBox.Text = "";
                passwordBox.Password = "";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
