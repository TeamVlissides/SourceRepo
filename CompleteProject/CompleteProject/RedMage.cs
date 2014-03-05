using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class RedMage : LevelTract
    {/* start RedMage class */

        public RedMage(int[] stats) : base(stats)
        {/* start constructor */
        }/* end constructor */

        protected override void levelOne()
        {/* start levelOne */

            mStats[(int)StatEnum.AGILITY] = 3;
            mStats[(int)StatEnum.MAGIC] = 3;
            mStats[(int)StatEnum.STAMINA] = 30;
            mStats[(int)StatEnum.STRENGTH] = 3;
            
            mAbilities = AbilitiesFactory.getInstance().getBasicAbilities(ClassEnum.REDMAGE);

        }/* end levelOne */

        protected override void levelTwo()
        {/* start levelTwo */

            mStats[(int)StatEnum.AGILITY] += 3;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 15;
            mStats[(int)StatEnum.STRENGTH] += 3;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.FLICK));

        }/* end levelTwo */

        protected override void levelThree()
        {/* start levelThree */

            mStats[(int)StatEnum.AGILITY] += 3;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 20;
            mStats[(int)StatEnum.STRENGTH] += 3;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.HOT));

        }/* end levelThree */

        protected override void levelFour()
        {/* start levelFour */

            mStats[(int)StatEnum.AGILITY] += 3;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 20;
            mStats[(int)StatEnum.STRENGTH] += 3;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.SOOTH));

        }/* end levelFour */

        protected override void levelFive()
        {/* start levelFive */

            mStats[(int)StatEnum.AGILITY] += 3;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 20;
            mStats[(int)StatEnum.STRENGTH] += 3;

        }/* end levelFive */

        protected override void levelSix()
        {/* start levelSix */

            mStats[(int)StatEnum.AGILITY] += 3;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 20;
            mStats[(int)StatEnum.STRENGTH] += 3;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.SLICE));

        }/* end levelSix */

        protected override void levelSeven()
        {/* start levelSeven */

            mStats[(int)StatEnum.AGILITY] += 3;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 20;
            mStats[(int)StatEnum.STRENGTH] += 3;

        }/* end levelSeven */

        protected override void levelEight()
        {/* start levelEight */

            mStats[(int)StatEnum.AGILITY] += 3;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 20;
            mStats[(int)StatEnum.STRENGTH] += 3;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.BLAZE));

        }/* end levelEight */

        protected override void levelNine()
        {/* start levelNine */

            mStats[(int)StatEnum.AGILITY] += 3;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 20;
            mStats[(int)StatEnum.STRENGTH] += 3;

        }/* end levelNine */

        protected override void levelTen()
        {/* start levelTen */

            mStats[(int)StatEnum.AGILITY] += 3;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 20;
            mStats[(int)StatEnum.STRENGTH] += 3;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.REGENERATE));

        }/* end levelTen */

    }/* end RedMage class*/

}/* end Character_System namespace */
