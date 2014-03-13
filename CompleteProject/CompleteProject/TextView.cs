using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_System;
using Character_System;

namespace View_System
{/* start View namespace */

    public class TextView : View
    {/* start TextView */

        private Party mGoodGuys;

        public Party GoodGuys
        {/* start GoodGuys property */

            set
            {/* start mutator */

                mGoodGuys = value;

            }/* end mutator */

        }/* end GoodGuys property */

        public DirectionEnum getDirection()
        {/* start getDirecton */

            throw new NotImplementedException();

        }/* end getDirection */

        public void updatePlayerLocation(int row, int column)
        {/* start updatePlayerLocation */

            throw new NotImplementedException();

        }/* end updatePlayerLocation */

        public void DeclineMovement()
        {/* start DeclineMovement */

            throw new NotImplementedException();

        }/* end DeclineMovement */

        public Character_System.ClassEnum getClassChoice()
        {
            throw new NotImplementedException();
        }

        public string getCharacterName()
        {
            throw new NotImplementedException();
        }

        public BattleSystem.BattleAction getPlayerAction(Character_System.Character character)
        {
            throw new NotImplementedException();
        }

        public void RecieveBattleOutput(BattleSystem.BattleEvent ourEvent)
        {
            throw new NotImplementedException();
        }

        public void NotifyFinalBattleStart()
        {
            throw new NotImplementedException();
        }

        public void NotifyBattleStart()
        {
            throw new NotImplementedException();
        }

        public void FoundItem(Character_System.Item item)
        {
            throw new NotImplementedException();
        }

    }/* end TextView */

}/* end View namespace */
