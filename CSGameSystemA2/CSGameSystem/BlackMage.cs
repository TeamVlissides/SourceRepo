using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{/* start Character_System namespace */

    public class BlackMage : LevelTract
    {/* start BlackMage class */

        public BlackMage(int[] stats) : base(stats)
        {/* start constructor */
        }/* end constructor */

        protected override void levelOne()
        {/* start levelOne */

            mStats[(int)StatEnum.AGILITY] = 1;
            mStats[(int)StatEnum.MAGIC] = 10;
            mStats[(int)StatEnum.STAMINA] = 10;
            mStats[(int)StatEnum.STRENGTH] = 1;

            mAbilities = AbilitiesFactory.getInstance().getBasicAbilities(ClassEnum.BLACKMAGE);

        }/* end levelOne */

        protected override void levelTwo()
        {/* start levelTwo */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

        }/* end levelTwo */

        protected override void levelThree()
        {/* start levelThree */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.COOL));

        }/* end levelThree */

        protected override void levelFour()
        {/* start levelFour */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;
            
        }/* end levelFour */

        protected override void levelFive()
        {/* start levelFive */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.COLD));

        }/* end levelFive */

        protected override void levelSix()
        {/* start levelSix */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

        }/* end levelSix */

        protected override void levelSeven()
        {/* start levelSeven */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.FREEZE));

        }/* end levelSeven */

        protected override void levelEight()
        {/* start levelEight */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

        }/* end levelEight */

        protected override void levelNine()
        {/* start levelNine */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.BLIZZARD));

        }/* end levelNine */

        protected override void levelTen()
        {/* start levelTen */

            mStats[(int)StatEnum.AGILITY] += 1;
            mStats[(int)StatEnum.MAGIC] += 10;
            mStats[(int)StatEnum.STAMINA] += 10;
            mStats[(int)StatEnum.STRENGTH] += 1;

        }/* end levelTen */

    }/* end BlackMage class*/

}/* end Character_System namespace */
