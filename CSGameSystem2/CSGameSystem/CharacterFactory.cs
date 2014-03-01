using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{/* start Character_System */

    public class CharacterFactory
    {/* start CharacterFactory */

        private CharacterFactory()
        {/* start constructor */
        }/* end constructor */

        public static Character getCharacter( ClassEnum classes, String name )
        {/* start getCharacter */

            if( classes == ClassEnum.REDMAGE )
                return getRedMage( name );

            if (classes == ClassEnum.WHITEMAGE)
               return getRedMage( name );// return getWhiteMage( name );

            if (classes == ClassEnum.BLACKMAGE)
              return getRedMage( name );//  return getBlackMage( name );

            if (classes == ClassEnum.WARRIOR)
               return getRedMage( name );// return getWarrior( name );//

            if (classes == ClassEnum.THEIF)
               return getRedMage( name );// return getTheif( name );

            if (classes == ClassEnum.MONK)
                return getRedMage(name);// return getBlackMage( name );

            return null;
            
        }/* end getCharacter */

        /* Feel like Template should be applied here */
        private static Character getRedMage( String name )
        {/* start getRedMage */

            int[] stats = new int[Character.MAXSTATS];

            stats[(int)StatEnum.AGILITY] = 5;
            stats[(int)StatEnum.MAGIC] = 10;
            stats[(int)StatEnum.STAMINA] = 12;
            stats[(int)StatEnum.STRENGTH] = 10;

            return new PlayerCharacter( ArmorFactory.getBasicRedMageArmor(), name, stats, WeaponFactory.getWeapon( WeaponEnum.WETIREDSWORD ), new RedMage( stats ) );

        }/* end getRedMage */

    }/* end CharacterFactory */

}/* end Character_System */
