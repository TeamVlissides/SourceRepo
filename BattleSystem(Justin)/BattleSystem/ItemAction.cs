﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    class ItemAction : BattleAction
    {
        Item usedItem;

        public ItemAction(Item itemToUse)
        {
            usedItem = itemToUse;
        }

        public void specificAction(Character actingCharacter, ref Character target)
        {
            throw new NotImplementedException();
        }

        public string toString()
        {
            throw new NotImplementedException();
        }
    }
}
