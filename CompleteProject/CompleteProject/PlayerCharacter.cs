using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Character_System
{/* end Character_System namespace */

    public class PlayerCharacter : Character
    {/* start PlayerCharacter class */

        private const int EXPERIENCEPERLEVEL = 1000;

        private int mExperience;
        private LevelTract mClass;
        private ClassEnum mClassEnum;
        private int mCurrentLevel;

        public PlayerCharacter( Armor[] armor, string name, int[] stats, Weapon weapon, LevelTract pclass, ClassEnum classes ) : base( armor,  name, stats, weapon, pclass )
        {/* start constructor */

            mExperience = 1000;
            mClass = pclass;
            mIsPlayer = true;
            mClassEnum = classes;
            mCurrentLevel = 1;

            mClass.LevelUp(mCurrentLevel);

        }/* end constructor */

        public ClassEnum Class
        {/* start Class propertry */

            get
            {/* start accessor */

                return mClassEnum;

            }/* end accessor */

        }/* end Class propertry */

        public int Level
        {/* start Level property */

            get
            {/* start accessor */

                return mCurrentLevel;

            }/* end accessor */

        }/* end Level property */

        public void gainExperience( int experience )
        {/* start gainExperience */

            mExperience += experience;

            if ((mExperience / EXPERIENCEPERLEVEL) > mCurrentLevel)
            {/* start if */

                mCurrentLevel++;
                mClass.LevelUp(mCurrentLevel);

            }/* end if */

        }/* end gainExperience */

    }/* end PlayerCharacter class */

}/* end Character_System namespace */
