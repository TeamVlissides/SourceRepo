using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Armor
    {/* start Armor class */

        private int mArmorValue;
        private String mName;

        public Armor(int armorValue, String name)
        {/* start constructor */

            mArmorValue = armorValue;
            mName = name;

        }/* end constructor */

        public int Armor
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

    }/* end Armor class */

}/* end Character_System namespace */
