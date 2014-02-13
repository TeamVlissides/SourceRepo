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

        private int mExperience;
        private int mLevel;
        private LevelTract mClassLevelTract;
        private bool mUpgraded;

        public PlayerCharacter(int health, int mana, Armor[] armor, string name, int[] stats, LevelTract classLevelTract )
        {/* start constructor */

            mHealth = health;
            mMana = mana;
            mArmor = armor;
            mName = name;
            mStats = stats;
            mClassLevelTract = classLevelTract;

            mExperience = 0;
            mLevel = 1;
            mUpgraded = false;

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
