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
        private ItemEnum mItem;
        private String mName;
        private String mDescription;
        private bool mIsManaPotion = false;

        public Item(ItemType type, ItemEnum item, String name, String description)
        {/* start constructor */

            mType = type;
            mItem = item;
            mName = name;
            mDescription = description;

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

        public ItemEnum WhichItem
        {/* start Item property */

            get
            {/* start accessor */

                return mItem;

            }/* end accessor */

        }/* end Item property */

    }/* end Item interface */

}/* end Character_System */
