using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    public class ItemTile : Tile
    {
        public ItemTile()
        {
            itemType = (int)DungeonEnum.ITEM;
        }
    }
}
