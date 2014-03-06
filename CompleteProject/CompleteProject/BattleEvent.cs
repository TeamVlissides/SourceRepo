using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character_System;

namespace Battle_System
{/* start Battle_System namespace */

    public class BattleEvent
    {/* start BattleEvent class */

        private Character mUser;
        private BattleAction mAction;
        private Character mTarget;
        private int mDamage;

        public BattleEvent(Character user, BattleAction action, Character target, int damage)
        {/* start constructor */

            mUser = user;
            mAction = action;
            mTarget = target;
            mDamage = damage;

        }/* end constructor */

        public Character User
        {/* start User property */

            get
            {/* start accessor */

                return mUser;

            }/* end accessor */

        }/* end User property */

        public Character Target
        {/* start Target property */

            get
            {/* start accessor */

                return mTarget;

            }/* end accessor */

        }/* end Target property */

        public int Damage
        {/* start Damage property */

            get
            {/* start accessor */

                return mDamage;

            }/* end accessor */

            set
            {/* start mutator */

                mDamage = value;

            }/* end mutator */

        }/* end Damage property */

    }/* end BattleEvent class */

}/* end Battle_System namespace */
