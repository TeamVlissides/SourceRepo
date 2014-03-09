using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_System
{
    public class Item
    {

        // Attributes
        private String itemName;
        private String itemImagePath;
        private int itemType;

        // Constructors
        public Item()
        {
            this.itemName = "Generic Item";
            this.itemImagePath = "";
            this.itemType = 0;
        }

        public Item(String name, String path, int type)
        {
            this.itemName = name;
            this.itemImagePath = path;
            this.itemType = type;
        }

        // getters Methods
        public String getItemName()
        {
            return this.itemName;
        }

        public String getItemImagePath()
        {
            return this.itemImagePath;
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

        public void setItemImagePath(String path)
        {
            this.itemImagePath = path;
        }

        public void setItemType(int type)
        {
            this.itemType = type;
        }
    }
}
