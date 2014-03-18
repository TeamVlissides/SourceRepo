using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSGameSystem
{/* end Character_System namespace */

    public class PlayerCharacter : Character
    {/* start PlayerCharacter class */

        private int mExperience;
        private int mLevel;
        private bool mUpgraded;
        private LevelTract mClass;

        public PlayerCharacter( Armor[] armor, string name, int[] stats, Weapon weapon, LevelTract pclass ) : base( armor,  name, stats, weapon, pclass )
        {/* start constructor */

            mExperience = 0;
            mLevel = 1;
            mUpgraded = false;
            mClass = pclass;

            mClass.LevelUp(1);

        }/* end constructor */

        public int Level
        {/* start Level property */

            get
            {/* start accessor */

                return mLevel;

            }/* end accessor */

        }/* end Level property */

        public bool Upgraded
        {/* start Upgraded property */

            get
            {/* start accessor */

                return mUpgraded;

            }/* end accessor */

        }/* end Upgraded property */

        public void gainExperience( int experience )
        {/* start gainExperience */

            

        }/* end gainExperience */

    }/* end PlayerCharacter class */

}/* end Character_System namespace */
