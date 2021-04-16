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
using Agentsinfo.DataBase;
using Agentsinfo.Classes;


namespace Agentsinfo
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1(AgentType agentType,Agent agent)
        {
            InitializeComponent();
            //AgentImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 9, 9) + product.MainImagePath, UriKind.Absolute));
            TipName.Content = agentType.Title+" | "+ agent.Title;
            prodag.Content = "Количество продаж за год: "+agent.KPP;
            phone.Content = agent.Phone;
            Prioritet.Content = "Приоритетность: "+ agent.Priority;
            Prochent.Content = agent.Priority;

        }
    }
}
