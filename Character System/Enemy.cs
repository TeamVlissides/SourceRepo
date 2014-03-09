using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battle_System;

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

        public BattleEvent takeTurn( Party goodGuys )
        {/* start takeTurn */

            throw new NotImplementedException();

        }/* end takeTurn */

        public void addAbility(Ability ability)
        {/* start addAbility */

            mAI.addAbility(ability);

        }/* end addAbility */

    }/* end Enemy class */

}/* end Character_System namespace */
