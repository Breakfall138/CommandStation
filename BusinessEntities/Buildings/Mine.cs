﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Mine : Building
    {
        //stores the value of the number of current soldiers in the building
        int soliersManned { get; set; }
        //stores the value of the number of maximum soldiers in the building
        int maxSoldiersManned { get; set; }
        //base number of resources a player earns per turn for a mine
        int resources { get; set; }
        //modifier for resources earned based on the number of gold in adjacent terrain
        int resourceModifier { get; set; }



    }
}
