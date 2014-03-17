using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Armor : Item
    {/* start Armor class */

        /* Constants */
        public const int MAXARMOR = 4;

        /* Attributes */
        private int mArmorValue;

        public Armor( int armorValue, String name, String description, ItemType type ) : base( type, ItemEnum.NONITEM, name, description )
        {/* start constructor */

            mArmorValue = armorValue;

        }/* end constructor */

        public int ArmorStat
        {/* start Armor property */

            get
            {/* start accessor */

                return mArmorValue;

            }/* end accessor */
            
        }/* end Armor property */

    }/* end Armor class */

}/* end Character_System namespace */
