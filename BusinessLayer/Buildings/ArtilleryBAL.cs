using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ArtilleryBAL
    {
        public Artillery Build(string name)
        {
            Artillery art = new Artillery();
            art.cost = new List<IResource>();
            art.cost.Add(new Ore(200));
            art.name = name;
            art.isDestroyed = false;
            art.level = 1;
            art.numShots = 2;
            art.maxShots = 2;
            return art; 
        }
    }
}
