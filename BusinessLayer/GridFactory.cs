using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class GridFactory
    {
        public Grid Create(string gridType, int x, int y)
        {
            switch (gridType)
            {
                case "Defense":
                    {
                        DefenseGrid Dgrid = new DefenseGrid();
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < y; j++)
                            {
                                //set all blocks to empty, and no shots
                                Dgrid.grid[i, j] = new Block(i, j);

                            }
                        }
                        return Dgrid;
                    }
                case "Offense":
                    {
                        OffenseGrid Ogrid = new OffenseGrid();
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < y; j++)
                            {
                                //set all blocks to empty, and no shots
                                Ogrid.grid[i, j] = new Block(i, j);

                            }
                        }
                        return Ogrid;
                    }
                default: { throw new NotImplementedException(); }
            }
            //    private Grid setupGrid(int x, int y)
            //{
            //    return 
            //}
        }
    }
}
