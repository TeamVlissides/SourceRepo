using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System */

    public abstract class Item
    {/* start Item interface */

        private ItemType mType;

        public Item(ItemType type)
        {/* start constructor */

            mType = type;

        }/* end constructor */

        public ItemType Type
        {/* start Type property */

            get
            {/* start accessor */

                return mType;

            }/* end accessor */

        }/* end Type property */

    }/* end Item interface */

}/* end Character_System */
