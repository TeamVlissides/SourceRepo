using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Weapon : Item
    {/* start Weapon class */

        private String mName;
        private String mDescription;
        private int mBaseDamage;
        private int[] mStats;

        public Weapon(String name, String description, int damage, int[] stats, ItemType type ) : base( type )
        {/* start constructor */

            mName = name;
            mDescription = description;
            mBaseDamage = damage;
            mStats = stats;

        }/* end constructor */

        public String Name
        {/* start Name property */

            get
            {/* start accessor */

                return mName;

            }/* end accessor */

        }/* end Name property */

        public String Description
        {/* start Description property */

            get
            {/* start accessor */

                return mDescription;

            }/* end accessor */

        }/* end Description property */

        public int Damage
        {/* start Damage property */

            get
            {/* start accessor */

                return mBaseDamage;

            }/* end accessor */

        }/* end Damage property */

        public int getStat(StatEnum stat)
        {/* start getStat */

            if (stat == StatEnum.STRENGTH)
                return mStats[(int)StatEnum.STRENGTH];

            if (stat == StatEnum.MAGIC)
                return mStats[(int)StatEnum.MAGIC];

            if (stat == StatEnum.AGILITY)
                return mStats[(int)StatEnum.AGILITY];

            if (stat == StatEnum.STAMINA)
                return mStats[(int)StatEnum.STAMINA];

            return 0;

        }/* end getStat */

    }/* end Weapon class */

}/* end Character_System namespace */
