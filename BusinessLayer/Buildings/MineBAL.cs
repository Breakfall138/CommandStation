using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class MineBAL
    {
        public Mine Build(string name)
        {
            Mine mine = new Mine();
            mine.cost = new List<IResource>();
            mine.cost.Add( new Ore(200));
            mine.ID = new Guid();
            mine.name = name;
            mine.isDestroyed = false;
            mine.level = 1;
            return mine;

        }
    }
}
