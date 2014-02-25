using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    class Dungeon
    {
        // Attributes
        private Grid mGrid;
        private String mName;
        private Tile[,] tiles;
        private Game mGame;
        private Party mGoodGuyParty;

        // Constructors
        public Dungeon()
        {
            mGrid = new Grid(5, 5);
        }

        // Methods
       
        public Grid GetGrid()
        {
            return mGrid;
        }

        public String GetDungeonName()
        {
            return ""; // new String(mName);
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
                /*...*/

                if (direction == DirectionEnum.RIGHT)
                    /*...*/

                    if (direction == DirectionEnum.DOWN)
                        /*...*/

                        if (direction == DirectionEnum.UP)
                            /*...*/

                            mGame.notifyDungeonUpdate();

            if (checkIfDragon())
                mGame.startBattle(EnemyType.DRAGON);
            else
                if (RollBattleDice())
                    mGame.startBattle(EnemyType.NULL);

        }/* end getDirection */

        public bool checkIfDragon()
        {
            return false;
        }

        public bool RollBattleDice()
        {
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

        // get enemy location

        // whatIsCurrentLocation(), eg, a wall, freespace, treasure, dragon, ect.

        // make the Character be an observer of the Dungeon, so that it knows
        // when a battle occurs, and the character should activate the battle system
        // if a battle occurs on a tile. 

        // should the Character also observe when the Tile has Treasure and then determine what to
        // do with it.

        // 
    }
}
