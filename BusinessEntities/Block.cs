using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Block
    {
        //has 4 states (with ship - damaged, with ship undamaged, no ship)
        public State state { get; set; }
        public bool isShot { get; set; }
        public Coordinates crd { get; set; }
       public Building building {get;set;}

       public Block (int x, int y)
        {
            this.isShot = false;
            this.state = State.Empty;
            this.crd = new Coordinates(x, y);
        }
    }
    public enum State { Empty, Damaged, Healthy };
}
