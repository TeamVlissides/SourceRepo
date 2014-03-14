using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System */

    public class CharacterFactory
    {/* start CharacterFactory */

        private static CharacterFactory mFactory;

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
                setMonk();

            return new PlayerCharacter(mArmor, name, mStats, mWeapon, mClass, classes);
            
        }/* end getCharacter */

        private void setMonk()
        {/* start setMonk */

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 20;
            mStats[(int)StatEnum.MAGIC] = 1;
            mStats[(int)StatEnum.STAMINA] = 3;
            mStats[(int)StatEnum.STRENGTH] = 20;

            mArmor = ArmorFactory.getInstance().getBasicArmorSet(ClassEnum.MONK);
            mWeapon = WeaponFactory.getWeapon(WeaponEnum.WETRIEDSTAFF);
            mClass = new Monk(mStats);

        }/* end setMonk */

        private void setTheif()
        {/* start setTheif */

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 30;
            mStats[(int)StatEnum.MAGIC] = 1;
            mStats[(int)StatEnum.STAMINA] = 3;
            mStats[(int)StatEnum.STRENGTH] = 15;

            mArmor = ArmorFactory.getInstance().getBasicArmorSet(ClassEnum.THEIF); ;
            mWeapon = WeaponFactory.getWeapon( WeaponEnum.WETRIEDKNIFE );
            mClass = new Thief( mStats );

        }/* end setTheif */

        private void setRedMage()
        {/* start setRedMage */

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 15;
            mStats[(int)StatEnum.MAGIC] = 10;
            mStats[(int)StatEnum.STAMINA] = 2;
            mStats[(int)StatEnum.STRENGTH] = 10;

            mArmor = ArmorFactory.getInstance().getBasicArmorSet(ClassEnum.REDMAGE);
            mWeapon = WeaponFactory.getWeapon(WeaponEnum.WETIREDSWORD);
            mClass = new RedMage(mStats);

        }/* end setRedMage */

        private void setWhiteMage()
        {/* start setWhiteMage */

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 1;
            mStats[(int)StatEnum.MAGIC] = 20;
            mStats[(int)StatEnum.STAMINA] = 2;
            mStats[(int)StatEnum.STRENGTH] = 1;

            mArmor = ArmorFactory.getInstance().getBasicArmorSet(ClassEnum.WHITEMAGE);
            mWeapon = WeaponFactory.getWeapon(WeaponEnum.WETRIEDSTAFF);
            mClass = new WhiteMage(mStats);

        }/* end setWhiteMage */

        private void setBlackMage()
        {/* start setBlackMage */

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 1;
            mStats[(int)StatEnum.MAGIC] = 30;
            mStats[(int)StatEnum.STAMINA] = 1;
            mStats[(int)StatEnum.STRENGTH] = 1;

            mArmor = ArmorFactory.getInstance().getBasicArmorSet(ClassEnum.BLACKMAGE);
            mWeapon = WeaponFactory.getWeapon(WeaponEnum.WETRIEDSTAFF);
            mClass = new BlackMage(mStats);

        }/* end setBlackMage */

        private void setWarrior()
        {/* start setWarrior */

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 15;
            mStats[(int)StatEnum.MAGIC] = 1;
            mStats[(int)StatEnum.STAMINA] = 5;
            mStats[(int)StatEnum.STRENGTH] = 30;

            mArmor = ArmorFactory.getInstance().getBasicArmorSet(ClassEnum.WARRIOR);
            mWeapon = WeaponFactory.getWeapon(WeaponEnum.WETIREDSWORD);
            mClass = new Warrior(mStats);

        }/* end setWarrior */

    }/* end CharacterFactory */

}/* end Character_System */
