using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class Gold : IResource
    {
        public int value { get; set; }
        public string name { get { return "Gold"; } }

        public Gold(int val)
        {
            value = val;
        }
    }
}
