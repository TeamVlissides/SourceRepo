using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character_System;

namespace Game_System
{/* start Game_System namespace */
    
    public class Game
    {/* start Game class */

        private Dungeon mDungeon;
        private Party mGoodGuys;
        private BattleSystem mBattle;

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

            mDungeon.getDirection(mView.getInput(TypeEnum.DIRECTION));

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
                mView.sendOutput(classes.GetEnumerator);
                choice = mView.getInput(TypeEnum.INT);
                name = mView.getInput(TypeEnum.STRING);

                characters[ i ] = CharacterCreationFactory(choice, name);

            }/* end loop */

            mGoodGuys = new Party(characters);
            mBattle = new BattleSystem(this, mGoodGuys);
            mDungeon = new Dungeon(this, mGoodGuys);

        }/* end initialize */

        public void giveBattleOutput( Event ourEvent )
        {/* start giveBattleOutput */
            
            

        }/* end giveBattleOutput */

        public void notifyDungeonUpdate()
        {/* start giveDungeonOutput */

            mView.sendOutput( mDungeon.getTileIterator() );

        }/* end giveDungeonOutput */

        public void startBattle( EnemyType type )
        {/* start startBattle */

            if (type == EnemyType.NULL)
                mBattle.startBattle();
            else
                mBattle.startBattle(type);

        }/* end startBattle */

    }/* end Game class */

}/* end Game_System namespace */
