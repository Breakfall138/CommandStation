using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Buildings
{
    class CommandCenterBAL
    {
        public CommandCenter Build(string name)
        {
            CommandCenter cc = new CommandCenter();
            cc.cost = null;
            cc.name = name;
            cc.isDestroyed = false;
            cc.level = 1;
            return cc; 
        }
    }
}
