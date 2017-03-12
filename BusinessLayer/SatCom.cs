using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer
{
    class SatCom : Building
    {
        //stores the value of the number of current soldiers in the building
        int soliersManned { get; set; }
        //stores the value of the number of maximum soldiers in the building
        int maxSoldiersManned { get; set; }
        //stores the number of blocks that can be revealed.
        int numBlocksRevealed { get; set; }


        public override void Build(string name)
        {
            base.cost = new Ore(200);
            base.name = "Artillery";
            base.isDestroyed = false;
            base.level = 1;

        }
    }
}
