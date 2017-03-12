using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Ore : IResource
    {
       public int value { get;set;}
       public string name { get { return "Ore"; } }

        public Ore(int val)
        {
            value = val;
        }
    }
}
