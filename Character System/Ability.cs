using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Ability
    {/* start Ability class */

        private String mDescription;
        private String mName;
        private bool mType;
        private bool mTargetSpread;
        private bool mAffectEnemy;
        private int mBaseStat;

        public Ability( String description, String name, bool type, bool targetSpread, bool affectEnemy, int baseStat )
        {/* start constructor */

            mDescription = description;
            mName = name;
            mType = type;
            mTargetSpread = targetSpread;
            mAffectEnemy = affectEnemy;
            mBaseStat = baseStat;

        }/* end constructor */

        public int BaseStat
        {/* start BaseStat property */

            get
            {/* start accessor */

                return mBaseStat;

            }/* end accessor */
            
        }/* end BaseStat property */

        public String Name
        {/* start Name property */

            get
            {/* start accessor */

                return mName;

            }/* end accessor */

        }/* end Name property */

        public String Description
        {/* start Description property */

            get
            {/* start accessor */

                return mDescription;

            }/* end accessor */

        }/* end Description property */

        public bool isMagic
        {/* start isMagic property */

            get
            {/* start accessor */

                return mType;

            }/* end accessor */

        }/* end isMagic property */

        public bool isSingleTarget
        {/* start isSingleTarget property */

            get
            {/* start accessor */

                return mTargetSpread;

            }/* end accessor */

        }/* end isSingleTarget property */

        public bool AffectEnemy
        {/* start AffectEnemy property */

            get
            {/* start accessor */

                return mAffectEnemy;

            }/* end accessor */

        }/* end AffectEnemy property */

    }/* end Ability class */

}/* end Character_System namespace */
