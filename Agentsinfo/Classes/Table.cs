using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agentsinfo.Classes;
using Agentsinfo.DataBase;

namespace Agentsinfo.Classes
{
    public  class ZapolnenieAgentTable
    {
        public static string Title { get; set; }
        public static string AgentTypeID { get; set; }
        public static string KPP { get; set; }
        public static string Phone { get; set; }
        public static string Priority { get; set; }
    }

    public  class Table
    {
        List<Agent> agents = Helper.Connection.Agent.ToList();


    }
}
