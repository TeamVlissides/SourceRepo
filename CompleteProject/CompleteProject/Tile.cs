using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dungeon_System
{
    public class Tile
    {
        // Attributes
        //private Brush backgroundColor;
        //private Brush borderColor;
        private int size;
        private Item[] items;

        // Default Constructor
        //public Tile()
        //{
        //    // Can have up to 3 items;
        //    items = new Item[3];
        //    backgroundColor = Brushes.Orange;
        //    borderColor = Brushes.Black;
        //    size = 5;
        //    Item item1 = new Item("Treasure", Directory.GetCurrentDirectory() + @"\images\treasure00.png", 1);
        //    items[0] = item1;
        //}

        //// 
        //public Tile(Brush bgcolor, Brush bColor, int size, Item [] items)
        //{
        //    backgroundColor = bgcolor;
        //    borderColor = bColor;
        //    this.size = size;
        //    this.items = items;
        //}

        //// setter Methods
        //public void SetBackgroundColor(Brush color)
        //{
        //    backgroundColor = color;
        //}

        //public void SetBorderColor(Brush color)
        //{
        //    borderColor = color;
        //}

        public void SetSize(int s)
        {
            this.size = s;
        }

        public void SetItems(Item[] items)
        {
            this.items = items;
        }

        // getter methods

        public int getSize()
        {
            return this.size;
        }

        //public Brush getBackgroundColor()
        //{
        //    return this.backgroundColor;
        //}

        //public Brush getBorderColor()
        //{
        //    return this.borderColor;
        //}

        public Item[] getItems()
        {
            return this.items;
        }

    }
}
