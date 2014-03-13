using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_System
{
    public class FreespaceTile : Tile
    {
        public FreespaceTile()
        {
            itemType = (int)DungeonEnum.FREESPACE;
        }
    }
}
