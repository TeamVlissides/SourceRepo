﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    class AbilityAction : BattleAction
    {
        public Ability usedAbility;
        public Character specificTarget;
        private ArrayList battleEvents = new ArrayList();

        public AbilityAction(Ability abilityToUse)
        {
            usedAbility = abilityToUse;
        }

        public AbilityAction(Ability abilityToUse, Character targetedCharacter)
        {
            usedAbility = abilityToUse;
            specificTarget = targetedCharacter;
        }

        public void specificAction(Character actingCharacter, Character[] combatants)
        {
            int cost = usedAbility.Cost;
            actingCharacter.useMana(cost);

            if (usedAbility.isSingleTarget)
            {
                spreadAbility(actingCharacter, combatants);
            }
            else
            {
                singleTargetAbility(actingCharacter, specificTarget);
            }
        }

        private void singleTargetAbility(Character actingCharacter, Character target)
        {
            int base_stat = 1;
            if (usedAbility.isMagic)
            {
                base_stat = actingCharacter.getStat(StatEnum.MAGIC);
            }
            else
            {
                base_stat = actingCharacter.getStat(StatEnum.STRENGTH);
            }
            target.takeDamage(base_stat * usedAbility.BaseDamage);
        }

        private void spreadAbility(Character actingCharacter, Character[] combatants)
        {
            int base_stat = 1;
            if (usedAbility.isMagic)
            {
                base_stat = actingCharacter.getStat(StatEnum.MAGIC);
            }
            else
            {
                base_stat = actingCharacter.getStat(StatEnum.STRENGTH);
            }

            for (int i = 0; i < combatants.Length; i++)
            {
                if (combatants[i].isPlayer && !usedAbility.AffectEnemy || !combatants[i].isPlayer && usedAbility.AffectEnemy)
                {
                    combatants[i].takeDamage(base_stat * usedAbility.BaseDamage);
                }
            }
        }

        public string toString()
        {
            return " used " + usedAbility.ToString() + " on ";
        }

        public ArrayList getBattleEvents()
        {
            return battleEvents;
        }
    }
}

