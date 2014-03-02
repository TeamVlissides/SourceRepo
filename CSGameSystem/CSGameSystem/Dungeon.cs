using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
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


Replace Gem Class with Item
and use a trasure box instead of
a Gem.

a. Complete isDirectionValid method.

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
            if (direction == DirectionEnum.RIGHT)
            {
                /*...*/
                MovePlayerLocation(DirectionEnum.RIGHT);
            }
            if (direction == DirectionEnum.DOWN)
            {
                /*...*/
                MovePlayerLocation(DirectionEnum.DOWN);
            }
            if (direction == DirectionEnum.UP)
            {
                /*...*/
                MovePlayerLocation(DirectionEnum.UP);
            }
                           
            
           //  mGame.notifyDungeonUpdate();

            // Check for item
            if (checkForItem())
            {
                // Give item to party.
                // mGoodGuyParty
            }

            if (checkIfDragon())
                mGame.startBattle(EnemyType.DRAGON);
            else
                if (RollBattleDice())
                    mGame.startBattle(EnemyType.NULL);
             

        }/* end getDirection */

        public void checkTile()
        {


        }

        public bool checkForItem()
        {
            return false;
        }

        public bool checkIfDragon()
        {
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
