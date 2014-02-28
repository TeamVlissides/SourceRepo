using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Enemy : Character
    {/* start Enemy class */

        private int mExperienceWorth;
        private AI mAI;

        public Enemy( Armor[] armor, string name, int[] stats, Weapon weapon, int experienceWorth, AI ai ) : base( armor,  name, stats, weapon, ai )
        {/* start constructor */

            mExperienceWorth = experienceWorth;
            mAI = ai;
            mIsPlayer = false;

        }/* end constructor */

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
