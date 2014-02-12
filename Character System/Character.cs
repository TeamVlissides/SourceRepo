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
        public static const int MAXARMOR = 5;
        public static const int MAXSTATS = 4;

        /* Attributes */
        protected int mHealth;
        protected int mMana;
        protected Armor[] mArmor;
        protected string mName;
        protected int[] mStats;
        protected ArrayList mAbilities; 

        public int Health
        {/* start Health property */

            get
            {/* start accessor */

                return mHealth;

            }/* end accessor */

        }/* end Health property */

        public int Mana
        {/* start Health property */

            get
            {/* start accessor */

                return mMana;

            }/* end accessor */

        }/* end Health property */

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
                    return mStats[(int)StatEnum.STRENGTH];

                if (stat == StatEnum.MAGIC)
                    return mStats[(int)StatEnum.MAGIC];

                if (stat == StatEnum.AGILITY)
                    return mStats[(int)StatEnum.AGILITY];

                if (stat == StatEnum.STAMINA)
                    return mStats[(int)StatEnum.STAMINA];

                if (stat == StatEnum.ARMOR)
                    return getTotalArmor();

            }/* end if */

            return (int)StatEnum.NULL;

        }/* end getStat */

        private int getTotalArmor()
        {/* start getTotalArmor */

            int i;
            int totalArmor = 0;

            for (i = 0; i < MAXARMOR; i++)
                totalArmor += mArmor[i].Armor;

            return totalArmor;

        }/* end getTotalArmor */

    }/* end Character class */

}/* end Character_System namespace */
