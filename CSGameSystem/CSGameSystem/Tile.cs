using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSGameSystem
{
    class Tile
    {
        // Attributes
        private Brush backgroundColor;
        private Brush borderColor;
        private int size;
        private Gem[] gems;

        // Default Constructor
        public Tile()
        {
            // Can have up to 3 gems;
            gems = new Gem[3];
            backgroundColor = Brushes.Orange;
            borderColor = Brushes.Black;
            size = 5;
            Gem gem1 = new Gem("Ruby", Directory.GetCurrentDirectory() + @"\images\gem00.png", 1);
            gems[0] = gem1;
        }

        // 
        public Tile(Brush bgcolor, Brush bColor, int size, Gem [] gems)
        {
            backgroundColor = bgcolor;
            borderColor = bColor;
            this.size = size;
            this.gems = gems;
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

        public void SetGems(Gem[] gems)
        {
            this.gems = gems;
        }

        // getter methods

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

        public Gem[] getGems()
        {
            return this.gems;
        }

    }
}
