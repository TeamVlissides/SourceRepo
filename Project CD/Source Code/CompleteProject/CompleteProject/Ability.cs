using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Ability : Item
    {/* start Ability class */

        /* Constants */
        public const bool MAGIC = true;
        public const bool PHYSICAL = false;
        public const bool SINGLETARGET = true;
        public const bool PARTYTARGET = false;
        public const bool HEALING = false;
        public const bool DAMAGING = true;

        private bool mType;
        private bool mTargetSpread;
        private bool mAffectEnemy;
        private int mBaseDamage;
        private int mCost;

        public Ability(String description, String name, bool type, bool targetSpread, bool affectEnemy, int baseDamage, int cost, ItemType itemType, ItemEnum item) : base(itemType, item, name, description)
        {/* start constructor */

            mType = type;
            mTargetSpread = targetSpread;
            mAffectEnemy = affectEnemy;
            mBaseDamage = baseDamage;
            mCost = cost;

        }/* end constructor */

        public int Cost
        {/* start Cost property */

            get
            {/* start get */

                return mCost;

            }/* end get */

        }/* end Cost property */

        public int BaseDamage
        {/* start BaseStat property */

            get
            {/* start accessor */

                return mBaseDamage;

            }/* end accessor */
            
        }/* end BaseStat property */

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
