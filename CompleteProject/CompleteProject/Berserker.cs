using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleSystem;

namespace Character_System
{/* start Character_System namespace */

    public class Berserker : AI
    {/* start Berserker class */

        public Berserker()
        {/* start constructor */
        }/* end constructor */

        public override BattleAction ai(Party goodGuys)
        {/* start ai */

            Random random = new Random();
            int target = random.Next( goodGuys.Size );

            return new AttackAction(goodGuys.getCharacter(target));

        }/* end ai */

    }/* end Berserker class */

}/* end Character_System namespace */
