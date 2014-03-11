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

    }/* end Item interface */

}/* end Character_System */
