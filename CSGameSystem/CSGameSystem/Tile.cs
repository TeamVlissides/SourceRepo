using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSGameSystem
{
    public class Tile
    {
        // Attributes
        private Brush backgroundColor;
        private Brush borderColor;
        private Boolean hasAnItem;
        private int itemType;
        private int size;
       // private Item[] items;

        // The tile needs to keep track of what kind of tile it is
        // is it a null tile, a freespace, a item, a wall, a dragon tile?

        // Default Constructor
        public Tile(Random rand)
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

            // Deterime if tile has treasure/ a item or not.
            // This is not creating random numbers for each tile???
            // it creates the same numbers for all of them.
            //Random r = new Random();
            // Dont know but passing in the reference works.
            // But does not seem like a good thing to do.
            int r = rand.Next() % 100;

            // Put an item here.
            if (r % 2 != 0)
            {
                // decide what type of item to put here.
                // generate random itemtype number here and set the itemType to it.
                itemType = rand.Next(-1, 3);

                hasAnItem = true;
               // Console.WriteLine("True." + r);
            }

            
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
