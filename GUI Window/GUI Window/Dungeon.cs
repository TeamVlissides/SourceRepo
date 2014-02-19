using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Window
{
    class Dungeon
    {
        // Attributes
        private Grid mGrid;
        private String mName;
        private Tile[,] tiles;
       // private Game mgame;
       // private Party mGoodGuyParty;

        // Constructors
        public Dungeon()
        {
            mGrid = new Grid(5, 5);
        }

        // Methods
        public void MovePlayer()
        {

        }

       
        public Grid GetGrid()
        {
            return mGrid;
        }

        public String GetDungeonName()
        {
            return null;
        }

        /*
       public Game GetGame()
       {

       }

       public Party GetGoodGuyParty()
       {

       }
        * */
    }
}
