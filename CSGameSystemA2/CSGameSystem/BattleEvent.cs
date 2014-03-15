//using Character_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    public class BattleEvent
    {

        private Character mActor;
        private BattleAction mAction;
        private String actionOutcome;
        private Character mActee;
        private String kill_string = "";

        public BattleEvent(Character currentActor, BattleAction actorAction, Character actorTarget)
        {
            mActor = currentActor;
            mAction = actorAction;
            actionOutcome = mAction.ToString();
            mActee = actorTarget;

            if (mActee.isDead && !mActee.isPlayer)
            {
                ((PlayerCharacter)mActor).gainExperience(((Enemy)mActee).Worth);
                kill_string = ", " + mActee.Name + " was vanquished!";
            }

            if (mActee.isDead && mActee.isPlayer)
            {
                kill_string = ", " + mActee.Name + " has been slain!";
            }
        }

        public String toString()
        {
            return mActor.Name + actionOutcome + mActee.Name + kill_string;
        }
        
    }
}
