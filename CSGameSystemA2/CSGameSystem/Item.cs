using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{/* start Character_System */

    public abstract class Item
    {/* start Item interface */

        private ItemType mType;
        private bool mIsManaPotion = false;

        public Item(ItemType type)
        {/* start constructor */

            mType = type;

        }/* end constructor */

        public bool IsMana
        {/* start IsMana property */

            get
            {/* start accessor */

                return mIsManaPotion;

            }/* end accessor */

            set
            {/* start mutator */

                mIsManaPotion = value;

            }/* end mutator */

        }/* end IsMana property */

        public ItemType Type
        {/* start Type property */

            get
            {/* start accessor */

                return mType;

            }/* end accessor */

        }/* end Type property */

    }/* end Item interface */

}/* end Character_System */
