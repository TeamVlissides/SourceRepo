using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */
    
    public class AbilitiesIterator : IEnumerator< Ability >
    {/* start AbilitiesIterator class */

        private List<Ability> mAbilities;
        private int mCurrent;

        public AbilitiesIterator(List<Ability> abilities)
        {/* start constructor */

            mAbilities = abilities;
            mCurrent = -1;

        }/* end constructor */

        public Ability Current
        {/* start Current property */

            get
            {/* start accessor */

                return mAbilities[mCurrent];

            }/* end accessor */

        }/* end Current property */

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        object IEnumerator.Current
        {/* start property */

            get
            {/* start accessor */
                
                return Current;
            
            }/* end accessor */

        }/* end property */

        public bool MoveNext()
        {/* start MoveNext */

            mCurrent++;
            return (mCurrent < mAbilities.Count);

        }/* end MoveNext */

        public void Reset()
        {/* end Reset */

            mCurrent = -1;

        }/* start Reset */

        public Ability getAbilityAtIndex(int index)
        {/* start getAbilityAtIndex */

            if (index < 0 || index > mAbilities.Count)
                throw new IndexOutOfRangeException( "Tried to access an ability in getAbilityAtIndex method outside of the list." );

            return mAbilities[index];

        }/* end getAbilityAtIndex */

    }/* end AbilitiesIterator class*/

}/* end Character_System namespace */
