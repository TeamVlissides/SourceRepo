using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
     class ResourceItem
    {
        // Attributes
        private String itemName;
        private Properties.Resources imageResource;
        private int itemType;

        // Constructors
        public ResourceItem()
        {
            this.itemName = "Generic Item";
            this.imageResource = null;
            this.itemType = 0;
        }

        public ResourceItem(String name, Properties.Resources resource, int type)
        {
            this.itemName = name;
            this.imageResource = resource;
            this.itemType = type;
        }

        // getters Methods
        public String getItemName()
        {
            return this.itemName;
        }

        public Properties.Resources getItemImageResource()
        {
            return this.imageResource;
        }

        public int getItemType()
        {

            return this.itemType;
        }

        // setter Methods
        public void setItemName(String name)
        {
            this.itemName = name;
        }

        public void setItemImageResouce(Properties.Resources res)
        {
            this.imageResource = res;
        }

        public void setItemType(int type)
        {
            this.itemType = type;
        }
    }
}
