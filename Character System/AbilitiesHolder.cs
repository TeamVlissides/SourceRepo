using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public abstract class AbilitiesHolder
    {/* start AbilitiesHolder */

        protected List<Ability> mAbilities = new List<Ability>();

        public AbilitiesIterator getAbilities()
        {/* start getAbilities */

            return new AbilitiesIterator(mAbilities);

        }/* end getAbilities */

    }/* end AbilitiesHolder */

}/* end Character_System namespace */