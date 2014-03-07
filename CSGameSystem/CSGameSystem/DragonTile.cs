using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    public class DragonTile : Tile
    {
        public DragonTile()
        {
            itemType = (int)DungeonEnum.DRAGON;
        }
    }
}
