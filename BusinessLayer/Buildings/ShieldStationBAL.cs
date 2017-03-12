using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class ShieldStationBAL
    {

        public ShieldStation Build(string name)
        {
            ShieldStation ss = new ShieldStation();
            ss.cost = new List<IResource>();
            ss.cost.Add(new Ore(200));
            ss.ID = new Guid();
            ss.name = name;
            ss.isDestroyed = false;
            ss.level = 1;
            ss.maxBlocksProtected = 2;
            return ss; 

        }
    }
}
