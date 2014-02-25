using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{/* start Game_System namespace */

    public interface View
    {/* start View interface */

        // C# does not allow public/private as part of a declaration.

         DirectionEnum getDirection();

         Object getInput(TypeEnum type);

         void sendOutput(IEnumerator enumerator, TypeEnum type);

         void sendOutput( String theString );

    }/* end View interface */

}/* end Game_System namespace */
