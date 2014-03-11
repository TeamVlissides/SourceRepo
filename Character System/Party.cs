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
        private List<Item> mInventory;

        public Party( Character[] party )
        {/* start constructor */

            mParty = party;
            mPartySize = party.Length;
            mInventory = new List<Item>();

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

        public int Size
        {/* start Size property */

            get
            {/* start accessor */

                return mPartySize;

            }/* end accessor */

        }/* end Size property */

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

        public int Level
        {/* start Level property */

            get
            {/* start accessor */

                int i, level;

                /* Check if the array is null */
                if (mParty == null)
                    return 0;

                /* Check if the first character is null */
                if (mParty[0] == null)
                    return 0;

                /* Check if the first character is a player character */
                if (!(mParty[0] is PlayerCharacter))
                    return 0;

                /* Initialize Level */
                level = ((PlayerCharacter)mParty[0]).Level;

                /* Check if any other character has a higher level */
                for (i = 1; i < mParty.Length; i++)
                    if (mParty[i] != null)
                        if (((PlayerCharacter)mParty[i]).Level > level)
                            level = ((PlayerCharacter)mParty[i]).Level;

                return level;

            }/* end accessor */

        }/* end Level property */

        public void giveItem( Item item )
        {/* start giveItem */

            mInventory.Add( item );

        }/* end giveItem */

    }/* end Party class */

}/* end Character_System namespace */
