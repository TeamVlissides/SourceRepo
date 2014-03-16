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
            if (!usedItem.isSingleTarget)
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
            /* This is an absolute horrible way to do inventory. There will be an if statement for each type of consumable.
             * Actually design a good inventory system if there's time. R.F. 3/14/2014 */
            if (usedItem.WhichItem == ItemEnum.HEALTHPOTION)
            {/* start if */

                target.restoreHealth((int)((usedItem.BaseDamage/ 100.0) * target.MaximumHealth));

            }/* end if */

            if (usedItem.WhichItem == ItemEnum.MANAPOTION)
            {/* start if */

                target.restoreMana((int)((usedItem.BaseDamage/100.0) * target.MaximumMana));

            }/* end if */
            
            if(usedItem.WhichItem == ItemEnum.BOMB )
            {/* start if */

                target.takeDamage(usedItem.BaseDamage);

            }/* end if */

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
