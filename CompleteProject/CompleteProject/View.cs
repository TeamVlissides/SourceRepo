using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character_System;
using BattleSystem;
using Dungeon_System;

namespace Game_System
{/* start Game_System namespace */

    public interface View
    {/* start View interface */

        /* For Dungeon System */
        DirectionEnum getDirection();

        void updatePlayerLocation(int row, int column);

        void DeclineMovement();

        /* For Character System */
        ClassEnum getClassChoice();

        String getCharacterName();

        /* For Battle System */
        BattleAction getPlayerAction( Character character, Party badGuys );

        void RecieveBattleOutput( BattleEvent ourEvent );

        /* For Game Controller */
        void NotifyFinalBattleStart();

        void NotifyBattleStart();

        void FoundItem( Item item );

        void notifyGameOver();

        Party GoodGuys
        {/* start GoodGuys property */

            set;

        }/* end GoodGuys property */

        Grid Dungeon
        {/* start Dungeon property */

            set;

        }/* end Dungeon property */

    }/* end View interface */

}/* end Game_System namespace */
