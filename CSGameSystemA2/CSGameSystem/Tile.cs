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

        #region GUI Attributes
        protected Brush backgroundColor;
        protected Brush borderColor;
        #endregion

        protected Boolean hasAnItem;
        protected DungeonEnum itemType;
        protected int size;
       // private Item[] items;

        // The tile needs to keep track of what kind of tile it is
        // is it a null tile, a freespace, a item, a wall, a dragon tile?

        // Default Constructor
        public Tile( DungeonEnum type )
        {
            // Can have up to 3 items;
            //items = new Item[3];

            #region GUI Initializations
            backgroundColor = Brushes.Orange;
            borderColor = Brushes.Black;
            #endregion

            size = 5;
           // Item item1 = new Item("Treasure", Directory.GetCurrentDirectory() + @"\images\treasure00.png", 1);

            // This needs to goto the view; just put some string thing here saying
            // that there is a item and check for that and display that in the view.

            //ResourceItem item1 = new ResourceItem("Treasure", Properties.Resources, 1);
            //items[0] = item1;
            hasAnItem = false;
            itemType = type;

            
        }

        #region GUI Implelmentation

        public Tile(Brush bgcolor, Brush bColor, int size, DungeonEnum type)
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

        public Brush getBackgroundColor()
        {
            return this.backgroundColor;
        }

        public Brush getBorderColor()
        {
            return this.borderColor;
        }
        
        #endregion

        public void SetSize(int s)
        {
            this.size = s;
        }

        public DungeonEnum TileType
        {/* start TileType property */

            get
            {/* start accessor */

                return itemType;

            }/* end accessor */

            set
            {/* start mutator */

                itemType = value;

            }/* end mutator */

        }/* end TileType property */

        //public void SetItems(Item[] items)
        //{
        //    this.items = items;
        //}

        // getter methods


        public Boolean hasItem()
        {
            return this.hasAnItem;
        }

        public int getSize()
        {
            return this.size;
        }

        //public Item[] getItems()
        //{
        //    return this.items;
        //}

    }
}
