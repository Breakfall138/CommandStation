using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public abstract class Sprite
    {
        // Path to the sprite sheet file
        string spriteSheetPath { get; set; }
        // Sprite X, Y starting locations
        int spriteX { get; set; }
        int spriteY { get; set; }
        // sprite Width & Height in Pixels
        int spriteWidth { get; set; }
        int spriteHeight { get; set; }
    }
}
