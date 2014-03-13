using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSGameSystem
{
    public abstract class Tile
    {
        // Attributes
        protected Brush backgroundColor;
        protected Brush borderColor;
        protected Boolean hasAnItem;
        protected int itemType;
        protected int size;
       // private Item[] items;

        // The tile needs to keep track of what kind of tile it is
        // is it a null tile, a freespace, a item, a wall, a dragon tile?

        // Default Constructor
        public Tile()
        {
            // Can have up to 3 items;
            //items = new Item[3];
            backgroundColor = Brushes.Orange;
            borderColor = Brushes.Black;
            size = 5;
           // Item item1 = new Item("Treasure", Directory.GetCurrentDirectory() + @"\images\treasure00.png", 1);

            // This needs to goto the view; just put some string thing here saying
            // that there is a item and check for that and display that in the view.

            //ResourceItem item1 = new ResourceItem("Treasure", Properties.Resources, 1);
            //items[0] = item1;
            hasAnItem = false;
            itemType = 0;

            
        }

        // 
        public Tile(Brush bgcolor, Brush bColor, int size, int type)
        {
            backgroundColor = bgcolor;
            borderColor = bColor;
            this.size = size;
            this.itemType = type;
           // this.items = items;
        }

        // setter Methods
        public void SetBackgroundColor(Brush color)
        {
            backgroundColor = color;
        }

        public void SetBorderColor(Brush color)
        {
            borderColor = color;
        }

        public void SetSize(int s)
        {
            this.size = s;
        }

        public void SetItemType(int type)
        {
            this.itemType = type;
        }

        //public void SetItems(Item[] items)
        //{
        //    this.items = items;
        //}

        // getter methods

        public int getItemType()
        {
            return this.itemType;
        }

        public Boolean hasItem()
        {
            return this.hasAnItem;
        }

        public int getSize()
        {
            return this.size;
        }

        public Brush getBackgroundColor()
        {
            return this.backgroundColor;
        }

        public Brush getBorderColor()
        {
            return this.borderColor;
        }

        //public Item[] getItems()
        //{
        //    return this.items;
        //}

    }
}
