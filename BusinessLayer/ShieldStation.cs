using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer
{
    class ShieldStation : Building
    {
        //number of blocks that can be protected
        int maxBlocksProtected { get; set; }
        //holds a list of coordinates to the protected blocks. 
        List<Coordinates> blocksProtected = new List<Coordinates>(); 

        public override void Build(string name)
        {
            base.cost = new List<IResource>();
            base.cost.Add(new Ore(300));
            base.ID = new Guid();
            base.name = name;
            base.isDestroyed = false;
            base.level = 1;
            maxBlocksProtected = 2;
        }
    }
}
