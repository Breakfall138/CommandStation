using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer.Buildings
{
    public class BarracksBAL
    {
        public Barracks Build(string name)
        {
            Barracks bar = new Barracks();
            bar.cost = new List<IResource>();
            bar.cost.Add(new Ore(100));
            bar.name = name;
            bar.isDestroyed = false;
            bar.level = 1;
            bar.numPeople = 2;
            return bar;
        }
    }
}
