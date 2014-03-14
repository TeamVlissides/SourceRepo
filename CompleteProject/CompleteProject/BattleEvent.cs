﻿using Character_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    public class BattleEvent
    {

        private Character mActor;
        private BattleAction mAction;
        private String actionOutcome;
        private Character mActee;

        public BattleEvent(Character currentActor, BattleAction actorAction, Character actorTarget)
        {
            mActor = currentActor;
            mAction = actorAction;
            actionOutcome = mAction.toString();
            mActee = actorTarget;
        }

        public String toString()
        {
            return mActor.Name + actionOutcome + mActee.Name;
        }

        public Character User
        {/* start User property */

            get
            {/* start accessor */

                return mActor;

            }/* end accessor */

        }/* end User property */

        public Character Target
        {/* start Target property */

            get
            {/* start accessor */

                return mActee;

            }/* end accessor */

        }/* end Target property */

    }
}
