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

        public override void Build(string name)
        {
            base.cost = new Ore(200);
            base.name = "Artillery";
            base.isDestroyed = false;
            base.level = 1;

        }
    }
}
