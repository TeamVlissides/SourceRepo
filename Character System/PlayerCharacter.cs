﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Character_System
{/* end Character_System namespace */

    public class PlayerCharacter : Character
    {/* start PlayerCharacter class */

        private int mExperience;
        private LevelTract mClass;

        public PlayerCharacter( Armor[] armor, string name, int[] stats, Weapon weapon, LevelTract pclass ) : base( armor,  name, stats, weapon, pclass )
        {/* start constructor */

            mExperience = 0;
            mLevel = 1;
            mClass = pclass;

            mClass.LevelUp(1);

        }/* end constructor */

        public int Level
        {/* start Level property */

            get
            {/* start accessor */

                return (mExperience + 1000) / 1000;

            }/* end accessor */

        }/* end Level property */

        public void gainExperience( int experience )
        {/* start gainExperience */

            

        }/* end gainExperience */

    }/* end PlayerCharacter class */

}/* end Character_System namespace */
