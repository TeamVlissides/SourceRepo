using System;
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

        private int totalCombatants;
        private int currentActorNum;

        private Game mGame;

        // Constructors
        public Battle(Game currentGame)
        {
            mGame = currentGame;
        }

        // Methods
        public void startBattle()
        {
                       
            mGoodGuys = mGame.getParty();
            mBadGuys = new EnemyFactory().getEnemyParty(mGoodGuys.getLevel());

            totalCombatants = mGoodGuys.mParty.Length + mBadGuys.mParty.Length;
            currentActorNum = totalCombatants - 1;

            currentActor = selectNextCharactor();
        }

        public void startBattle(EnemyType type)
        {
            mGoodGuys = mGame.getParty();
            mBadGuys = new EnemyFactory().getEnemyParty(type);

            totalCombatants = mGoodGuys.getSize() + mBadGuys.getSize();
            currentActorNum = totalCombatants;

            currentActor = selectNextCharactor();
        }

        private void selectNextCharactor()
        {
            currentActorNum = (currentActorNum + 1) % totalCombatants;
            if(currentActorNum > mGoodGuys.getSize())
            {
                currentActor = mBadGuys.getCharacter(currentActorNum - mGoodGuys.getSize() - 1);
            }
            else
            {
                currentActor = mGoodGuys.getCharacter(currentActorNum);
            }

            if(currentActor.CurrentHealth == 0)
            {
                selectNextCharactor();
            }
        }

        public int[] getTargets()
        {
            int[] targets = { 0 };
            return targets;
        }

        public void executeAction(Action action, int[] targets)
        {

        }

        private void battleOver()
        {
            
        }

        private void GameOver()
        {

        }
    }
}
