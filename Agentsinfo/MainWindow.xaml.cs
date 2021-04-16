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
using System.Windows.Navigation;
using Agentsinfo.Pages;
using Agentsinfo.Classes;
using Agentsinfo.DataBase;

namespace Agentsinfo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Agent> agents = Helper.Connection.Agent.ToList();
        List<AgentType> agentTypes = Helper.Connection.AgentType.ToList();

        public MainWindow()
        {
         
            InitializeComponent();
            var tipe_list = Helper.Connection.AgentType.ToList();
            foreach (var tipe in tipe_list )
            {
                var converttipe = tipe.Title.ToString();
                Filtr.Items.Add(converttipe); 
            }
            Filtr.Items.Add("Фильтрация");
            Filtr.SelectedItem="Фильтрация";
            Sort.Items.Add("Сортировка");
            Sort.Items.Add("По возрастанию скидки");
            Sort.Items.Add("По убыванию скидки");
            Sort.Items.Add("Возрастание приоритета");
            Sort.Items.Add("Убывание приоритета");
            Sort.Items.Add("От А до Я");
            Sort.Items.Add("От Я до А");
            Sort.SelectedItem = "Сортировка";
            infpole.Navigate(new Page1());
            var agent_list = Helper.Connection.Agent.ToList();
            
            foreach (var agent in tipe_list)
            {
           
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            infpole.Navigate(new Page1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            infpole.Navigate(new Page2());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            infpole.Navigate(new Page3());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            infpole.Navigate(new Page4());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            infpole.Navigate(new Poisk());
        }










        //   infpole.Navigate(new Poisk());

    }
}
