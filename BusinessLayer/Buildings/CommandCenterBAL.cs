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
            cc.cost = new List<IResource>();
            // TODO: Need to determine actual CC cost
            cc.cost.Add(new Ore(0));
            cc.cost.Add(new Gold(0));
            cc.name = name;
            cc.isDestroyed = false;
            cc.level = 1;
            return cc;
        }
    }
}
