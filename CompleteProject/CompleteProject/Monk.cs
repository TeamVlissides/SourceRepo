using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Monk : LevelTract
    {/* start Monk class */

        public Monk(int[] stats) : base(stats)
        {/* start constructor */
        }/* end constructor */

        protected override void levelOne()
        {/* start levelOne */

            mStats[(int)StatEnum.AGILITY] = 17;
            mStats[(int)StatEnum.MAGIC] = 6;
            mStats[(int)StatEnum.STAMINA] = 18;
            mStats[(int)StatEnum.STRENGTH] = 15;

            mAbilities = AbilitiesFactory.getInstance().getBasicAbilities(ClassEnum.MONK);

        }/* end levelOne */

        protected override void levelTwo()
        {/* start levelTwo */

            mStats[(int)StatEnum.AGILITY] += 17;
            mStats[(int)StatEnum.MAGIC] += 6;
            mStats[(int)StatEnum.STAMINA] += 18;
            mStats[(int)StatEnum.STRENGTH] += 15;

        }/* end levelTwo */

        protected override void levelThree()
        {/* start levelThree */

            mStats[(int)StatEnum.AGILITY] += 17;
            mStats[(int)StatEnum.MAGIC] += 6;
            mStats[(int)StatEnum.STAMINA] += 18;
            mStats[(int)StatEnum.STRENGTH] += 15;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.BACKHAND));

        }/* end levelThree */

        protected override void levelFour()
        {/* start levelFour */

            mStats[(int)StatEnum.AGILITY] += 17;
            mStats[(int)StatEnum.MAGIC] += 6;
            mStats[(int)StatEnum.STAMINA] += 18;
            mStats[(int)StatEnum.STRENGTH] += 15;

        }/* end levelFour */

        protected override void levelFive()
        {/* start levelFive */

            mStats[(int)StatEnum.AGILITY] += 17;
            mStats[(int)StatEnum.MAGIC] += 6;
            mStats[(int)StatEnum.STAMINA] += 18;
            mStats[(int)StatEnum.STRENGTH] += 15;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.JUDOCHOP));

        }/* end levelFive */

        protected override void levelSix()
        {/* start levelSix */

            mStats[(int)StatEnum.AGILITY] += 17;
            mStats[(int)StatEnum.MAGIC] += 6;
            mStats[(int)StatEnum.STAMINA] += 18;
            mStats[(int)StatEnum.STRENGTH] += 15;

        }/* end levelSix */

        protected override void levelSeven()
        {/* start levelSeven */

            mStats[(int)StatEnum.AGILITY] += 17;
            mStats[(int)StatEnum.MAGIC] += 6;
            mStats[(int)StatEnum.STAMINA] += 18;
            mStats[(int)StatEnum.STRENGTH] += 15;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.PUNCH));

        }/* end levelSeven */

        protected override void levelEight()
        {/* start levelEight */

            mStats[(int)StatEnum.AGILITY] += 17;
            mStats[(int)StatEnum.MAGIC] += 6;
            mStats[(int)StatEnum.STAMINA] += 18;
            mStats[(int)StatEnum.STRENGTH] += 15;

        }/* end levelEight */

        protected override void levelNine()
        {/* start levelNine */

            mStats[(int)StatEnum.AGILITY] += 17;
            mStats[(int)StatEnum.MAGIC] += 6;
            mStats[(int)StatEnum.STAMINA] += 18;
            mStats[(int)StatEnum.STRENGTH] += 15;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.KICK));

        }/* end levelNine */

        protected override void levelTen()
        {/* start levelTen */

            mStats[(int)StatEnum.AGILITY] += 17;
            mStats[(int)StatEnum.MAGIC] += 6;
            mStats[(int)StatEnum.STAMINA] += 18;
            mStats[(int)StatEnum.STRENGTH] += 15;

        }/* end levelTen */

    }/* end Monk class*/

}/* end Character_System namespace */
