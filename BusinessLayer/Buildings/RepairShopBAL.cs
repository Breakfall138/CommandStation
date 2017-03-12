using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class RepairShopBAL
    {
        public RepairShop Build(string name)
        {
            RepairShop rs = new RepairShop();
            rs.cost = new List<IResource>();
            rs.cost.Add(new Ore(200));
            rs.ID = new Guid();
            rs.name = name;
            rs.isDestroyed = false;
            rs.level = 1;
            return rs; 
        }
    }
}
