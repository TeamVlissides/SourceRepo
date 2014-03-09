using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CSGameSystem
{
    class DisplayView : View
    {
        // Attributes
        // Input input;
        // Output output;
        // GUISystem guiSystem;
        Grid grid;
        Graphics graphics;
        GUIWindow viewWindow;
        Dungeon d;


        public int imageX;
        int imageY;

        Image partyImage;
        Image treasureItemImage;
        Image dragonImage;
        Image wall, wall2;

        public int count1;

        // Load the images from the Resource here to put into the tiles.


        // Constructors
       // public View()
       // {

       // }

        //public View(Graphics g, GUIWindow form)
        public DisplayView(GUIWindow form, Dungeon dungeon)
       // public View()
        {
            //g.DrawLine(new Pen(Brushes.Black, 5), 0, 0, 200, 200);
           // graphics = g;
           // partyImage = Image.FromFile( Directory.GetCurrentDirectory() + @"\images\party2.png");
            partyImage = Properties.Resources.party2;

            // Load all images for the tiles here.
            // Directory.GetCurrentDirectory() + @"\images\treasure00.png"
            treasureItemImage = Properties.Resources.treasure00;
            dragonImage = Properties.Resources.dragon;
            wall = Properties.Resources.wall;
            wall2 = Properties.Resources.wall2;

           // SetupView(d);

            imageX = 30;
            imageY = 30;
            viewWindow = form;
            //d = new Dungeon();
            d = dungeon;

        }

        // Methods

        public void drawTiles(Tile[,] tiles, Graphics g)
        {
            graphics = g;
            int indexX = 0, indexY = 0; // indexes
            int height = 75;
            int width = 75;
            Image image;

            for (int x = 0; x < 5; x++)
            {

                for (int y = 0; y < 5; y++)
                {

                    Brush borderColor = tiles[indexX, indexY].getBorderColor();
                    Brush bgcolor = tiles[indexX, indexY].getBackgroundColor();

                    // Needs to get the itemType and based on that draw an item
                    //Item[] items = tiles[indexX, indexY].getItems();
                    int itemType = tiles[indexX, indexY].getItemType();
                    Boolean hasItem = tiles[indexX, indexY].hasItem();

                    //Console.WriteLine("APPLES " + indexX + " " + indexY + " " + tiles[indexX, indexY].getBorderColor().ToString());

                    //Brush borderColor = Brushes.Black;
                    //Brush bgcolor = Brushes.Orange;
                    graphics.DrawRectangle(new Pen(borderColor, 5), ((height + 10) * x) + 20, ((width + 10) * y) + 20, width, height);
                    graphics.FillRectangle(bgcolor, ((height + 10) * x) + 20, ((width + 10) * y) + 20, width, height);


                    // Random r = new Random();
                    //int rand = r.Next() % 100;

                    // if (rand % 2 != 0)
                    {
                      //  if (hasItem) //items[0].getItemImagePath() != null
                        {
                           // Image image = Image.FromFile(items[0].getItemImagePath());
                            //graphics.DrawImage(image, ((height + 10) * x) + 20, ((width + 10) * y) + 20, 20, 20); // Gem size

                            if (itemType == (int)DungeonEnum.WALL)
                            {
                                image = wall2;
                                graphics.DrawImage(image, ((height + 10) * x) + 20, ((width + 10) * y) + 20, 75, 75);
                            }

                            if (itemType == (int)DungeonEnum.ITEM)
                            {
                                image = treasureItemImage;
                                graphics.DrawImage(image, ((height + 10) * x) + 20, ((width + 10) * y) + 20, 30, 30);
                            }

                        }

                        if (itemType == (int)DungeonEnum.DRAGON)
                        {
                            image = dragonImage;
                            graphics.DrawImage(image, ((height + 10) * x) + 20, ((width + 10) * y) + 20, 75, 75);
                        }
                    }
                    indexY++;
                }
                indexX++;
                indexY = 0;
            }

            graphics.DrawRectangle(new Pen(Brushes.Khaki, 5), 10, 10, ((height) * 5) + 60, ((width) * 5) + 60);

        }

        // Methods

        public void increment()
        {
            count1 += 1;
        }

   

       // public void SetupView(Dungeon dungeon)
        public void View_Paint(Graphics g)
        {
            //Dungeon d = new Dungeon();
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

            graphics.DrawImage(partyImage, imageX, imageY, 50, 50);
        }

        public void PartyMoveUpdate()
        {
            // Moving right
            int row = d.PlayerLocationRow;
            int col = d.PlayerLocationColumn;
           // int maxPixelsWhenMovingRight = 300;
           // int minPixelsWhenMovingLeft = 30;

           // sendOutput("UPDATE RIGHT: " + "[" + row + "]");
          //  if (imageX <= maxPixelsWhenMovingRight)
           // {
                // Right
                //imageX += 85;

                // Move right
                imageX = (row * 85) + 30;

                //imageY += 85; 
                // Move down
                imageY = (col * 85) + 30;
               // imageY -= 85;


               // viewWindow.Invalidate();
              //  sendOutput("The player has moved down.");

                viewWindow.Invalidate();
               // sendOutput("The player has moved right.");
            //}

    

        }

        public void MovePartyRight()
        {
            if (imageX <= 300)
            {
                // Right
                imageX += 85;
                viewWindow.Invalidate();
                sendOutput("The player has moved right.");
            }

        }

        public void MovePartyLeft()
        {
            if (imageX > 30)
            {
                imageX -= 85;
                viewWindow.Invalidate();
                sendOutput("The player has moved left.");
            }

        }

        public void MovePartyUp()
        {
            // UP
            if (imageY > 30)
            {
                imageY -= 85;
                viewWindow.Invalidate();
                sendOutput("The player has moved up.");
            }

        }

        public void MovePartyDown()
        {
            if (imageY <= 300)
            {
                imageY += 85;
                viewWindow.Invalidate();
                sendOutput("The player has moved down.");
            }

        }

        // Screen Size;
        //
        //





        public DirectionEnum getDirection()
        {
            throw new NotImplementedException();
        }

        public object getInput(TypeEnum type)
        {
            throw new NotImplementedException();
        }

        public void sendOutput(System.Collections.IEnumerator enumerator, TypeEnum type)
        {
            viewWindow.SetTextOutput("Enumerator , TypeEnum OUTPUT"); 
            //throw new NotImplementedException();
        }

        public void sendOutput(string theString)
        {
            viewWindow.SetTextOutput(theString); //"The player has moved left."
            //throw new NotImplementedException();
        }
    }
}
