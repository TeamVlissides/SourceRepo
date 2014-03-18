using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleSystem;

namespace Character_System
{/* start Character_System */

    public class HealerAttacker : AI
    {/* start HealerAttacker */

        public HealerAttacker()
        {/* start constructor */
        }/* end constructor */

        public override BattleAction ai(Party goodGuys)
        {/* start ai */

            Random random = new Random();
            int i;
            Character target = null;

            /* Should modularize these loops */
            for (i = 0; i < goodGuys.Size; i++)
                if (((PlayerCharacter)goodGuys.getCharacter(i)).Class == ClassEnum.WHITEMAGE && !goodGuys.getCharacter(i).isDead)
                    target = goodGuys.getCharacter(i);

            if( target == null )
                for (i = 0; i < goodGuys.Size; i++)
                    if (((PlayerCharacter)goodGuys.getCharacter(i)).Class == ClassEnum.REDMAGE && !goodGuys.getCharacter(i).isDead)
                        target = goodGuys.getCharacter(i);

            if (target == null)
            {/* start if */

                target = goodGuys.getCharacter(random.Next(Party.MAXPARTY));

                while( target.isDead )
                    target = goodGuys.getCharacter(random.Next(Party.MAXPARTY));

            }/* end if */

            return new AttackAction(target);

        }/* end ai */

    }/* end HealerAttacker */

}/* end Character_System */
