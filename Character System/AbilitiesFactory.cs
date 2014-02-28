using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start namespace */

    public class AbilitiesFactory
    {/* start AbilitiesFactory class*/

        private static AbilitiesFactory mFactory;

        private String mDescription;
        private String mName;
        private bool mType;
        private bool mTargetSpread;
        private bool mAffectEnemy;
        private int mBaseDamage;
        private int mCost;

        private AbilitiesFactory()
        {/* start constructor */
        }/* end constructor */

        public static AbilitiesFactory getInstance()
        {/* start getInstance */

            if (mFactory == null)
                mFactory = new AbilitiesFactory();

            return mFactory;

        }/* end getInstance */

        public Ability getAbility(AbilitesEnum ability)
        {/* start getAbility */

            return new Ability(mDescription, mName, mType, mTargetSpread, mAffectEnemy, mBaseDamage, mCost);

        }/* end getAbility */

    }/* end AbilitiesFactory class */

}/* end namespace */
