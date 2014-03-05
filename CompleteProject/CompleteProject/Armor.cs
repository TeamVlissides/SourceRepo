using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Armor
    {/* start Armor class */

        /* Constants */
        public const int MAXARMOR = 4;

        /* Attributes */
        private int mArmorValue;
        private String mName;
        private String mDescription;

        public Armor( int armorValue, String name, String description )
        {/* start constructor */

            mArmorValue = armorValue;
            mName = name;
            mDescription = description;

        }/* end constructor */

        public int ArmorStat
        {/* start Armor property */

            get
            {/* start accessor */

                return mArmorValue;

            }/* end accessor */
            
        }/* end Armor property */

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

    }/* end Armor class */

}/* end Character_System namespace */
