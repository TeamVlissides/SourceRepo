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

        public override BattleEvent ai(Party goodGuys)
        {/* start ai */

            Random random = new Random();
            int target = random.Next( Party.MAXPARTY );
            BattleAction action = new BattleAction(ActionEnum.ATTACK, null);

            return new BattleEvent(mEnemy, action, goodGuys.getCharacter(target), 0);

        }/* end ai */

    }/* end Berserker class */

}/* end Character_System namespace */
