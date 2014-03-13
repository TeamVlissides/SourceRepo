using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    public class FreespaceTile : Tile
    {
        public FreespaceTile()
        {
            itemType = (int)DungeonEnum.FREESPACE;
        }
    }
}
