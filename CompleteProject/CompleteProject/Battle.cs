using Character_System;
using Game_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSystem
{
    class Battle
    {

        // Attributes
        private Party mGoodGuys;
        private Party mBadGuys;
        private Character currentActor;
        private int currentActorIndex;

        private Character[] turnOrder;

        private Game mGame;

        // Constructors
        public Battle(Game currentGame, Party goodGuyParty)
        {
            mGame = currentGame;
            mGoodGuys = goodGuyParty;
        }

        // Methods
        /*Start Battle Method Outline */
        /* 1) Get good and bad guys.
         * 2) Create an array that can hold all characters.
         * 3) Sort array by agility.
         * 4) Loop through array, giving each character a turn. Start over at the first element you the last goes.(L)
         * 5) For each players turn, MATH and handle choices. (F)
         * 6) If a player character defeats an enemy, call the gainExperience method of the character and send the worth of the enemy it defeated.
         */

        public void startBattle()
        {
            mBadGuys = new EnemyFactory().getEnemyParty(mGoodGuys.getLevel());

            turnOrder = mGoodGuys.getTurnOrder(mBadGuys);
            selectFirstCharacter();

            while(!battleOver())
            {
                if (currentActor.mIsPlayer)
                {
                    executeAction(mGame.getPlayerAction());
                }
                else
                {
                    executeAction(currentActor.mAI.ai(turnOrder));
                }
            }

        }

        public void startBattle(EnemyType type)
        {
            mBadGuys = new EnemyFactory().getSpecificParty(type);

            turnOrder = mGoodGuys.getTurnOrder(mBadGuys);
            selectFirstCharacter();

            turnOrder = mGoodGuys.getTurnOrder(mBadGuys);
            selectFirstCharacter();

            while (!battleOver())
            {
                if (currentActor.mIsPlayer)
                {
                    executeAction(mGame.getPlayerAction());
                }
                else
                {
                    executeAction(currentActor.mAI.ai(turnOrder));
                }
            }
        }

        public ArrayList getFriendlyTargets()
        {
            ArrayList targetlist = new ArrayList();
            for (int i = 0; i < mGoodGuys.mPartySize; i++)
            {
                if(mGoodGuys.getCharacter(i).isDead == false)
                {
                    targetlist.Add(mGoodGuys.getCharacter(i));
                }
            }
            return targetlist;
        }

        public ArrayList getHostileTargets()
        {
            ArrayList targetlist = new ArrayList();
            for (int i = 0; i < mBadGuys.mPartySize; i++)
            {
                if (mBadGuys.getCharacter(i).isDead == false)
                {
                    targetlist.Add(mBadGuys.getCharacter(i));
                }
            }
            return targetlist;
        }

        public void executeAction(BattleAction actionToExecute)
        {
            actionToExecute.specificAction(currentActor, turnOrder);
            ArrayList executedActions = actionToExecute.getBattleEvents();
            foreach (BattleEvent currentEvent in executedActions)
            {
                mGame.giveBattleOutput(currentEvent);
            }
            selectNextCharacter();
        }

        private Boolean battleOver()
        {
            return (mGoodGuys.isDead || mBadGuys.isDead);
        }

        public Character getCharacter(int charIndex)
        {
            return turnOrder[charIndex];
        }

        private void selectFirstCharacter()
        {
            int i = 0;
            currentActor = turnOrder[i];
            while (!currentActor.isDead)
            {
                i++;
                currentActor = turnOrder[i];
                currentActorIndex = i;
            }
        }

        private void selectNextCharacter()
        {
            int i = (currentActorIndex + 1) % turnOrder.Length;
            currentActor = turnOrder[i];
            while (!currentActor.isDead)
            {
                i = (i + 1) % turnOrder.Length;
                currentActor = turnOrder[i];
                currentActorIndex = i;
            }
        }
    }
}
