using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DungeonSystem2
{
    internal class Dungeon
    {

        // Attributes
        private Grid mGrid;
        private String mName;
        private Game mGame;
        private Party mGoodGuyParty;

        public Grid GetGrid()
        {
            return null;
        }

        public String GetDungeonName()
        {
            return new String(mName);
        }
		
		public void SetDungeonName(String name)
		{

            mName = name;

		}
        /* direction is the direction the party wants to go */
        public void getDirection( DirectionEnum direction )
        {/* start getDirection */

            //Method here. Update Location */
            if( direction == DirectionEnum.LEFT )
                /*...*/

            if( direction == DirectionEnum.RIGHT )
                /*...*/

            if( direction == DirectionEnum.DOWN )
                /*...*/

            if( direction == DirectionEnum.UP )
                /*...*/

            notifyDungeonUpdate();

            if( checkIfDragon() )
                mGame.StartBattle(EnemyType.DRAGON);
            else
                if( RollBattleDice() )
                    mGame.StartBattle( EnemyType.NULL );

        }/* end getDirection */

    }

}
