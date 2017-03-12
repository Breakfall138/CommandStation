using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public abstract class Building
    {
        //stores a value for 1 if destroyed, and 0 if not destroyed
        public bool isDestroyed { get; set; }
        // stores the name of the building
        public string name { get;  set; }
        //stores the amount it costs to purchase the building
        public IResource cost { get; set; }
        //stores the current level of the building
        public int level { get; set; }

        public Building()
        {
            //Structure = new Block[length];
            //for (int i = 0; i < Structure.Length; i++)
            //{
            //        SetupBlock(Structure[i]);
            //}
        }
        public abstract void Build(string name);

        //private Block SetupBlock(Block blk)
        //{
        //    //blk.isShot = false;
        //    //blk.state = State.Healthy;
        //    //return blk;
        //}
    }
}
