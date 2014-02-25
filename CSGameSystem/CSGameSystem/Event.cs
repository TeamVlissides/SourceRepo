using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    public class Event
    {

        private Character mActor;
        private BattleAction mAction;
        private Character mActee;

        public Event(Character currentActor, BattleAction actorAction, Character actorTarget)
        {
            mActor = currentActor;
            mAction = actorAction;
            mActee = actorTarget;
        }

        public String toString()
        {
            return ""; // currentActor.toString() + mAction.toString() + mActee.toString();
        }
        
    }
}
