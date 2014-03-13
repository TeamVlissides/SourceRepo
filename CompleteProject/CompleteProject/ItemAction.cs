using Character_System;
using Dungeon_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    class ItemAction : BattleAction
    {
        Item usedItem;
        public Character specificTarget;
        private ArrayList battleEvents;

        public ItemAction(Item itemToUse)
        {
            usedItem = itemToUse;
        }

        public ItemAction(Item itemToUse, Character targetedCharacter)
        {
            usedItem = itemToUse;
            specificTarget = targetedCharacter;
        }

        private void specificAction(Character actingCharacter, Character[] combatants)
        {
            if(usedItem.isSingleTarget)
            { 
                spreadItem(actingCharacter, combatants);
            }
            else
            {
                singleTargetItem(actingCharacter, specificTarget);
            }
        }

        private void singleTargetItem(Character actingCharacter, Character target)
        {
            //TODO: Figure out exact application of item
        }

        private void spreadItem(Character actingCharacter, Character[] combatants)
        {
            for (int i = 0; i < combatants.Length; i++)
            {
                if (combatants[i].mIsPlayer && !usedItem.AffectEnemy || !combatants[i].mIsPlayer && usedItem.AffectEnemy)
                {
                    //TODO: Figure out exact application of item
                }
            }
        }

        public string toString()
        {
            return " used " + usedItem.ToString() + " on ";
        }

        public ArrayList getBattleEvents()
        {
            return battleEvents;
        }
    }
}
