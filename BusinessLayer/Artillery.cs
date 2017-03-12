using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Artillery : Building
    {
        public int numShots;
        public int maxShots; 

        public override void Build(string name)
        {
            //base.Structure = area;
            base.cost = new Ore(200);
            base.name = name;
            base.isDestroyed = false;
            base.level = 1;
            numShots = 2;
            maxShots = 2;
        }
    }
}
