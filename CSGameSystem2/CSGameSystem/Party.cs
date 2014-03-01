using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{/* start Character_System namespace */

    public class Party
    {/* start Party class */

        public const int MAXPARTY = 3;

        private Character[] mParty;

        public Party( Character[] party )
        {/* start constructor */

            mParty = party;

        }/* end constructor */

        public Character getCharacter( int index )
        {/* start getCharacter */

            if (index <= 0)
                throw new IndexOutOfRangeException( "Tried to get a character in getCharacter method outside of the array." );

            return mParty[index];

        }/* end getCharacter */

    }/* end Party class */

}/* end Character_System namespace */
