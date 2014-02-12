using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System */

    public abstract class AI
    {/* start AI class */

        private ArrayList mAbilities;

        protected abstract AI(ArrayList abilities)
        {/* start constructor */

            mAbilities = abilities;

        }/* end constructor */

    }/* end AI class */

}/* end Character_System */
