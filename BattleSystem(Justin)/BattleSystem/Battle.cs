﻿using System;
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
        private int currentActor;

        private Character[] turnOrder;

        private Game mGame;

        // Constructors
        public Battle(Game currentGame)
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
                       
            mGoodGuys = mGame.getParty();
            mBadGuys = new EnemyFactory().getEnemyParty(mGoodGuys.getLevel());

            turnOrder = buildTurnOrder();
            currentActor = 0;
            while (turnOrder[currentActor].isDead)
            {
                currentActor++;
            }
        }

        public void startBattle(EnemyType type)
        {
            mGoodGuys = mGame.getParty();
            mBadGuys = new EnemyFactory().getEnemyParty(type);

            turnOrder = buildTurnOrder();
            while (turnOrder[currentActor].isDead)
            {
                currentActor++;
            }
        }

        private Character[] buildTurnOrder()
        {
            Character[] orderOfBattle = new Character[mGoodGuys.size + mBadGuys.size];
            for (int i = 0; i < mGoodGuys.size; i++)
            {
                orderOfBattle[i] = mGoodGuys.getCharacter[i];
            }
            for (int i = 0; i < mBadGuys.size; i++)
            {
                orderOfBattle[i + mGoodGuys.size] = mBadGuys.getCharacter[i];
            }
            return orderOfBattle;
        }

        public ArrayList getFriendlyTargets()
        {
            ArrayList targetlist = new ArrayList();
            for (int i = 0; i < mGoodGuys.size; i++)
            {
                if(mGoodGuys.getCharacter(i).isDead() == false)
                {
                    targetlist.Add(i);
                }
            }
            return targetlist;
        }

        public ArrayList getHostileTargets()
        {
            ArrayList targetlist = new ArrayList();
            for (int i = mGoodGuys.size; i < mGoodGuys.size; i++)
            {
                if (mGoodGuys.getCharacter(i).isDead() == false)
                {
                    targetlist.Add(i + mGoodGuys.size);
                }
            }
            return targetlist;
        }

        public ArrayList getTargets(Ability abilityToUse)
        {
            ArrayList targetlist = new ArrayList();
            return targetlist;
        }

        public ArrayList getTargets(Item itemToUse)
        {
            ArrayList targetlist = new ArrayList();
            return targetlist;
        }

        public void executeAction(BattleAction actionToExecute, ArrayList targetlist)
        {
            foreach(int i in targetlist)
            {
                actionToExecute.specificAction(turnOrder[currentActor], turnOrder[i]);
                mGame.giveBattleOutput(new Event(turnOrder[currentActor], actionToExecute, turnOrder[i]));
            }
            checkBattleOver();
            while (turnOrder[currentActor].isDead)
            {
                currentActor++;
            }
        }

        private void checkBattleOver()
        {
            if(mGoodGuys.isDead || mBadGuys.isDead)
            {
                mGame.notifyBattleOutcome(mBadGuys.isDead);
            }
        }

        public Character getCharacter(int charIndex)
        {
            return turnOrder[charIndex];
        }
    }
}
