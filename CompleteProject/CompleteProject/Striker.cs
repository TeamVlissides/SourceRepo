using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleSystem;

namespace Character_System
{/* start Character_System namespace */

    public class Striker : AI
    {/* start Striker class */

        public Striker()
        {/* start constructor */
        }/* end constructor */

        public override BattleEvent ai(Party goodGuys)
        {/* start ai */

            Character target = goodGuys.getCharacter(0);
            BattleAction action;
            int i;
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

                for (i = 0; i < goodGuys.Size; i++)
                    if (goodGuys.getCharacter(i).CurrentHealth < target.CurrentHealth)
                        target = goodGuys.getCharacter(i);

                if (theAbility.Cost > mEnemy.CurrentMana)
                    action = new BattleAction(ActionEnum.ATTACK, null);
                else
                    action = new BattleAction(ActionEnum.ABILITY, theAbility);

            }/* end if */
            else
            {/* start else */

                action = new BattleAction(ActionEnum.ATTACK, null);

            }/* end else */

            return new BattleEvent(mEnemy, action, target, 0);

        }/* end ai */

    }/* end Striker class */

}/* end Character_System namespace */
