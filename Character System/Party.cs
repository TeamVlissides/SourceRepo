using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Party
    {/* start Party class */

        public static const int MAXPARTY = 3;

        private Character[] mParty;

        public Character getCharacter( int index )
        {/* start getCharacter */

            if (index <= 0)
                throw new IndexOutOfRangeException();

            return mParty[index];

        }/* end getCharacter */

    }/* end Party class */

}/* end Character_System namespace */
