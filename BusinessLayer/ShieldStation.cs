using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer
{
    public class ShieldStation : Building
    {
        //number of blocks that can be protected
        public int maxBlocksProtected { get; set; }
        //holds a list of coordinates to the protected blocks. 
        public List<Coordinates> blocksProtected = new List<Coordinates>(); 

    }
}
