using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character_System;
using Game_System;

namespace Battle_System
{/* start Battle_System namespace */

    public class BattleSystem
    {/* start BattleSystem class */

        private Party mGoodGuys;
        private Game mGame;

        public BattleSystem( Game game, Party party )
        {/* start constructor */

            mGame = game;
            mGoodGuys = party;

        }/* end construtor */

        /*
         * Updated: 3/6/2014
         * 
         * Name: startBattle
         * Description: Starts and runs a battle for the game.
         * Parameters: None
         * Return: None
         * 
         * Steps:
         * 
         * Step 1: Get enemy party from enemy factory.
         * Step 2: Create an array of with both enemy and good guy characters sort by agility.
         * Step 3: While each party is alive...                                                                            (L)
         * Step 4: If the character is alive...
         * Step 5: For each character, determine if they're a PlayerCharacter or an Enemy.
         * Step 6: If it's a player, determine what the player wants to do.                                                (F)
         * Step 7: If it's a badGuy, call takeTurn.
         * Step 8: Do calculations to determine healing/damage of the action.                                              (F)
         * Step 9: Send the BattleAction to the Game.
         * Step 10: After a party dies, check to see if it was the goodGuys party. If so, notify the game that they died.
         */

        public void startBattle()
        {/* start startBattle */

            int i = 0;
            
            PlayerCharacter player;
            Enemy enemy;
            BattleEvent battleEvent;

            /* Step 1 */
            Party enemies = EnemyFactory(mGoodGuys.Level);

            /* Step 2 */
            Character[] characters = mGoodGuys.getTurnOrder(enemies);

            /* Step 3 */
            while (!mGoodGuys.isDead && !enemies.isDead)
            {/* start loop */

                /* Step 4 */
                if( !characters[ i ].isDead )
                {/* start if */

                    /* Step 5 */
                    if (characters[i].isPlayer)
                    {/* start if */

                        player = (PlayerCharacter)characters[ i ];

                        /* Step 6 */
                        battleEvent = playersTurn(player, enemies);

                    }/* end if */
                    else
                    {/* start else */

                        enemy = (Enemy)characters[ i ];

                        /* Step 7 */
                        battleEvent = enemy.takeTurn(mGoodGuys);

                    }/* end else */

                    /* Step 8 */
                    calculateResultAndUpdate(battleEvent);

                    /* Step 9 */
                    mGame.giveBattleOutput(battleEvent);

                }/* end if */

                i++;

                if (i == characters.Length)
                    i = 0;

            }/* end loop */

            /* Step 10 */
            if (mGoodGuys.isDead)
                mGame.notifyBattleOutcome(false);
            else
                mGame.notifyBattleOutcome(true);

        }/* start startBattle */

        /* 
         * Updated: 3/6/2014
         * 
         * Name: playersTurn
         * Description: Handles getting all the information from the player to create a BattleEvent.
         * Parameters: None
         * Return: None
         * 
         * Steps:    
         * 
         * Step 1: Ask from the Game what action they want to perform.
         * Step 2: If the player wants to do an ability, ask the Game which ability they want to do from their list of them.
         * Step 3: Ask the Game what target the player wants to use their action on if it's a sinlge target ability.
         * Step 4: If the action is an attack, ask the Game what target the player wants to hit.
         * Step 5: Collect all the data in a BattleEvent and return that.
         */

        private BattleEvent playersTurn( PlayerCharacter player, Party enemies )
        {/* start playersTurn */

            ActionEnum action;
            Ability ability = null;
            Character target = null;

            /* Step 1 */
            action = mGame.getAction();

            if (action == ActionEnum.ABILITY)
            {/* start if */

                /* Step 2 */
                ability = player.Abilities.getAbilityAtIndex(mGame.getAbility( player.Abilities ));

                /* Step 3 */
                if (ability.isSingleTarget)
                    target = enemies.getCharacter(mGame.getTarget(enemies));

             }/* end if */

             /* Step 4 */
             if( action == ActionEnum.ATTACK )
                target = enemies.getCharacter(mGame.getTarget(enemies));

             //if( action == ActionEnum.ITEM )

             /* Step 5 */
             return new BattleEvent(player, new BattleAction(action, ability), target, 0);

        }/* end playersTurn */

        private void calculateResultAndUpdate(BattleEvent battleEvent)
        {/* start calculateResultAndUpdate */



        }/* end calculateResultAndUpdate */

        public void startBattle( EnemyType type )
        {/* start startBattle */



        }/* start startBattle */

    }/* start BattleSystem class */

}/* end Battle_System namespace */
