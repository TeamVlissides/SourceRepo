using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Party
    {/* start Party class */

        public const int MAXPARTY = 3;

        private Character[] mParty;

        public Party( Character[] party )
        {/* start constructor */

            mParty = party;

        }/* end constructor */

        public bool isDead
        {/* start isDead property */

            get
            {/* start accessor */

                bool isDead = true;

                for (int i = 0; i < MAXPARTY; i++)
                    if (mParty[i] != null)
                        isDead = isDead && mParty[i].isDead;

                return isDead;

            }/* end accessor */

        }/* end isDead property */

        public Character getCharacter( int index )
        {/* start getCharacter */

            if (index <= 0)
                throw new IndexOutOfRangeException( "Tried to get a character in getCharacter method outside of the array." );

            return mParty[index];

        }/* end getCharacter */

    }/* end Party class */

}/* end Character_System namespace */
