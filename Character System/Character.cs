using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Character_System
{/* start Character_System namespace */

    public abstract class Character
    {/* start Character class */

        /* Constants */
        public const int MAXSTATS = 4;

        /* Attributes */
        protected int mHealth;
        protected int mMana;
        protected Armor[] mArmor;
        protected string mName;
        protected int[] mStats;
        protected Weapon mWeapon;
        protected AbilitiesHolder mAbilities;

        protected Character( Armor[] armor, string name, int[] stats, Weapon weapon, AbilitiesHolder abilities)
        {/* start constructor */
         
            mArmor = armor;
            mName = name;
            mStats = stats;
            mWeapon = weapon;
            mAbilities = abilities;

            mHealth = this.MaximumHealth;
            mMana = this.MaximumMana;

        }/* end constructor */

        public int CurrentHealth
        {/* start Health property */

            get
            {/* start accessor */

                return mHealth;

            }/* end accessor */

        }/* end Health property */

        public int CurrentMana
        {/* start Health property */

            get
            {/* start accessor */

                return mMana;

            }/* end accessor */

        }/* end Health property */

        public int MaximumMana
        {/* start MaximumMana property */

            get
            {/* start accessor */

                return mStats[(int)StatEnum.MAGIC] * 100;
            
            }/* end accessor */

        }/* end MaximumMana property */

        public int MaximumHealth
        {/* start MaximumHealth property */

            get
            {/* start accessor */

                return mStats[(int)StatEnum.STAMINA] * 100;

            }/* end accessor */

        }/* end MaximumHealth property */

        public String Name
        {/* start Name property */

            get
            {/* start accessor */

                return mName;

            }/* end accessor */

        }/* end Name property */

        public int getStat(StatEnum stat)
        {/* start getStat */

            if (stat != StatEnum.NULL)
            {/* start if */

                if (stat == StatEnum.STRENGTH)
                    return mStats[(int)StatEnum.STRENGTH] + mWeapon.getStat(StatEnum.STRENGTH );

                if (stat == StatEnum.MAGIC)
                    return mStats[(int)StatEnum.STRENGTH] + mWeapon.getStat(StatEnum.MAGIC);

                if (stat == StatEnum.AGILITY)
                    return mStats[(int)StatEnum.STRENGTH] + mWeapon.getStat(StatEnum.AGILITY);

                if (stat == StatEnum.STAMINA)
                    return mStats[(int)StatEnum.STRENGTH] + mWeapon.getStat(StatEnum.STAMINA);

                if (stat == StatEnum.ARMOR)
                    return getTotalArmor();

            }/* end if */

            return (int)StatEnum.NULL;

        }/* end getStat */

        private int getTotalArmor()
        {/* start getTotalArmor */

            int i;
            int totalArmor = 0;

            for (i = 0; i < Armor.MAXARMOR; i++)
                totalArmor += mArmor[i].ArmorStat;

            return totalArmor;

        }/* end getTotalArmor */

        public bool isDead()
        {/* start isDead */

            return mHealth <= 0;

        }/* end isDead */

        public void getAbilities()
        {/* start getAbilities */

            mAbilities.getAbilities();

        }/* end getAbilities */

    }/* end Character class */

}/* end Character_System namespace */
