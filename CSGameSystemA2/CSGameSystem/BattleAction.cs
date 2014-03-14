using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    public interface BattleAction
    {
        void specificAction(Character actingCharacter, Character[] combatants);
        String toString();
        ArrayList getBattleEvents();
    }
}
