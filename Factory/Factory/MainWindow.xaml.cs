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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.IO;


namespace Factory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] city { get; set; }
        public string[] workshop { get; set; }
        public string[] employee { get; set; }
        public string[] brigade { get; set; }
        public string[] shift { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            city = new string[] {"Омск", "Москва", "Санк-Петербург", "Новосибирск", "Тюмень"};
            workshop = new string[] {"1-й Цех", "2-й Цех", "3-й Цех", "4-й Цех", "5-й Цех" };
            employee = new string[] {"1-й работник", "2-й работник", "3-й работник", "4-й работник", "5-й работник" };
            brigade = new string[] {"1-я бригада", "2-я бригада"};
            shift = new string[] {"Смена с 08:00 до 20:00", "Смена с 20:00 до 08:00" };

            DataContext = this;
        }

        private void cbCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbCity.SelectedIndex == 0)
            {
               workshop = new string[] { "1-й Цех" };
               cbWorkshop.ItemsSource = workshop;
            }
            else if (cbCity.SelectedIndex == 1)
            {
                workshop = new string[] { "2-й Цех" };
                cbWorkshop.ItemsSource = workshop;
            }
            else if (cbCity.SelectedIndex == 2)
            {
                workshop = new string[] { "3-й Цех" };
                cbWorkshop.ItemsSource = workshop;
            }
            else if (cbCity.SelectedIndex == 3)
            {
                workshop = new string[] { "4-й Цех" };
                cbWorkshop.ItemsSource = workshop;
            }
            else if (cbCity.SelectedIndex == 4)
            {
                workshop = new string[] { "5-й Цех" };
                cbWorkshop.ItemsSource = workshop;
            }
        }

        private void cbBrigade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbBrigade.SelectedIndex == 0)
            {
                shift = new string[] { "Смена с 08:00 до 20:00"};
                cbShift.ItemsSource = shift;
                cbShift.Text = "Смена с 08:00 до 20:00";
            }
            else if(cbBrigade.SelectedIndex == 1)
            {
                shift = new string[] { "Смена с 20:00 до 08:00" };
                cbShift.ItemsSource = shift;
                cbShift.Text = "Смена с 20:00 до 08:00";
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cbCity.Text != "" && cbWorkshop.Text != "" && cbEmployee.Text != "" && cbShift.Text != "" && cbBrigade.Text != "")
            {
                FactoryOrder factory = new FactoryOrder(cbCity.Text, cbWorkshop.Text, cbEmployee.Text, cbShift.Text, cbBrigade.Text);
                string json = JsonConvert.SerializeObject(factory);
                File.WriteAllText("qq.json", json);
                MessageBox.Show("Данные сохранены!");
            }
            else MessageBox.Show("Заполните все поля!", "Внимание!", MessageBoxButton.OK);
        }
    }
}
