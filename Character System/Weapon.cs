using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Weapon
    {/* start Weapon class */

        private int mBaseDamage;
        protected int[] mStats;

        public int Damage
        {/* start Damage property */

            get
            {/* start accessor */

                return mBaseDamage;

            }/* end accessor */

        }/* end Damage property */

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

            }/* end if */

            return (int)StatEnum.NULL;

        }/* end getStat */

    }/* end Weapon class */

}/* end Character_System namespace */
