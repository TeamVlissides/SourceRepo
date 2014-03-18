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

        public List<Ability> getBasicAbilities(ClassEnum classes)
        {/* start getBasicAbilities */

            List<Ability> abilities = new List<Ability>();

            if (classes == ClassEnum.REDMAGE)
                addRedMageBasicAbilities(abilities);

            if (classes == ClassEnum.WHITEMAGE)
                abilities.Add(getAbility(AbilitesEnum.KISSBOOBOO));

            if (classes == ClassEnum.BLACKMAGE)
                abilities.Add(getAbility(AbilitesEnum.BREEZE));

            if (classes == ClassEnum.WARRIOR)
                abilities.Add(getAbility(AbilitesEnum.POKE));

            if (classes == ClassEnum.THIEF)
                abilities.Add(getAbility(AbilitesEnum.TRIP));

            if(classes == ClassEnum.MONK)
                abilities.Add(getAbility(AbilitesEnum.PALM));

            return abilities;

        }/* end getBasicAbilities */

        private void addRedMageBasicAbilities(List<Ability> abilities)
        {/* start addRedMageBasicAbilities */

            abilities.Add(getAbility(AbilitesEnum.APPLYBANDAID));
            abilities.Add(getAbility(AbilitesEnum.LUKEWARM));
            abilities.Add(getAbility(AbilitesEnum.FLAIL));

        }/* end addRedMageBasicAbilities */

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

            if (ability == AbilitesEnum.PALM)
                setPalmAbility();

            if (ability == AbilitesEnum.BACKHAND)
                setBackHandAbility();

            if (ability == AbilitesEnum.JUDOCHOP)
                setJudoChopAbility();

            if (ability == AbilitesEnum.PUNCH)
                setPunchAbility();

            if (ability == AbilitesEnum.KICK)
                setKickAbility();

            if (ability == AbilitesEnum.TRIP)
                setTripAbility();

            if (ability == AbilitesEnum.POUNCE)
                setPounceAbility();

            if (ability == AbilitesEnum.BACKSTAB)
                setBackStabAbility();

            if (ability == AbilitesEnum.FEINT)
                setFeintAbility();

            if (ability == AbilitesEnum.SLICETHROAT)
                setSliceThroatAbility();

            if (ability == AbilitesEnum.APPLYBANDAID)
                setApplyBandAidAbility();

            if (ability == AbilitesEnum.SOOTH)
                setSoothAbility();

            if (ability == AbilitesEnum.REGENERATE)
                setRegenerateAbility();

            if (ability == AbilitesEnum.LUKEWARM)
                setLukeWarmAbility();

            if (ability == AbilitesEnum.HOT)
                setHotAbility();

            if (ability == AbilitesEnum.BLAZE)
                setBlazeAbility();

            if (ability == AbilitesEnum.FLAIL)
                setFlailAbility();

            if (ability == AbilitesEnum.FLICK)
                setFlickAbility();

            if (ability == AbilitesEnum.SLICE)
                setSliceAbility();

            return new Ability(mDescription, mName, mType, mTargetSpread, mAffectEnemy, mBaseDamage, mCost, ItemType.ABILITY, ItemEnum.NONITEM);

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

            mDescription = "Pray to the Gods, and they will heal your allies with divine power.";
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

            mDescription = "Hurt an enemy's eyes with a very bright light. Man, that's bright!";
            mName = "Flash Light";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 10;
            mCost = 20;

        }/* end setFlashLightAbility */

        private void setSparkAbility()
        {/* start setSparkAbility */

            mDescription = "Hurt an enemy's eyes with a REALLY bright light. Man, that's REALLY bright!";
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
            mName = "Freeze";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 120;
            mCost = 50;

        }/* end setFreezeAbility */

        private void setBlizzardAbility()
        {/* start setBlizzardAbility */

            mDescription = "Freeze all your enemies where they stand!";
            mName = "Blizzard";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.PARTYTARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 200;
            mCost = 100;

        }/* end setBlizzardAbility */

        private void setPokeAbility()
        {/* start setPokeAbility */

            mDescription = "Poke an enemy...uncomfortably...";
            mName = "Poke";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 20;
            mCost = 10;

        }/* end setPokeAbility */

        private void setSlapAbility()
        {/* start setSlapAbility */

            mDescription = "Slap an enemy across the face! OUCH!";
            mName = "Slap";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 40;
            mCost = 15;

        }/* end setSlapAbility */

        private void setSmackAbility()
        {/* start setSmackAbility */

            mDescription = "The Rock is gonna lay the smackdown on your candy a**!";
            mName = "Smack";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 80;
            mCost = 20;

        }/* end setSmackAbility */

        private void setStrikeAbility()
        {/* start setStrikeAbility */

            mDescription = "Strike at the heart of an enemy!";
            mName = "Strike";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 160;
            mCost = 25;

        }/* end setStrikeAbility */

        private void setBludgeonAbility()
        {/* start setBludgeonAbility */

            mDescription = "Bludgeon an enemy to death!";
            mName = "Bludgeon";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 320;
            mCost = 30;

        }/* end setBludgeonAbility */

        private void setPalmAbility()
        {/* start setPalmAbility */

            mDescription = "Make an enemy talk to the hand!";
            mName = "Palm";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 15;
            mCost = 7;

        }/* end setPalmAbility */

        private void setBackHandAbility()
        {/* start setBackHandAbility */

            mDescription = "Make an enemy know you're Rick James!";
            mName = "Back Hand";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 25;
            mCost = 14;

        }/* end setBackHandAbility */

        private void setJudoChopAbility()
        {/* start setJudoChopAbility */

            mDescription = "Judo Chop!";
            mName = "Judo Chop";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 65;
            mCost = 17;

        }/* end setJudoChopAbility */

        private void setPunchAbility()
        {/* start setPunchAbility */

            mDescription = "Punch an enemy in the gut!";
            mName = "Punch";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 130;
            mCost = 23;

        }/* end setPunchAbility */

        private void setKickAbility()
        {/* start setKickAbility */

            mDescription = "Kick the enemy's head off!";
            mName = "Kick";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 260;
            mCost = 27;

        }/* end setKickAbility */

        private void setTripAbility()
        {/* start setTripAbility */

            mDescription = "Make an enemy fall over and hurt itself.";
            mName = "Trip";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 10;
            mCost = 5;

        }/* end setTripAbility */

        private void setPounceAbility()
        {/* start setPounceAbility */

            mDescription = "You jump onto an enemy. That kind of hurts...";
            mName = "Pounce";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 20;
            mCost = 10;

        }/* end setPounceAbility */

        private void setBackStabAbility()
        {/* start setBackStabAbility */

            mDescription = "Stab an enemy in the back!";
            mName = "Back Stab";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 55;
            mCost = 12;

        }/* end setBackStabAbility */

        private void setFeintAbility()
        {/* start setFeintAbility */

            mDescription = "Draw an enemy into a trap, and then grab them with your death grip!";
            mName = "Feint";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 100;
            mCost = 17;

        }/* end setFeintAbility */

        private void setSliceThroatAbility()
        {/* start setSliceThroatAbility */

            mDescription = "Slaughter an enemy by slicing their throat!";
            mName = "Slice Throat";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 175;
            mCost = 20;

        }/* end setSliceThroatAbility */

        private void setApplyBandAidAbility()
        {/* start setApplyBandAidAbility */

            mDescription = "Apply a Band-Aid® to an ally's wounds to stop a minute amount of bleeding.";
            mName = "Apply Band-Aid®";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.HEALING;
            mBaseDamage = 3;
            mCost = 3;

        }/* end setApplyBandAidAbility */

        private void setSoothAbility()
        {/* start setSoothAbility */

            mDescription = "Use nature magic to sooth an ally's wounds.";
            mName = "Sooth";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.HEALING;
            mBaseDamage = 10;
            mCost = 10;

        }/* end setSoothAbility */

        private void setRegenerateAbility()
        {/* start setRegenerateAbility */

            mDescription = "Use nature magic to regenerate an ally's body and heal their wounds.";
            mName = "Regenerate";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.HEALING;
            mBaseDamage = 40;
            mCost = 40;

        }/* end setRegenerateAbility */

        private void setLukeWarmAbility()
        {/* start setLukeWarmAbility */

            mDescription = "Make an enemy uncomfortably warm.";
            mName = "Luke Warm";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 3;
            mCost = 3;

        }/* end setLukeWarmAbility */

        private void setHotAbility()
        {/* start setHotAbility */

            mDescription = "Make an enemy sweat. Enemies are allergic to sweat.";
            mName = "Hot";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 50;
            mCost = 25;

        }/* end setHotAbility */

        private void setBlazeAbility()
        {/* start setBlazeAbility */

            mDescription = "BURN 'EM! BURN ALL YOUR ENEMIES TO THE GROUND!";
            mName = "Blaze";
            mType = Ability.MAGIC;
            mTargetSpread = Ability.PARTYTARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 150;
            mCost = 75;

        }/* end setBlazeAbility */

        private void setFlailAbility()
        {/* start setFlailAbility */

            mDescription = "Just one \"l\" away from fail.";
            mName = "Flail";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 7;
            mCost = 3;

        }/* end setFlailAbility */

        private void setFlickAbility()
        {/* start setFlickAbility */

            mDescription = "You flick the ear of the enemy REALLY hard.";
            mName = "Flick";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 40;
            mCost = 10;

        }/* end setFlickAbility */

        private void setSliceAbility()
        {/* start setSliceAbility */

            mDescription = "Slice an enemy up into pieces!";
            mName = "Slice";
            mType = Ability.PHYSICAL;
            mTargetSpread = Ability.SINGLETARGET;
            mAffectEnemy = Ability.DAMAGING;
            mBaseDamage = 150;
            mCost = 17;

        }/* end setSliceAbility */

    }/* end AbilitiesFactory class */

}/* end namespace */
