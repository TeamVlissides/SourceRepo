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
        Ability usedItem;
        public Character specificTarget;
        private ArrayList battleEvents = new ArrayList();

        public ItemAction(Ability itemToUse)
        {
            usedItem = itemToUse;
        }

        public ItemAction(Ability itemToUse, Character targetedCharacter)
        {
            usedItem = itemToUse;
            specificTarget = targetedCharacter;
        }

        public void specificAction(Character actingCharacter, Character[] combatants)
        {
            if (usedItem.isSingleTarget)
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
            applyItem(actingCharacter, target);
        }

        private void spreadItem(Character actingCharacter, Character[] combatants)
        {
            for (int i = 0; i < combatants.Length; i++)
            {
                if (combatants[i].isPlayer && !usedItem.AffectEnemy || !combatants[i].isPlayer && usedItem.AffectEnemy)
                {
                    applyItem(actingCharacter, combatants[i]);
                }
            }
        }

        private void applyItem(Character actingCharacter, Character target)
        {
            if (!usedItem.IsMana)
            {
                target.restoreHealth((int)((usedItem.BaseDamage/ 100) * target.MaximumHealth));
            }
            else if (usedItem.IsMana)
            {
                target.restoreMana((int)((usedItem.BaseDamage/100.0) * target.MaximumHealth));
            }
            else /*This assumes that the default/only other consumable item is a bomb. v___v*/
            {
                target.takeDamage((int)(usedItem.BaseDamage / 100.0 * target.MaximumHealth));
            }
            battleEvents.Add(new BattleEvent(actingCharacter, this, target));
        }

        public string toString()
        {
            return " used " + usedItem.Name + " on ";
        }

        public ArrayList getBattleEvents()
        {
            return battleEvents;
        }
    }
}
