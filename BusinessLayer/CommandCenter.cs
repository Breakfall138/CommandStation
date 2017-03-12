using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer
{
    class CommandCenter : Building
    {
        // 

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
