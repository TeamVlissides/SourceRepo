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

            Character target;
            int i;

            Character[] alivePlayers = getAliveCharacters(goodGuys);

            for (i = 0, target = alivePlayers[ 0 ]; i < alivePlayers.Length; i++)
                if (alivePlayers[ i ].CurrentHealth < target.CurrentHealth)
                    target = alivePlayers[ i ];

            return target;

        }/* end getTarget */

        private Character[] getAliveCharacters(Party goodGuys)
        {/* start getAliveCharacters */

            int i, j, count = 0;
            Character[] alivePlayers;

            for (i = 0; i < goodGuys.Size; i++)
                if (!goodGuys.getCharacter(i).isDead)
                    count++;

            alivePlayers = new Character[count];

            for( i = 0,j = 0; i < goodGuys.Size; i++ )
                if (!goodGuys.getCharacter(i).isDead)
                {/* start if */

                    alivePlayers[j] = goodGuys.getCharacter(i);
                    j++;

                }/* end if */

            return alivePlayers;

        }/* end getAliveCharacters */

    }/* end Striker class */

}/* end Character_System namespace */
