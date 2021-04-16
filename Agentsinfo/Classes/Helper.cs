using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agentsinfo.DataBase;

namespace Agentsinfo.Classes
{
    public static class  Helper
    {
      public static User07Entities Connection = new User07Entities();
        public static Agent agent = null;
        public static AgentType agentType = null;
    }
}
