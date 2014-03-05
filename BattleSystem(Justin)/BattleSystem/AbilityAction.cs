using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    class AbilityAction : BattleAction
    {
        public Ability usedAbility;
        public int specificTarget;
        private ArrayList battleEvents;

        public AbilityAction(Ability abilityToUse)
        {
            usedAbility = abilityToUse;
        }

        public AbilityAction(Ability abilityToUse, int target)
        {
            usedAbility = abilityToUse;
            specificTarget = target;
        }

        private void specificAction(Character actingCharacter, Character[] combatants)
        {
            int cost = usedAbility.Cost;
            actingCharacter.useMana(cost);
            
            if(usedAbility.isSingleTarget())
            { 
                spreadAbility(actingCharacter, combatants);
            }
            else
            {
                singleTargetAbility(actingCharacter, combatants[specificTarget]);
            }
        }

        private void singleTargetAbility(Character actingCharacter, Character target)
        {
            //TODO: Figure out exact application of ability
        }

        private void spreadAbility(Character actingCharacter, Character[] combatants)
        {
            for (int i = 0; i < combatants.Length; i++)
            {
                if (combatants[i].mIsPlayer && !usedAbility.mAffectEnemy || !combatants[i].mIsPlayer && usedAbility.mAffectEnemy)
                {
                    //TODO: Figure out exact application of ability
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
