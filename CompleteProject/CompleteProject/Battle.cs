using Character_System;
using Dungeon_System;
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
            mBadGuys = EnemyFactory.getInstance().getEnemyParty(mGoodGuys.Level);

            turnOrder = mGoodGuys.getTurnOrder(mBadGuys);
            selectFirstCharacter();

            while(!battleOver())
            {
                if (currentActor.isPlayer)
                {
                    executeAction(mGame.getPlayerAction(currentActor, mBadGuys));
                }
                else
                {
                    Enemy current_enemy = (Enemy)currentActor;
                    executeAction(current_enemy.takeTurn(mGoodGuys));
                }
            }

        }

        public void startBattle(EnemyType type)
        {
            mBadGuys = EnemyFactory.getInstance().getSpecificParty(type);

            turnOrder = mGoodGuys.getTurnOrder(mBadGuys);
            selectFirstCharacter();

            turnOrder = mGoodGuys.getTurnOrder(mBadGuys);
            selectFirstCharacter();

            while (!battleOver())
            {
                if (currentActor.isPlayer)
                {
                    executeAction(mGame.getPlayerAction( currentActor, mBadGuys ));
                }
                else
                {
                    Enemy current_enemy = (Enemy) currentActor;
                    executeAction(current_enemy.takeTurn(mGoodGuys));
                }
            }
        }

        #region Dead Code Thus Far
        public ArrayList getFriendlyTargets()
        {
            ArrayList targetlist = new ArrayList();
            for (int i = 0; i < mGoodGuys.Size; i++)
            {
                if (mGoodGuys.getCharacter(i).isDead == false)
                {
                    targetlist.Add(mGoodGuys.getCharacter(i));
                }
            }
            return targetlist;
        }

        public ArrayList getHostileTargets()
        {
            ArrayList targetlist = new ArrayList();
            for (int i = 0; i < mBadGuys.Size; i++)
            {
                if (mBadGuys.getCharacter(i).isDead == false)
                {
                    targetlist.Add(mBadGuys.getCharacter(i));
                }
            }
            return targetlist;
        }

        public ArrayList getItemTargets(Item selectedItem)
        {
            ArrayList targetlist = new ArrayList();
            for (int i = 0; i < turnOrder.Length; i++)
            {
                targetlist.Add(turnOrder[i]);
            }
            return targetlist;
        }

        public ArrayList getAbilityTargets(Ability selectedAbility)
        {
            ArrayList targetlist = new ArrayList();
            for (int i = 0; i < turnOrder.Length; i++)
            {
                if (turnOrder[i].isPlayer && !selectedAbility.AffectEnemy || !turnOrder[i].isPlayer && selectedAbility.AffectEnemy)
                {
                    targetlist.Add(turnOrder[i]);
                }
            }
            return targetlist;
        }

        #endregion

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

        /* Get the first alive character. R.F. 3/13/2014 */
        private void selectFirstCharacter()
        {
            int i = 0;
            currentActor = turnOrder[i];
            currentActorIndex = i;
            //while (!currentActor.isDead)
            //{
            //    i++;
            //    /* Index Out of Bounds exception keeps happening here (R.F.)*/
            //    currentActor = turnOrder[i];
            //    currentActorIndex = i;
            //}

            for (i = 0; i < turnOrder.Length; i++)
            {/* start loop */

                if (!currentActor.isDead)
                    break;

                currentActor = turnOrder[i];
                currentActorIndex = i;

            }/* end loop */
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
