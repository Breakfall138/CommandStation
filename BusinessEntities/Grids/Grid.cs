using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public abstract class Grid
    {
        public string name;
        public Block[,] grid;
        //public Block[] grid;

        //public Grid(int x, int y)
        //{
        //    //grid = new Block[x* y];

        //    //int cnt = 0; 
        //    //for (int i = 0; i<x;i++)
        //    //{
        //    //    for(int j =0; j<y;j++)
        //    //    {
        //    //        //set all blocks to empty, and no shots
        //    //        grid[cnt] = new Block(i,j);
        //    //        cnt++;
        //    //    }
        //    //}
        //    grid = new Block[x , y];


        //    for (int i = 0; i < x; i++)
        //    {
        //        for (int j = 0; j < y; j++)
        //        {
        //            //set all blocks to empty, and no shots
        //            grid[i,j] = new Block(i, j);

        //        }
        //    }
        //}

        public Grid() { }

        //Block GetBlock(Coordinates crd)
        //{
        //    return grid[crd.x, crd.y];
        //}
        //void SetBlock(Block blk)
        //{
        //   grid[x, y] = blk;
        //}

        
        
    }
}
