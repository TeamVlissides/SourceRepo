using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_System
{/* start Game_System namespace */

    public interface View
    {/* start View interface */

        DirectionEnum getDirection();

        Object getInput(TypeEnum type);

        void sendOutput(IEnumerator enumerator, TypeEnum type);

        void sendOutput( String theString );

    }/* end View interface */

}/* end Game_System namespace */
