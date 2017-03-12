using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Buildings
{
    public class SatComBAL
    {
        public SatCom Build(string name)
        {
            SatCom sc = new SatCom();
            sc.cost = new List<IResource>();
            sc.cost.Add(new Ore(150));
            sc.cost.Add(new Gold(100));
            sc.name = name;
            sc.isDestroyed = false;
            sc.level = 1;
            return sc;

        }

    }
}
