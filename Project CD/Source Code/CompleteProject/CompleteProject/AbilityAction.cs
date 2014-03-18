using Character_System;
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
        public Character specificTarget;
        private ArrayList battleEvents = new ArrayList();
        private int damage;

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

            if (!usedAbility.isSingleTarget)
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
            applyAbility(actingCharacter, target, base_stat);
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

            /* This loop does not take into account that enemies can have abilities as well. Maybe I didn't communicate that */
            for (int i = 0; i < combatants.Length; i++)
            {
                if (actingCharacter.isPlayer)
                {
                    if ((combatants[i].isPlayer && !usedAbility.AffectEnemy) || (!combatants[i].isPlayer && usedAbility.AffectEnemy))
                        applyAbility(actingCharacter, combatants[i], base_stat);
                }
                else
                {
                    if ((!combatants[i].isPlayer && !usedAbility.AffectEnemy) || (combatants[i].isPlayer && usedAbility.AffectEnemy))
                        applyAbility(actingCharacter, combatants[i], base_stat);
                }
            }
        }

        private void applyAbility(Character actingCharacter, Character target, int base_stat)
        {

            damage = usedAbility.BaseDamage * base_stat;

            if (!usedAbility.AffectEnemy)
            {
                target.restoreHealth(damage);
            }
            else
            {
                target.takeDamage(damage);
            }
            battleEvents.Add(new BattleEvent(actingCharacter, this, target));
        }

        public string toString()
        {   

            String mString;

            if (usedAbility.AffectEnemy)
                mString = "damage";
            else
                mString = "healing";

            return " used " + usedAbility.Name + " and did " + damage + " " + mString + " on ";
        }

        public ArrayList getBattleEvents()
        {
            return battleEvents;
        }
    }
}

