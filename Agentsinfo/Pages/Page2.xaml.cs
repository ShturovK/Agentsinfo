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

namespace Agentsinfo.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            var agent_list = Helper.Connection.Agent.ToList();
            var agenttype_list = Helper.Connection.AgentType.ToList();
            var Entry = new UserControl();
            // AgentType agentType= new AgentType();
            int i = 0;

            foreach (var agent in agent_list)

            {
                i++;
                foreach (var agenttype in agenttype_list)
                {
                    if (agent.ID <= 10 | agent.ID > 20)
                    {
                        break;
                    }
                    
                    else
                    {
                        if (Convert.ToInt32(agent.AgentTypeID) == agenttype.ID)
                        {
                            Entry = new UserControl1(agenttype, agent);
                            MainWrapPanel.Children.Add(Entry);
                        }
                    }


                }

            }
        }
    }
    
}
