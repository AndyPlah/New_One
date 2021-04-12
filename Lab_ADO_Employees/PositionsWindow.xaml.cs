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
    /// Логика взаимодействия для Positions.xaml
    /// </summary>
    public partial class PositionsWindow : Window
    {
        Service1Client client;
        public PositionsWindow()
        {
            InitializeComponent();
            RefreshOne();
        }

        public async void RefreshOne()
        {
            try
            {
                client = new Service1Client();
                dataGrid1.ItemsSource = null;
                var result = await client?.GetPositionsAsync();
                dataGrid1.ItemsSource = result;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}


        //private void add_btn_Click(object sender, RoutedEventArgs e)
        //{
        //    AddPositionWindow addPositionWindow = new AddPositionWindow();
        //    if (addPositionWindow.ShowDialog() == true)
        //    {

        //        if (addPositionWindow.titleBox.Text == "" || addPositionWindow.IdBox.Text == "" || addPositionWindow.tariffBox.Text == "")
        //        {

        //            MessageBox.Show("Set all new position's data...");
        //        }

        //        else
        //        {
        //            position sPos = new position
        //            {
        //                title = addPositionWindow.titleBox.Text,
        //                positionId = addPositionWindow.IdBox.Text,
        //                tariff = Convert.ToDouble(addPositionWindow.tariffBox.Text),
        //            };

        //            context.position.InsertOnSubmit(sPos);
        //            // Синхронизация с БД
        //            context.SubmitChanges();

        //            RefreshOne();
        //        }
        //    }
        //}

        //private void del_btn_Click(object sender, RoutedEventArgs e)
        //{
        //    Position selectedPosRow = dataGrid1.SelectedItem as Position;
        //    if (dataGrid1.SelectedItem != null)
        //    {
        //        // Получение id редактируемого объекта
        //        string selectedTitle = selectedPosRow.PosTitle;
        //        // Получить из БД ссылку на редактируемый объект в базе
        //        position selecteddep = (from t in context.position
        //                                where t.title == selectedTitle
        //                                select t).First();
        //        context.position.DeleteOnSubmit(selecteddep);
        //        context.SubmitChanges();
        //        RefreshOne();
        //    }
        //    else MessageBox.Show("You are didn't select department...");
        //}

        private void edit_btn_Click(object sender, RoutedEventArgs e)
        {
            EditPositionWindow editPositionWindow = new EditPositionWindow();
            MyPosition selectedPosRow = dataGrid1.SelectedItem as MyPosition;
            //position selectedpos = new position();
            if (dataGrid1.SelectedItem == null)
            {
                MessageBox.Show("You are didn't select position...");
            }

            else
            {                
                editPositionWindow.IdBox.Text = selectedPosRow.PosId;
                editPositionWindow.titleBox.Text = selectedPosRow.PosTitle;
                editPositionWindow.tariffBox.Text = selectedPosRow.PosTariff.ToString();

                if (editPositionWindow.ShowDialog() == true)
                {

                    if (editPositionWindow.titleBox.Text == "" || editPositionWindow.IdBox.Text == "" || editPositionWindow.tariffBox.Text == "")

                    {
                        MessageBox.Show("Set all position's data...");
                    }

                    else
                    {
                        selectedPosRow.PosTitle = editPositionWindow.titleBox.Text;
                        selectedPosRow.PosId = editPositionWindow.IdBox.Text;
                        selectedPosRow.PosTariff = Convert.ToDouble(editPositionWindow.tariffBox.Text);
                        client?.EditPosition(selectedPosRow);
                        RefreshOne();
                    }                    
                   
                }
            }

        }
    }
}
