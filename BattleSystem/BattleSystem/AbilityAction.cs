using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    class AbilityAction : BattleAction
    {
        public Ability usedAbility;

        public AbilityAction(Ability abilityToUse)
        {
            usedAbility = abilityToUse;
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
