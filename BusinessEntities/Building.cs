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
        public bool isDestroyed { get; set; }
        public string name { get;  set; }
       // public Block[] Structure;
        public IResource cost { get; set; }
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
