﻿using System;
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

        public override BattleEvent ai(Party goodGuys)
        {/* start ai */

            Random random = new Random();
            int i;
            Character target = null;
            BattleAction action = new BattleAction(ActionEnum.ATTACK, null);

            /* Should modularize these loops */
            for (i = 0; i < goodGuys.Size; i++)
                if (((PlayerCharacter)goodGuys.getCharacter(i)).Class == ClassEnum.WHITEMAGE)
                    target = goodGuys.getCharacter(i);

            if( target == null )
                for (i = 0; i < goodGuys.Size; i++)
                    if (((PlayerCharacter)goodGuys.getCharacter(i)).Class == ClassEnum.REDMAGE)
                        target = goodGuys.getCharacter(i);

            if (target == null)
                target = goodGuys.getCharacter(random.Next(Party.MAXPARTY));

            return new BattleEvent(mEnemy, action, target, 0);

        }/* end ai */

    }/* end HealerAttacker */

}/* end Character_System */
