using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    class AttackAction : BattleAction
    {
        String attackResult = " attacked ";
        
        public AttackAction(int i)
        {
            
        }

        private void specificAction(Character actingCharacter, Character target)
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
        }

        public string toString()
        {
            return attackResult;
        }
    }
}
