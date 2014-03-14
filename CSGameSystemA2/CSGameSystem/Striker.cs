using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BattleSystem;

namespace CSGameSystem
{/* start Character_System namespace */

    public class Striker : AI
    {/* start Striker class */

        public Striker()
        {/* start constructor */
        }/* end constructor */

        public override BattleAction ai(Party goodGuys)
        {/* start ai */

            Character target = getTarget( goodGuys );
            BattleAction action;
            AbilitiesIterator abilities;
            Ability theAbility;

            if (mAbilities.Count != 0)
            {/* start if */

                abilities = getAbilities();
                theAbility = abilities.getAbilityAtIndex(0);

                foreach (Ability ability in abilities)
                    if (ability.AffectEnemy)
                        if (ability.BaseDamage > theAbility.BaseDamage)
                            theAbility = ability;

                if (theAbility.Cost > mEnemy.CurrentMana)
                    action = new AttackAction( target );
                else
                    action = new AbilityAction( theAbility, target );

            }/* end if */
            else
            {/* start else */

                action = new AttackAction(target);

            }/* end else */

            return action;

        }/* end ai */

        private Character getTarget(Party goodGuys)
        {/* start getTarget */

            Character target = goodGuys.getCharacter(0);
            int i;

            for (i = 0; i < goodGuys.Size; i++)
                if (goodGuys.getCharacter(i).CurrentHealth < target.CurrentHealth)
                    target = goodGuys.getCharacter(i);

            return target;

        }/* end getTarget */

    }/* end Striker class */

}/* end Character_System namespace */
