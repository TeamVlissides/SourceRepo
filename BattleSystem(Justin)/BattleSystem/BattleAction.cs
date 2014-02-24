using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    interface BattleAction
    {
        private void specificAction(ref Character target);
        public String toString();
    }
}
