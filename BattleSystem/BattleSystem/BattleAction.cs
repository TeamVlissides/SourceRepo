using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    interface BattleAction
    {
        private void specificAction(Character actingCharacter, ref Character target);
        public String toString();
    }
}
