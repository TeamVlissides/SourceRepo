using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character_System;
using Dungeon_System;
using BattleSystem;
using View_System;

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

            ClassEnum choice;
            int i;
            String name;
            Character[] characters = new Character[ Party.MAXPARTY ];

            mView = new TextView();

            for (i = 0; i < Party.MAXPARTY; i++)
            {/* start loop */


                choice = mView.getClassChoice();
                name = mView.getCharacterName();

                characters[ i ] = CharacterFactory.getInstance().getCharacter(choice, name);

            }/* end loop */

            mGoodGuys = new Party(characters);
            mView.GoodGuys = mGoodGuys;
            mBattle = new Battle(this, mGoodGuys);
            mDungeon = new Dungeon(this);
            mView.Dungeon = mDungeon.Grid;

        }/* end initialize */

        public void giveBattleOutput( BattleEvent ourEvent )
        {/* start giveBattleOutput */

            mView.RecieveBattleOutput(ourEvent);

        }/* end giveBattleOutput */

        public void startBattle( EnemyType type )
        {/* start startBattle */

            if (type == EnemyType.NULL)
            {/* start if */

                mView.NotifyBattleStart();
                mBattle.startBattle();

            }/* end if */
            else
            {/* start else */

                if (type == EnemyType.DRAGON)
                    mView.NotifyFinalBattleStart();

                mBattle.startBattle(type);

            }/* end else */

        }/* end startBattle */

        public BattleAction getPlayerAction( Character character, Party badGuys )
        {/* start getPlayerAction */

            return mView.getPlayerAction(character, badGuys);

        }/* end getPlayerAction */

        public void updatePlayerLocation(int row, int column)
        {/* start updatePlayerLocation */

            mView.updatePlayerLocation(row, column);

        }/* end updatePlayerLocatoin */

        public void HitAWall()
        {/* start HitAWall */

            mView.DeclineMovement();

        }/* end HitAWall */

        public void FoundItem()
        {/* start FoundItem */

            Random random = new Random();
            ItemEnum itemSelection = (ItemEnum)random.Next(1,6);
            Item item = ItemFactory.getItem(itemSelection);

            mView.FoundItem(item);

            mGoodGuys.giveItem(item);

        }/* end FoundItem */

    }/* end Game class */

}/* end Game_System namespace */
