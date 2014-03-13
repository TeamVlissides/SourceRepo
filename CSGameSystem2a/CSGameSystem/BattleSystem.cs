using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{
    public class BattleSystem
    {

        // Attributes
        private Party mGoodGuys;
        private Party mBadGuys;
        private Character currentActor;

        private int totalCombatants;
        private int currentActorNum;

        private Game mGame;
        private View view;

        public BattleSystem(View v)
        {
            view = v;
        }

        // Constructors
        public BattleSystem(Game currentGame)
        {
            mGame = currentGame;
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
                       
           // mGoodGuys = mGame.getParty();
          //  mBadGuys = new EnemyFactory().getEnemyParty(mGoodGuys.getLevel());

           // totalCombatants = mGoodGuys.mParty.Length + mBadGuys.mParty.Length;
           // currentActorNum = totalCombatants - 1;

           // currentActor = selectNextCharactor();
            view.sendOutput("Battle has started.");

        }

        public void startBattle(EnemyType type)
        {
           // mGoodGuys = mGame.getParty();
           // mBadGuys = new EnemyFactory().getEnemyParty(type);

            //totalCombatants = mGoodGuys.getSize() + mBadGuys.getSize();
            //currentActorNum = totalCombatants;

           // currentActor = selectNextCharactor();
        }

        private void selectNextCharactor()
        {
            /*
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
             * */
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
