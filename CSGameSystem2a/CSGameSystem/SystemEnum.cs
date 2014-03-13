using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{/* start Game_System */

    public enum TypeEnum : int
    {/* start TypeEnum */

        NULL = -1,
        INT = 0,
        STRING = 1,
        GRID = 2

    }/* end TypeEnum */

    public enum DirectionEnum : int
    {/* start TypeEnum */

        LEFT = 1,
        RIGHT = 2,
        UP = 3,
        DOWN = 4

    }/* end TypeEnum */

    public enum EnemyType : int
    {/* start EnemyType enum */

        NULL = -1,
        DRAGON = 0

    }/* end EnemyType enum */

}/* end Game_System */
