using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    public class Grid
    {
        // Attributes
        private int mNumRows;
        private int mNumColumns;
        private int mPartyRow;
        private int mPartyColumn;
        private Tile[,] tiles;
        private Tile mTiles;

        // Images on the tiles
        // not here in the view.



        // Constructor
        public Grid()
        {
             mNumRows = 5;
             mNumColumns = 5;
             createGrid();
        }

        public Grid(int row, int col)
        {
             mNumRows = row;
             mNumColumns = col;
             createGrid();
        }


        // Methods

        public int NumRows
        {
            get
            {
                return mNumRows;
            }
            set
            {
                mNumRows = value;
            }
        }
        public int NumColumns
        {
            get
            {
                return mNumColumns;
            }
            set
            {
                mNumColumns = value;
            }
        }

        public void createGrid()
        {
            // Create tiles
            tiles = new Tile[mNumRows, mNumColumns];
            Random rand = new Random();
            TileFactory tileFactory = new TileFactory();

            // Rows
            for (int i = 0; i < mNumRows; i++)
            {
                // Columns
                for (int j = 0; j < mNumColumns; j++)
                {
                   // tiles[i, j] = new Tile(rand);
                    tiles[i, j] = tileFactory.createTile(rand);
                }
            }
        }

        // setter methods
        public void SetNumberRows(int n)
        {

        }

        public void SetNumberColumns(int n)
        {

        }

        // getter methods

        //public void isDirectionValid(DirectionEnum direction)
        //{

       // }



        public void SetPartyRow(int row)
        {

        }

        public void SetPartyColumn(int n)
        {

        }

        public Tile[,] GetTiles()
        {
            return tiles;
        }
    }
}
