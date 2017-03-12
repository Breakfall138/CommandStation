using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer
{
    public class Barracks : Building
    {
        //stores the number of people that are added
        int numPeople { get; set; } 

        public Barracks()
        {
          
            
        }

        public override void Build(string name)
        {
            base.cost = new List<IResource>();
            base.cost = new Ore(200);
            base.name = "Barracks";
            base.isDestroyed = false;
            base.level = 1;
            numPeople = 2;
            
        }

    }
}
