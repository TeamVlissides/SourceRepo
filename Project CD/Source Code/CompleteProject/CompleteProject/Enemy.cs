using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleSystem;

namespace Character_System
{/* start Character_System namespace */

    public class Enemy : Character
    {/* start Enemy class */

        private int mExperienceWorth;
        private AI mAI;
        private EnemyType mType;

        public Enemy( Armor[] armor, string name, int[] stats, Weapon weapon, int experienceWorth, AI ai, EnemyType type ) : base( armor,  name, stats, weapon, ai )
        {/* start constructor */

            mExperienceWorth = experienceWorth;
            mAI = ai;
            mIsPlayer = false;
            mType = type;

            mAI.Enemy = this;

        }/* end constructor */

        public EnemyType Type
        {/* start Type property */

            get
            {/* start accessor */

                return mType; 

            }/* end accessor */

        }/* end Type property */

        public int Worth
        {/* start Worth property */

            get
            {/* start accessor */

                return mExperienceWorth;

            }/* end accessor */

        }/* end Worth property */

        public BattleAction takeTurn( Party goodGuys )
        {/* start takeTurn */

            return mAI.ai( goodGuys );

        }/* end takeTurn */

    }/* end Enemy class */

}/* end Character_System namespace */
