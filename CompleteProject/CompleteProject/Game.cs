using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character_System;
using Dungeon_System;
using BattleSystem;

namespace Game_System
{/* start Game_System namespace */
    
    public class Game
    {/* start Game class */

        private Dungeon mDungeon;
        private Party mGoodGuys;
        private Battle mBattle;

        private bool mDragonDead = false;
        private bool mVictory = true;

        private View mView;

        public Game()
        {/* start constructor */

            initialize();

        }/* end constructor */

        public void run()
        {/* start run */

            while (!mDragonDead && mVictory)
            {/* start loop */

                DungeonGo();

            }/* end loop */

        }/* end run */

        public void DungeonGo()
        {/* start DungeonLoop */

            mDungeon.getDirection(mView.getDirection());

        }/* end DungeonLoop */

        public void notifyBattleOutcome( bool victory )
        {/* start notifyBattleOutcome */

            mVictory = victory;

        }/* end notifyBattleOutcome */

        private void initialize()
        {/* start initialize */

            int choice, i;
            String[] classes = new String[ 6 ] { "Warrior", "Theif", "Monk", "White Mage", "Black Mage", "Red Mage" };
            String name;
            Character[] characters = new Character[ Party.MAXPARTY ];

            for (i = 0; i < Party.MAXPARTY; i++)
            {/* start loop */

                mView.sendOutput("What class type do you want? You get 3.");
                mView.sendOutput(classes.GetEnumerator(), TypeEnum.STRING);
                choice = (int)mView.getInput(TypeEnum.INT);
                name = (string)mView.getInput(TypeEnum.STRING);

                characters[ i ] = CharacterFactory.getInstance().getCharacter((ClassEnum)choice, name);

            }/* end loop */

            mGoodGuys = new Party(characters);
            mBattle = new Battle(this, mGoodGuys);
            mDungeon = new Dungeon(this, mGoodGuys);

        }/* end initialize */

        public void giveBattleOutput( BattleEvent ourEvent )
        {/* start giveBattleOutput */

            throw new NotImplementedException();

        }/* end giveBattleOutput */

        public void notifyDungeonUpdate()
        {/* start giveDungeonOutput */

            //mView.sendOutput( mDungeon.getTileIterator(), TypeEnum.GRID );

        }/* end giveDungeonOutput */

        public void startBattle( EnemyType type )
        {/* start startBattle */

            if (type == EnemyType.NULL)
                mBattle.startBattle();
            else
                mBattle.startBattle(type);

        }/* end startBattle */


        internal BattleAction getPlayerAction( Character character )
        {
            throw new NotImplementedException();
        }
    }/* end Game class */

}/* end Game_System namespace */
