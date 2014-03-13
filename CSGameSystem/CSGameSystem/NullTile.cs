﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// An attempt to use the Null Object pattern

// Provide an object as a surrogate for the lack of an object of a given type.
// The Null Object Pattern provides intelligent do nothing behavior, hiding the details from its collaborators.
//
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
