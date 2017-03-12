using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntities
{
    public abstract class Terrain
    {
        [Key]
        Guid ID { get; set; } 
        int mineValue { get; set; }
    }
}
