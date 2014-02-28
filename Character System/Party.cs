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
        private int mPartySize;

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

        public int GetSize
        {/* start GetSize property */

            get
            {/* start accessor */

                return mPartySize;

            }/* end accessor */

        }/* end GetSize property */

        public Character getCharacter( int index )
        {/* start getCharacter */

            if (index <= 0)
                throw new IndexOutOfRangeException( "Tried to get a character in getCharacter method outside of the array." );

            return mParty[index];

        }/* end getCharacter */

        public Character[] getTurnOrder(Party otherParty)
        {/* start getTurnOrder */

            int size = this.mPartySize + otherParty.mPartySize;
            int i, j;
            Character[] turnOrder = new Character[size];
            Character temp;

            for (i = 0; i < mParty.Length; i++)
                turnOrder[ i ] = mParty[ i ];
            
            for( j = 0; j < otherParty.mPartySize; j++, i++ )
                turnOrder[ i ] = otherParty.mParty[ j ];

            for (i = 0; i < size; i++)
                for (j = 0; j < size; j++)
                    if ( turnOrder[ i ].CompareTo( turnOrder[ j ] ) )
                    {/* start if */

                        temp = turnOrder[i];
                        turnOrder[i] = turnOrder[j];
                        turnOrder[j] = temp;

                    }/* end if */

            return turnOrder;

        }/* end getTurnOrder */

    }/* end Party class */

}/* end Character_System namespace */
