using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Player : IPlayer
    {
        public string name
        {
            get; set;
        }

        public List<Grid> grids
        {
            get; set;
        }

        public List<Building> buildings
        {
            get; set;
        }
        
        public List<IResource> resources
        {
            get; set;
        }

    }
}
