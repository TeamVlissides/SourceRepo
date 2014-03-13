using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    public class NullTile : Tile
    {
        public NullTile()
        {
            itemType = (int)DungeonEnum.NULL;
        }
    }
}
