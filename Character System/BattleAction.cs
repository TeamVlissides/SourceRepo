using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character_System;

namespace Battle_System
{/* start Battle_System namespace */

    public class BattleAction
    {/* start BattleAction */

        private ActionEnum mAction;
        private Ability mAbility;
        //private Item mItem;

        public BattleAction(ActionEnum action, Ability ability)
        {/* start BattleAction */

            mAction = action;
            mAbility = ability;

        }/* end BattleAction */

        public ActionEnum Action
        {/* start Action property */

            get
            {/* start accessor */

                return mAction;

            }/* end accessor */

        }/* end Action property */

        public Ability Ability
        {/* start Ability property */

            get
            {/* start accessor */

                return mAbility;

            }/* end accessor */

        }/* end Ability property */

    }/* end BattleAction */

}/* end Battle_System namespace */
