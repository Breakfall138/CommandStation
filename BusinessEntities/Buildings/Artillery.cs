using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Artillery : Building
    {
        //stores the number of shots that are remaining 
        public int numShots;
        //stores the maximum number of shots
        public int maxShots; 
    }
}
