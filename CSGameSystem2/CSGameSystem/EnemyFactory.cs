using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    class EnemyFactory
    {
        
        // Attributes
        Party party = null;

        // Constructor

        // Methods
        public Party getEnemyParty(int level)
        {
            return party;
        }

        public Party getSpecificParty(EnemyType type)
        {
            return party;
        }
    }
}
