﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    public class WallTile : Tile
    {
        public WallTile()
        {
            itemType = (int)DungeonEnum.WALL;
        }
    }
}