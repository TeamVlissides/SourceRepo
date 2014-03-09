﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battle_System;

namespace Character_System
{/* start Character_System */

    public abstract class AI : AbilitiesHolder
    {/* start AI class */

        public void addAbility(Ability ability)
        {/* start addAbility */

            mAbilities.Add(ability);

        }/* end addAbility */

        public abstract BattleEvent ai(Character[] goodGuys);

    }/* end AI class */

}/* end Character_System */
