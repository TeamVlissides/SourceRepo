using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class WhiteMage : LevelTract
    {/* start WhiteMage class */

        public WhiteMage(int[] stats) : base(stats)
        {/* start constructor */
        }/* end constructor */

        protected override void levelOne()
        {/* start levelOne */

            mAbilities = AbilitiesFactory.getInstance().getBasicAbilities(ClassEnum.WHITEMAGE);

        }/* end levelOne */

        protected override void levelTwo()
        {/* start levelTwo */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.FLASHLIGHT));

        }/* end levelTwo */

        protected override void levelThree()
        {/* start levelThree */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.PATONBACK));

        }/* end levelThree */

        protected override void levelFour()
        {/* start levelFour */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.SPARK));

        }/* end levelFour */

        protected override void levelFive()
        {/* start levelFive */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.PRAY));

        }/* end levelFive */

        protected override void levelSix()
        {/* start levelSix */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.SMITE));

        }/* end levelSix */

        protected override void levelSeven()
        {/* start levelSeven */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.MEND));

        }/* end levelSeven */

        protected override void levelEight()
        {/* start levelEight */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.CONSECRATE));

        }/* end levelEight */

        protected override void levelNine()
        {/* start levelNine */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.HEAL));

        }/* end levelNine */

        protected override void levelTen()
        {/* start levelTen */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.SANCTIFY));

        }/* end levelTen */

    }/* end WhiteMage class*/

}/* end Character_System namespace */
