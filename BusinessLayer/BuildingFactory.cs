using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class BuildingFactory
    {
        public BuildingFactory(){}

        //called by game classes to build the building type and return it. 
        public Building Create(string type)
        {
            switch (type)
            {
                case "Artillery": { return new Artillery(); }
                case "RepairShop": { return new RepairShop(); }
                case "SatCom": { return new SatCom(); }
                case "ShieldStation": { return new ShieldStation(); }
                case "Barracks": { return new Barracks(); }
                default: { throw new Exception("Building Type  incorrect. "); }
            }
            
   
        }

    }
}
