using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer
{
    public class RepairShop : Building
    {
        //stores the value of the number of current soldiers in the building
        int soliersManned { get; set; }
        //stores the value of the number of maximum soldiers in the building
        int maxSoldiersManned { get; set; }


    }
}
