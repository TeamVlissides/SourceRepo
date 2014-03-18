using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Warrior : LevelTract
    {/* start Warrior class */

        public Warrior(int[] stats) : base(stats)
        {/* start constructor */
        }/* end constructor */

        protected override void levelOne()
        {/* start levelOne */

            mAbilities = AbilitiesFactory.getInstance().getBasicAbilities(ClassEnum.WARRIOR);

        }/* end levelOne */

        protected override void levelTwo()
        {/* start levelTwo */

            mStats[(int)StatEnum.AGILITY] += 5;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 30;
            mStats[(int)StatEnum.STRENGTH] += 20;

        }/* end levelTwo */

        protected override void levelThree()
        {/* start levelThree */

            mStats[(int)StatEnum.AGILITY] += 5;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 30;
            mStats[(int)StatEnum.STRENGTH] += 20;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.SLAP));

        }/* end levelThree */

        protected override void levelFour()
        {/* start levelFour */

            mStats[(int)StatEnum.AGILITY] += 5;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 30;
            mStats[(int)StatEnum.STRENGTH] += 20;

        }/* end levelFour */

        protected override void levelFive()
        {/* start levelFive */

            mStats[(int)StatEnum.AGILITY] += 5;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 30;
            mStats[(int)StatEnum.STRENGTH] += 20;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.SMACK));

        }/* end levelFive */

        protected override void levelSix()
        {/* start levelSix */

            mStats[(int)StatEnum.AGILITY] += 5;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 30;
            mStats[(int)StatEnum.STRENGTH] += 20;

        }/* end levelSix */

        protected override void levelSeven()
        {/* start levelSeven */

            mStats[(int)StatEnum.AGILITY] += 5;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 30;
            mStats[(int)StatEnum.STRENGTH] += 20;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.STRIKE));

        }/* end levelSeven */

        protected override void levelEight()
        {/* start levelEight */

            mStats[(int)StatEnum.AGILITY] += 5;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 30;
            mStats[(int)StatEnum.STRENGTH] += 20;

        }/* end levelEight */

        protected override void levelNine()
        {/* start levelNine */

            mStats[(int)StatEnum.AGILITY] += 5;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 30;
            mStats[(int)StatEnum.STRENGTH] += 20;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.BLUDGEON));

        }/* end levelNine */

        protected override void levelTen()
        {/* start levelTen */

            mStats[(int)StatEnum.AGILITY] += 5;
            mStats[(int)StatEnum.MAGIC] += 3;
            mStats[(int)StatEnum.STAMINA] += 30;
            mStats[(int)StatEnum.STRENGTH] += 20;

        }/* end levelTen */

    }/* end Warrior class*/

}/* end Character_System namespace */
