﻿using System;
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

        private void specificAction(Character actingCharacter, Character[] combatants)
        {
            throw new NotImplementedException();
        }

        public string toString()
        {
            throw new NotImplementedException();
        }
    }
}
