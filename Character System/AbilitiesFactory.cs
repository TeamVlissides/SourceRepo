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

            if (ability == AbilitesEnum.KISSBOOBOO)
                setKissBooBooAbility();

            if (ability == AbilitesEnum.PATONBACK)
                setPatOnBackAbility();

            if (ability == AbilitesEnum.PRAY)
                setPrayAbility();

            if (ability == AbilitesEnum.MEND)
                setMendAbility();

            if (ability == AbilitesEnum.HEAL)
                setHealAbility();

            if (ability == AbilitesEnum.FLASHLIGHT)
                setFlashLightAbility();

            if (ability == AbilitesEnum.SPARK)
                setSparkAbility();

            if (ability == AbilitesEnum.SMITE)
                setSmiteAbility();

            if (ability == AbilitesEnum.CONSECRATE)
                setConsecrateAbility();

            if (ability == AbilitesEnum.SANCTIFY)
                setSanctifyAbility();

            if (ability == AbilitesEnum.BREEZE)
                setBreezeAbility();

            if (ability == AbilitesEnum.COOL)
                setCoolAbility();

            if (ability == AbilitesEnum.COLD)
                setColdAbility();

            if (ability == AbilitesEnum.FREEZE)
                setFreezeAbility();

            if (ability == AbilitesEnum.BLIZZARD)
                setBlizzardAbility();

            if (ability == AbilitesEnum.POKE)
                setPokeAbility();

            if (ability == AbilitesEnum.SLAP)
                setSlapAbility();

            if (ability == AbilitesEnum.SMACK)
                setSmackAbility();

            if (ability == AbilitesEnum.STRIKE)
                setStrikeAbility();

            if (ability == AbilitesEnum.BLUDGEON)
                setBludgeonAbility();

            return new Ability(mDescription, mName, mType, mTargetSpread, mAffectEnemy, mBaseDamage, mCost);

        }/* end getAbility */

        private void setKissBooBooAbility()
        {/* start setKissBooBooAbility */

            mDescription = "Kiss the boo boo of an ally to make their wounds feel slightly better";
            mName = "Kiss Boo Boo";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.HEALING;
            mBaseDamage = 5;
            mCost = 5;

        }/* end setKissBooBooAbility */

        private void setPatOnBackAbility()
        {/* start setPatOnBackAbility */

            mDescription = "Pat an ally on the back to make their wounds feel a little more better.";
            mName = "Pat on Back";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.HEALING;
            mBaseDamage = 10;
            mCost = 10;

        }/* end setPatOnBackAbility */

        private void setPrayAbility()
        {/* start setPrayAbility */

            mDescription = "Pray to the Gods, and they will heal your allies with divine power";
            mName = "Pray";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.PARTYTARGET;
            mAffectEnemy = Ability.HEALING;
            mBaseDamage = 15;
            mCost = 30;

        }/* end setPrayAbility */

        private void setMendAbility()
        {/* start setMendAbility */

            mDescription = "Heal an ally with holy power.";
            mName = "Mend";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.HEALING;
            mBaseDamage = 30;
            mCost = 20;

        }/* end setMendAbility */

        private void setHealAbility()
        {/* start setHealAbility */

            mDescription = "Heal all allies with holy power.";
            mName = "Mend";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.PARTYTARGET;
            mAffectEnemy = Ability.HEALING;
            mBaseDamage = 50;
            mCost = 50;

        }/* end setHealAbility */

        private void setFlashLightAbility()
        {/* start setFlashLightAbility */

            mDescription = "Hurt an enemies eyes with a very bright light. Man, that's bright!";
            mName = "Flash Light";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 10;
            mCost = 20;

        }/* end setFlashLightAbility */

        private void setSparkAbility()
        {/* start setSparkAbility */

            mDescription = "Hurt an enemies eyes with a REALLY bright light. Man, that's REALLY bright!";
            mName = "Spark";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 20;
            mCost = 40;

        }/* end setSparkAbility */

        private void setSmiteAbility()
        {/* start setSmiteAbility */

            mDescription = "By the power of the Gods, which isn't cheap, you can smite an enemy with holy fire!";
            mName = "Smite";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 30;
            mCost = 80;

        }/* end setSmiteAbility */

        private void setConsecrateAbility()
        {/* start setConsecrateAbility */

            mDescription = "Make scared this land with holy wrath, and cast away your enemies!";
            mName = "Consecrate";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.PARTYTARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 40;
            mCost = 160;

        }/* end setConsecrateAbility */

        private void setSanctifyAbility()
        {/* start setSanctifyAbility */

            mDescription = "Use the power of the Gods to purify an enemy out of existence! Please note, Gods don't work on not Sunday for free...";
            mName = "Sanctify";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 100;
            mCost = 320;

        }/* end setSanctifyAbility */

        private void setBreezeAbility()
        {/* start setBreezeAbility */

            mDescription = "Make a breeze that's a little too cool for comfort for an enemy.";
            mName = "Breeze";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 10;
            mCost = 5;

        }/* end setBreezeAbility */

        private void setCoolAbility()
        {/* start setCoolAbility */

            mDescription = "Make an enemy want a blanket.";
            mName = "Cool";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 30;
            mCost = 15;

        }/* end setCoolAbility */

        private void setColdAbility()
        {/* start setColdAbility */

            mDescription = "Make an enemy regret not dressing more for the weather.";
            mName = "Cold";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 60;
            mCost = 30;

        }/* end setColdAbility */

        private void setFreezeAbility()
        {/* start setFreezeAbility */

            mDescription = "Freeze an enemy's heart and have it stop beating.";
            mName = "Cold";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 120;
            mCost = 50;

        }/* end setFreezeAbility */

        private void setBlizzardAbility()
        {/* start setBlizzardAbility */

            mDescription = "Freeze an enemy's heart and have it stop beating.";
            mName = "Cold";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 120;
            mCost = 50;

        }/* end setBlizzardAbility */

    }/* end AbilitiesFactory class */

}/* end namespace */
