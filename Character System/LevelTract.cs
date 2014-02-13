using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System */

    public abstract class LevelTract
    {/* start LevelTract */

        private ArrayList mAbilities;

        protected LevelTract(ArrayList abilities)
        {/* start constructor */

            mAbilities = abilities;

        }/* end constructor */

        public abstract void LevelUp( int level )
        {/* start LevelUp */



        }/* end LevelUp */

        public IEnumerator getAbilities()
        {/* start getAbilities */

            return mAbilities.GetEnumerator();

        }/* end getAbilities */

    }/* end LevelTract */

}/* end Character_System */
