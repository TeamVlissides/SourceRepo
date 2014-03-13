using Character_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    class AttackAction : BattleAction
    {
        String attackResult;
        Character target;
        ArrayList battleEvents;
        
        public AttackAction(Character targetedCharacter)
        {
            target = targetedCharacter;
        }

        public void specificAction(Character actingCharacter, Character[] combatants)
        {
            
            int attack = actingCharacter.getStat(StatEnum.STRENGTH);
            int damage = attack - target.getStat(StatEnum.ARMOR);
            if (damage > 0)
            {
                target.takeDamage(damage);
                attackResult = " attacked and did " + damage + " to ";
            }
            else
            {
                attackResult = " was unable to damage ";
            }
            battleEvents.Add(new BattleEvent(actingCharacter, this, target));
        }

        public string toString()
        {
            return attackResult;
        }

        public ArrayList getBattleEvents()
        {
            return battleEvents;
        }
    }
}
