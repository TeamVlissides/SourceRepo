using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TileFactory: 
//
// 
// Need to create tile classes that are created when 
// createTile is called. 
//

namespace CSGameSystem
{
    public class TileFactory
    {
        public Tile createRandomTile(Random r)
        {

            DungeonEnum randomItemType = DungeonEnum.FREESPACE;
            

            // Deterime if tile has treasure/ a item or not.
            // This is not creating random numbers for each tile???
            // it creates the same numbers for all of them.
            //Random r = new Random();
            // Dont know but passing in the reference works.
            // But does not seem like a good thing to do.
           // int rand = r.Next() % 100;
            //Console.WriteLine("The Random Number is " + rand);

            // Put an item here.
           // if (rand % 2 != 0)
            {
                // decide what type of item to put here.
                // generate random itemtype number here and set the itemType to it.
                randomItemType = (DungeonEnum)r.Next(-1, 3);

                //hasAnItem = true;
                // Console.WriteLine("True." + r);
            }

            #region Version 1.2
            /*
            if (randomItemType == (int)DungeonEnum.NULL)
                tile = new NullTile(); // 
            if (randomItemType == (int)DungeonEnum.FREESPACE)
                tile = new FreespaceTile();
            if (randomItemType == (int)DungeonEnum.WALL)
                tile = new WallTile();

            // This would be just for a single tile with some items on it.
            if (randomItemType == (int)DungeonEnum.ITEM)
                tile = new ItemTile();
            if (randomItemType == (int)DungeonEnum.DRAGON)
                tile = new DragonTile();
            */
            #endregion

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

            return new Tile( randomItemType );

        }
    }
}
