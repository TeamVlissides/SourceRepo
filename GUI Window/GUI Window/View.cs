using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GUI_Window
{
    class View
    {
        // Attributes
        // Input input;
        // Output output;
        // GUISystem guiSystem;
        Grid grid;
        Graphics graphics;
        Form viewWindow;

        public int imageX;
        int imageY;

        Image party;

        public int count1;

        // Constructors
       // public View()
       // {

       // }

        //public View(Graphics g, GUIWindow form)
        public View(GUIWindow form)
       // public View()
        {
            //g.DrawLine(new Pen(Brushes.Black, 5), 0, 0, 200, 200);
           // graphics = g;
            party = Image.FromFile(@"C:\Users\Regan Fencl\Documents\GitHub\SourceRepo\GUI Window\GUI Window\images\party2.png");

    

           // SetupView(d);

            imageX = 30;
            imageY = 30;
            viewWindow = form;


        }

        // Methods

        public void increment()
        {
            count1 += 1;
        }

       // public void SetupView(Dungeon dungeon)
        public void View_Paint(Graphics g)
        {
            Dungeon d = new Dungeon();
            drawTiles(d.GetGrid().GetTiles(), g);
            DrawPartyCharacter();
        }

        public void setGraphicsObject(Graphics g)
        {
            graphics = g;
        }

        public void DrawPartyCharacter()
        {
          //  Image party = Image.FromFile(@"C:\Users\Anonymous\Documents\Visual Studio 2013\Projects\GUI Window\GUI Window\images\party2.png");

            graphics.DrawImage(party, imageX, imageY, 50, 50);
        }

        public void MovePartyRight()
        {
            if (imageX <= 300)
            {
                // Right
                imageX += 85;
                viewWindow.Invalidate();
            }
        }

        public void MovePartyLeft()
        {
            if (imageX > 30)
            {
                imageX -= 85;
                viewWindow.Invalidate();
            }
        }

        public void MovePartyUp()
        {
            // UP
            if (imageY > 30)
            {
                imageY -= 85;
                viewWindow.Invalidate();
            }
        }

        public void MovePartyDown()
        {
            if (imageY <= 300)
            {
                imageY += 85;
                viewWindow.Invalidate();
            }
        }

        // Screen Size;
        //
        //

        public void drawTiles(Tile[,] tiles, Graphics g)
        {
            graphics = g;
            int indexX = 0, indexY = 0; // indexes
            int height = 75;
            int width = 75;

            for (int x = 0; x < 5; x++)
            {
               
                for(int y = 0; y < 5; y++)
                {
                   
                    Brush borderColor = tiles[indexX, indexY].getBorderColor();
                    Brush bgcolor = tiles[indexX, indexY].getBackgroundColor();
                    Gem[] gems = tiles[indexX, indexY].getGems();

                    //Console.WriteLine("APPLES " + indexX + " " + indexY + " " + tiles[indexX, indexY].getBorderColor().ToString());

                    //Brush borderColor = Brushes.Black;
                    //Brush bgcolor = Brushes.Orange;
                    graphics.DrawRectangle(new Pen(borderColor, 5), ((height + 10) * x) + 20, ((width + 10) * y) + 20, width, height);
                    graphics.FillRectangle(bgcolor, ((height + 10) * x) + 20, ((width + 10) * y) + 20, width, height);

                    Random r = new Random();
                    int rand = r.Next() % 100;

                    if (rand % 2 != 0)
                    {
                        if (gems[0].getGemImagePath() != null)
                        {
                            Image image = Image.FromFile(gems[0].getGemImagePath());
                            graphics.DrawImage(image, ((height + 10) * x) + 20, ((width + 10) * y) + 20, 20, 20);
                        }
                    }
                    indexY++;
                }
                indexX++;
                indexY = 0;
            }

            graphics.DrawRectangle(new Pen(Brushes.Khaki, 5), 10, 10, ((height) * 5) + 60, ((width) * 5) + 60);
              
        }
    }
}
