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
        public const int HEALTHMANAMULTIPLICITY = 100;

        /* Attributes */
        protected int mHealth;
        protected int mMana;
        protected Armor[] mArmor;
        protected String mName;
        protected int[] mStats;
        protected Weapon mWeapon = WeaponFactory.NullWeapon();
        protected AbilitiesHolder mAbilities;
        public bool mIsPlayer;

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

        public bool isPlayer
        {/* start isPlayer */

            get
            {/* start accessor */

                return mIsPlayer;

            }/* end accessor */

        }/* end isPlayer */

        public bool isDead
        {/* start isDead */

            get
            {/* start accessor */

                return mHealth <= 0;

            }/* end accessor */

        }/* end isDead */

        public AbilitiesIterator Abilities
        {/* start Abilities property */

            get
            {/* start accessor */

                return mAbilities.getAbilities();

            }/* end accessor */

        }/* end Abilities property */

        public int CurrentMana
        {/* start CurrentMana property */

            get
            {/* start accessor */

                return mMana;

            }/* end accessor */

        }/* end CurrentMana property */

        public int CurrentHealth
        {/* start CurrentHealth property */

            get
            {/* start accessor */

                return mHealth;

            }/* end accessor */

        }/* end CurrentHealth property */

        public int MaximumMana
        {/* start MaximumMana property */

            get
            {/* start accessor */

                return mStats[(int)StatEnum.MAGIC] * HEALTHMANAMULTIPLICITY;
            
            }/* end accessor */

        }/* end MaximumMana property */

        public int MaximumHealth
        {/* start MaximumHealth property */

            get
            {/* start accessor */

                return mStats[(int)StatEnum.STAMINA] * HEALTHMANAMULTIPLICITY;

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

                if (stat == StatEnum.STRENGTH)
                    return mStats[(int)StatEnum.STRENGTH] + mWeapon.getStat(StatEnum.STRENGTH);

                if (stat == StatEnum.MAGIC)
                    return mStats[(int)StatEnum.STRENGTH] + mWeapon.getStat(StatEnum.MAGIC);

                if (stat == StatEnum.AGILITY)
                    return mStats[(int)StatEnum.STRENGTH] + mWeapon.getStat(StatEnum.AGILITY);

                if (stat == StatEnum.STAMINA)
                    return mStats[(int)StatEnum.STRENGTH] + mWeapon.getStat(StatEnum.STAMINA);

                if (stat == StatEnum.ARMOR)
                    return getTotalArmor();

            return int.MinValue;

        }/* end getStat */

        private int getTotalArmor()
        {/* start getTotalArmor */

            int i;
            int totalArmor = 0;

            for (i = 0; i < Armor.MAXARMOR; i++)
                totalArmor += mArmor[i].ArmorStat;

            return totalArmor;

        }/* end getTotalArmor */

        public void takeDamage(int damage)
        {/* start takeDamage */

            mHealth -= damage;

        }/* end takeDamage */

        public void useMana(int mana)
        {/* start useMana */

            mMana -= mana;

        }/* end useMana */

        public Armor getArmor(ArmorEnum armor)
        {/* start getArmor */

            return mArmor[(int)armor];

        }/* end getArmor */

        public bool CompareTo(Character character)
        {/* start CompareTo */

            return this.getStat(StatEnum.AGILITY) < character.getStat(StatEnum.AGILITY);

        }/* end CompareTo */

        public String toString()
        {/*Begin toString*/
            return mName;
        }/*end toString*/

    }/* end Character class */

}/* end Character_System namespace */
