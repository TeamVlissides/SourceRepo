using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Weapon : Item
    {/* start Weapon class */

        private int mBaseDamage;
        private int[] mStats;

        public Weapon(String name, String description, int damage, int[] stats, ItemType type ) : base( type, ItemEnum.NONITEM, name, description )
        {/* start constructor */

            mBaseDamage = damage;
            mStats = stats;

        }/* end constructor */

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
