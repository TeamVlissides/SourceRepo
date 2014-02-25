using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System */

    public class CharacterFactory
    {/* start CharacterFactory */

        public static CharacterFactory mFactory;

        private int[] mStats;
        private Armor[] mArmor;
        private Weapon mWeapon;
        private LevelTract mClass;

        private CharacterFactory()
        {/* start constructor */
        }/* end constructor */

        public static CharacterFactory getInstance()
        {/* start getInstance */

            if (mFactory == null)
                mFactory = new CharacterFactory();

            return mFactory;

        }/* end getInstance */

        public Character getCharacter( ClassEnum classes, String name )
        {/* start getCharacter */

            /*Set all attributes to null, so if we don't call a set method, we don't pass references that are linked to other character's attributes. */
            mStats = null;
            mArmor = null;
            mWeapon = null;
            mClass = null;

            if( classes == ClassEnum.REDMAGE )
                setRedMage();

            if (classes == ClassEnum.WHITEMAGE)
                setWhiteMage();

            if (classes == ClassEnum.BLACKMAGE)
                setBlackMage( );

            if (classes == ClassEnum.WARRIOR)
                setWarrior();

            if (classes == ClassEnum.THEIF)
                setTheif();

            if (classes == ClassEnum.MONK)
                setBlackMage();

            return new PlayerCharacter(mArmor, name, mStats, mWeapon, mClass);
            
        }/* end getCharacter */

        private void setRedMage()
        {/* start setRedMage */

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 5;
            mStats[(int)StatEnum.MAGIC] = 10;
            mStats[(int)StatEnum.STAMINA] = 12;
            mStats[(int)StatEnum.STRENGTH] = 10;

            mArmor = ArmorFactory.getBasicRedMageArmor();
            mWeapon = WeaponFactory.getWeapon( WeaponEnum.WETIREDSWORD );
            mClass = new RedMage( mStats );

        }/* end setRedMage */

    }/* end CharacterFactory */

}/* end Character_System */
