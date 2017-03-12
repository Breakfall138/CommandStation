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
        //stores the number of shots that are remaining 
        public int numShots;
        //stores the maximum number of shots
        public int maxShots; 

        public override void Build(string name)
        {
            base.cost = new List<IResource>();
            base.cost.Add(new Ore(200));
            base.ID = new Guid();
            base.name = name;
            base.isDestroyed = false;
            base.level = 1;
            numShots = 2;
            maxShots = 2;
        }
    }
}
