using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_System
{/* start Game_System namespace */
    
    public class Game
    {/* start Game class */

        private Dungeon mDungeon;
        private Party mGoodGuys;
        private BattleSystem mBattle;

        private bool mDragonDead = false;
        private bool mVictory = true;

        private Input mInput;
        private Output mOutput;

        public void run()
        {/* start run */

            bool createCharacter = false;

            while (!mDragonDead && mVictory)
            {/* start loop */

                if (!createCharacter)
                {/* start if */

                    createCharacters();
                    createCharacter = true;

                }/* end if */



            }/* end loop */

        }/* end run */

        public void notifyBattleOutcome( bool victory )
        {/* start notifyBattleOutcome */

            mVictory = victory;

        }/* end notifyBattleOutcome */

        private void createCharacters()
        {/* start createCharacters */

            int choice, i;
            String[] classes = new String[ 6 ] { "Warrior", "Theif", "Monk", "WhiteMage", "BlackMage", "RedMage" };
            String name;
            Character[] characters = new Character[ Party.MAXPARTY ];

            for (i = 0; i < Party.MAXPARTY; i++)
            {/* start loop */

                mOutput.sendOutput("What class type do you want? You get 3.");
                mOutput.sendOutput(classes.GetEnumerator);
                choice = mInput.getInput(TypeEnum.Int);
                name = mInput.getInput(TypeEnum.String);

                character[ i ] = CharacterCreationFactory(choice, name);

            }/* end loop */

            mGoodGuys = new Party(characters);

        }/* end createCharacters */

        public int getInput( int max )
        {/* start getInput */

            return mInput.getInput(TypeEnum.Int);

        }/* end getInput */

        public void giveBattleOutput( Event ourEvent )
        {/* start giveBattleOutput */
            
            

        }/* end giveBattleOutput */

        public void notifyDugeonUpdate()
        {/* start giveDungeonOutput */

            mOutput.sendOutput( mDungeon.getTileIterator() );

        }/* end giveDungeonOutput */

        public void dragonIsDead()
        {/* start dragonIsDead */



        }/* end dragonIsDead */

    }/* end Game class */

}/* end Game_System namespace */
