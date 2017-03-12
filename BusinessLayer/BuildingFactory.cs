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
        public Building Create(string type, string name)
        {
            switch (type)
            {
                case "Artillery":
                    {
                        Artillery art = new Artillery();
                        art.Build(name);
                        return art;
                    }
                case "RepairShop":
                    {

                        RepairShop rs = new RepairShop();
                        rs.Build(name);
                        return rs;
                    }
                case "SatCom":
                    {
                        SatCom sc = new SatCom();
                        sc.Build(name);
                        return sc;
                    }
                case "ShieldStation":
                    {
                        ShieldStation ss = new ShieldStation();
                        ss.Build(name);
                        return ss;
                    }
                case "Barracks": { Barracks bar = new Barracks();
                        bar.Build(name);
                        return bar;
                    }
                case "Mine":
                    {
                        Mine mine = new Mine();
                        mine.Build(name);
                        return mine;
                    }
                case "CommandCenter":
                    {
                        CommandCenter cc = new CommandCenter();
                        cc.Build(name);
                        return cc;
                    }
                default: {
                        //NEED TO ADD Logging here
                        throw new Exception("Building Type  incorrect. "); }
            }
            
   
        }

    }
}
