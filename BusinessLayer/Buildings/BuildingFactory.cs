using BusinessEntities;
using BusinessLayer.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class BuildingFactory
    {
        public BuildingFactory(){}

        //called by game classes to build the building type and return it. 
        public Building Create(string type, string name)
        {
            switch (type)
            {
                case "Artillery":
                    {
                        ArtilleryBAL art = new ArtilleryBAL();
                        return art.Build(name);
                    }
                case "RepairShop":
                    {
                        RepairShopBAL rs = new RepairShopBAL();
                        return rs.Build(name);
                    }
                case "SatCom":
                    {
                        SatComBAL sc = new SatComBAL();
                        return sc.Build(name);
                    }
                case "ShieldStation":
                    {
                        ShieldStationBAL ss = new ShieldStationBAL();
                        return ss.Build(name);
                    }
                case "Barracks": {
                        BarracksBAL bar = new BarracksBAL();
                        return bar.Build(name);
                    }
                case "Mine":
                    {
                        MineBAL mine = new MineBAL();
                        return mine.Build(name);
                    }
                case "CommandCenter":
                    {
                        CommandCenterBAL cc = new CommandCenterBAL();
                        return cc.Build(name);
                    }
                default: {
                        //NEED TO ADD Logging here
                        throw new Exception("Building Type  incorrect. "); }
            }
            
   
        }

    }
}
