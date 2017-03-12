using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer
{
    class Mine : Building
    {
        //stores the value of the number of current soldiers in the building
        int soliersManned { get; set; }
        //stores the value of the number of maximum soldiers in the building
        int maxSoldiersManned { get; set; }
        //base number of resources a player earns per turn for a mine
        int resources { get; set; }
        //modifier for resources earned based on the number of gold in adjacent terrain
        int resourceModifier { get; set; }

        public override void Build(string name)
        {
            base.cost = new List<IResource>();
            base.cost.Add(new Ore(0));
            base.name = name;
            base.isDestroyed = false;
            base.level = 1;
        }
    }
}
