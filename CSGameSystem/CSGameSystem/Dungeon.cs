using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * UPDATE YOUR UML!!!... UML UPDATE.... UPDATE THE UML...
 * 
 * Possible apply the decorator pattern to the tiles to add color for background and borders
 * 
 * Use Singleton on the dungeon.
 * 
 * Add ability on GUI to attack and defend.
 * 
 * Make treasure image disapear after player moves over it.
 * 
 * Using the Null Object pattern with the Tiles.
 * 
 * **Create a static map for the dungeon so that you can get to the dungeon**
 * 
 * Need a ship battle event to the view system. 
 * 
 * Do a seperate window to put the stats sheet on instead of putting it
 * on the Dungeon window.
 * 
 * 1. Make the location of the treasure static.
- once game starts the first location of treasure stay 
  where it started.
2. How to handle what class type they want?
How to handle :
3. Stats for each player
4. Display how many goodguys and bad guys there are.
5. giving the items to the characters and then
   removing the item from the screen.
6. Create the TileFactory which will create tiles
for walls, freespace, treasure, dragon,
these will have images, need to get a wall image,
a freespace iamge, a dragon image.
7. Complete Checkfor/item/dragon, getdirection methods.
 * 
 * Dungeon:

View:

GUI:
add statistics
add players char
 * 
 * Make it so that the player cannot move over a wall.
 * 


Replace Gem Class with Item
and use a trasure box instead of
a Gem.
 * 
 * 10. Figure out how to test if a treasure/item is on a tile the
 * chracter is on.

a. Complete isDirectionValid method, 
 * did isWall instead.

6. Create the TileFactory which will create tiles
for walls, freespace, treasure, dragon,
these will have images, need to get a wall image,
a freespace iamge, a dragon image.

2. How to handle what class type they want?
How to handle :
3. Stats for each player
4. Display how many goodguys and bad guys there are.
5. giving the items to the characters and then
   removing the item from the screen.


7. Complete Checkfor/item/dragon, getdirection methods.
8. TileModel, and TileView to imp. single responsibility.


 */


namespace CSGameSystem
{
    public class Dungeon
    {
        // Attributes
        private Grid mGrid;
        private String mName;
        private Tile[,] tiles;
       // public int[,] playerLocation;
        private int playerLocationRow;
        private int playerLocationColumn;
        private Game mGame;
        private int[,] itemLocations;

        // reference needed to give items to party;
        private Party mGoodGuyParty;

        private View view;



        // Constructors
        public Dungeon()
        {
            // This is going to be a set size for the grid.
            mGrid = new Grid(5, 5);

            // Keeps track of the location of players on 5 by 5 gird.
            //playerLocation = new int[5, 5];
            playerLocationRow = 0;
            playerLocationColumn = 0;

            // Player begin at top left corner of grid.
            //playerLocation[0, 0] = 1;

            // Set starting tile and dragon tile
            Tile[,] sTiles = mGrid.GetTiles();

            // Set the dragon image on last tile
            sTiles[4, 4].TileType = DungeonEnum.DRAGON;

            // Make sure that the first tile is a freespace
            sTiles[0, 0].TileType = DungeonEnum.FREESPACE;
            

        }

        // Methods

        public int PlayerLocationRow
        {
            get
            {
                return playerLocationRow;
            }
            set
            {
                if (value >= 0 && value < mGrid.NumRows)
                    playerLocationRow = value;
            }
        }

        public int PlayerLocationColumn
        {
            get
            {
                return playerLocationColumn;
            }
            set
            {
                if (value >= 0 && value < mGrid.NumColumns)
                    playerLocationColumn = value;
            }
        }

        // Returns an array that contains the [row, col]
        public int[] getCurrentPartyLocation()
        {
            int[] tempArray = new int[2];
            tempArray[0] = PlayerLocationRow;
            tempArray[1] = PlayerLocationColumn;

            return tempArray;
        }
       
        public Grid GetGrid()
        {
            return mGrid;
        }

        public void SetView(View v)
        {
            view = v;
        }

        public void SetGame(Game g)
        {
            mGame = g;
        }

        /*
        private void ClearPlayerLocation()
        {
            // Set all locations to 0
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    playerLocation[i, j] = 0;
                }
            }
        } */

        private void MovePlayerLocation(DirectionEnum locationEnum)
        {

                if (locationEnum == DirectionEnum.UP)
                {
                    //if (playerLocationColumn > 0)
                    PlayerLocationColumn -= 1;
                    view.sendOutput("UP " + "[" + PlayerLocationRow + ", " + PlayerLocationColumn + "]");

  

                }
                else if (locationEnum == DirectionEnum.DOWN)
                {
                    //if (playerLocationColumn > 0)
                    PlayerLocationColumn += 1;
                    view.sendOutput("DOWN " + "[" + PlayerLocationRow + ", " + PlayerLocationColumn + "]");

                }
                else if (locationEnum == DirectionEnum.LEFT)
                {
                    //if (playerLocationRow > 0)
                    PlayerLocationRow -= 1;
                    view.sendOutput("LEFT " + "[" + PlayerLocationRow + ", " + PlayerLocationColumn + "]");


                }
                else if (locationEnum == DirectionEnum.RIGHT)
                {
                    //if (playerLocationRow > 0)
                    PlayerLocationRow += 1;
                    view.sendOutput("RIGHT " + "[" + PlayerLocationRow + ", " + PlayerLocationColumn + "]");

                }
            

        }

        public String GetDungeonName()
        {
            return mName; // new String(mName);
        }

        public void SetDungeonName(String name)
        {
            mName = name;
        }

        /* direction is the direction the party wants to go */
        public void getDirection(DirectionEnum direction)
        {/* start getDirection */

            //Method here. Update Location */
            if (direction == DirectionEnum.LEFT)
            {
                if (!isWall(direction))
                { 
                /*...*/
                // Check if direction is valid
                //    The PlayerLocationRow/Columns already do this.
                /*
                 * getCurrentPartyLocation()
                 * check if increment in that location is valid
                 * if valid return true, else return false.
                 * 
                 */ 
                //    but could setoutput that direction is invalid.
                // Update party location.
                    MovePlayerLocation(DirectionEnum.LEFT);
                //    check if item to give; 
                //    part.GiveItem(ItemEnum)
                // Check if dragon
                // if so start battle
                // if not step five
                // roll to see if random battle occurs; start battle
                // update view/ repaint.
                }
                else
                {
                    view.sendOutput("A wall is blocking you!");
                }

            }
            if (direction == DirectionEnum.RIGHT)
            {
                /*...*/
                if (!isWall(direction))
                    MovePlayerLocation(DirectionEnum.RIGHT);
                else
                    view.sendOutput("A wall is blocking you!");
            }
            if (direction == DirectionEnum.DOWN)
            {
                /*...*/
                if (!isWall(direction))
                    MovePlayerLocation(DirectionEnum.DOWN);
                else
                    view.sendOutput("A wall is blocking you!");
            }
            if (direction == DirectionEnum.UP)
            {
                /*...*/
                if (!isWall(direction))
                    MovePlayerLocation(DirectionEnum.UP);
                else
                    view.sendOutput("A wall is blocking you!");
            }
                           
            
           //  mGame.notifyDungeonUpdate();

            // Check for item
            if (checkForItem())
            {
                // Give item to party.
                // mGoodGuyParty
                view.sendOutput("Give item to party.");

            }

            if (checkIfDragon())
            {
                mGame.startBattle(EnemyType.DRAGON);
                view.sendOutput("Dragon Battle has started.");
            }
            else
                if (!isWall(direction) && RollBattleDice())
                    mGame.startBattle(EnemyType.NULL);
             

        }/* end getDirection */

        // Check if the next move is a wall.
        public Boolean isWall(DirectionEnum directionEnum)
        {
            int row = PlayerLocationRow;
            int col = PlayerLocationColumn;

            if (directionEnum == DirectionEnum.UP)
            {
                if (col >= 0)
                    col--;
            }

            if (directionEnum == DirectionEnum.DOWN)
            {
                if (col >= 0)
                  col++;
            }

            if (directionEnum == DirectionEnum.LEFT)
            {
                if (row >= 0)
                    row--;
            }

            if (directionEnum == DirectionEnum.RIGHT)
            {
                if (row >= 0)
                 row++;
            }

            // Dont let out of bounds conditions happen,
            // and prevent negative numbers.
            if (row < 0 || row > 4)
                row = 0;

            if (col < 0 || col > 4)
                col = 0;

            Tile[,] tmpTiles = mGrid.GetTiles();
            DungeonEnum item = tmpTiles[row, col].TileType;
            if (item == DungeonEnum.WALL)
                return true;
            return false;
        }

        public void checkTile()
        {

        }

        public bool checkForItem()
        {
            // Check if tile has an item
            Tile[,] tmpTiles = mGrid.GetTiles();
            DungeonEnum tileHasItem = tmpTiles[PlayerLocationRow, PlayerLocationColumn].TileType;
            if (tileHasItem == DungeonEnum.ITEM)
                return true; // view.sendOutput("Tile has item.");

            return false;
        }

        public bool checkIfDragon()
        {
            Tile[,] tmpTiles = mGrid.GetTiles();
            DungeonEnum item = tmpTiles[PlayerLocationRow, PlayerLocationColumn].TileType;
            if (item == DungeonEnum.DRAGON)
                return true;
            return false;
        }

        public bool RollBattleDice()
        {
            Random randomDiceRoll = new Random();
            int diceRollNumber = randomDiceRoll.Next(1,100);
            // percentage, probability that I will roll, pick a number... 
            // if roll on a number start a battle else do notthing.
            // if roll > 50 go into battle, else no battle.
            view.sendOutput("Dice Roll!");
            if (diceRollNumber > 50)
            {
                return true;
            }

            view.sendOutput("No battle.");
            return false;
        }

        /*
       public Game GetGame()
       {

       }

       public Party GetGoodGuyParty()
       {

       }
        * */



        // Interaction with other Systems code here...

        /*
         * So the Dungeon System knows where the characters(heros, enemies) are located on the 
         * board, it knows the location of Treasure chest and what special abilities it will
         * give to the characters, there are also walls, free space, treasure, dragon, that
         * can be in the tiles. The dungeon also determines when a battle occurs,
         * using the roll of the dice, 
         * 
         * The location of the treasure will be static.
         * 
         * There will not be a enemy image becuase the determination if there is a battle
         * is by the roll of the dice. 
         * 
         * Change the Gem icon to a treasure box icon.
         * 
         * Implement statisitcs on the GUI.
         *  - How does the GUI get updates about the statistics for the characters?
         * 
         * 
         */ 

        // get character location

        // 

        // 

        // 

        // whatIsCurrentLocation(), eg, a wall, freespace, treasure, dragon, ect.

        // make the Character be an observer of the Dungeon, so that it knows
        // when a battle occurs, and the character should activate the battle system
        // if a battle occurs on a tile. 

        // should the Character also observe when the Tile has Treasure and then determine what to
        // do with it.

        // 
    }
}
