using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battle_System;

namespace Character_System
{/* start Character_System */

    public abstract class AI : AbilitiesHolder
    {/* start AI class */

        public const int AMOUNTOFAI = 3;

        protected Enemy mEnemy;

        public AI()
        {/* start constructor */
        }/* end constructor */

        public Enemy Enemy
        {/* start Enemy property */

            set
            {/* start mutator */

                mEnemy = value;

            }/* end mutator */

        }/* end Enemy property */

        public void addAbility(Ability ability)
        {/* start addAbility */

            mAbilities.Add(ability);

        }/* end addAbility */

        public abstract BattleEvent ai(Party goodGuys);

    }/* end AI class */

}/* end Character_System */
