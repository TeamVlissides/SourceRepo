using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TileFactory: 
//
// Not finsihed yet. 
// 
// Need to create tile classes that are created when 
// createTile is called. 
//

namespace CSGameSystem
{
    public class TileFactory
    {
        public Tile createTile(String tileType)
        {
            /*
            if (tileType == "NULL")
                return new NullTile(); // 
            if (tileType == "FREESPACE")
                return new FreespaceTile();
            if (tileType == "WALL")
                return new WallTile();

            // This would be just for a single tile with some items on it.
            if (tileType == "ITEM") 
                return new ItemTile();
            if (tileType == "DRAGON")
                return new DragonTile();
                         * */
            return null;

        }
    }
}
