
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    interface IPlayer
    {
        string name { get; set; }

        List<Grid> grids { get; set; }
        List<Building> buildings { get; set; }
        List<IResource> resources { get; set; }

    }
}
