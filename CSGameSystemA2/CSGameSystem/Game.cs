﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{/* start Game_System namespace */
    
    public class Game
    {/* start Game class */

        private Dungeon mDungeon;
        private Party mGoodGuys;
        private Battle mBattle;

        private bool mDragonDead = false;
        private bool mVictory = true;

        private View mView;

        private GUIWindow viewWindow;

        public Game(GUIWindow view)
        {/* start constructor */

            viewWindow = view;
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

           // mView = new TextView();


            mDungeon = Dungeon.getInstance(this);
            mView = new DisplayView(viewWindow, mDungeon);

            //for (i = 0; i < Party.MAXPARTY; i++)
            for (i = 0; i < 1; i++)
            {/* start loop */


                choice = mView.getClassChoice();
                name = mView.getCharacterName();


                characters[ i ] = CharacterFactory.getInstance().getCharacter(choice, name);

            }/* end loop */

            mGoodGuys = new Party(characters);
            // mView.GoodGuys = mGoodGuys;
            mBattle = new Battle(this, mGoodGuys);
           
            mDungeon.SetView(mView);
            mDungeon.SetGame(this);
            //mView.Dungeon = mDungeon.Grid;

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

        public Dungeon Dungeon
        {
            get
            {
                return mDungeon;
            }
            set
            {
                mDungeon = value;
            }
        }

        public Party GoodGuys
        {
            get
            {
                return mGoodGuys;
            }
            set
            {
                mGoodGuys = value;
            }
        }

        public Battle Battles
        {
            get
            {
                return mBattle;
            }
            set
            {
                mBattle = value;
            }
        }

        public View View
        {
            get
            {
                return mView;
            }
            set
            {
                mView = value;
            }
        }



    }/* end Game class */

}/* end Game_System namespace */
