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

        public Enemy( int health, int mana, Armor[] armor, string name, int[] stats, Weapon weapon, int experienceWorth, AI actions ) : base(health,  mana,  armor,  name, stats, weapon, actions)
        {/* start constructor */

            mExperienceWorth = experienceWorth;

        }/* end constructor */

        public int Worth
        {/* start Worth property */

            get
            {/* start accessor */

                return mExperienceWorth;

            }/* end accessor */

        }/* end Worth property */

        public void takeTurn( Character[] goodGuys )
        {/* start takeTurn */


        }/* end takeTurn */

    }/* end Enemy class */

}/* end Character_System namespace */
