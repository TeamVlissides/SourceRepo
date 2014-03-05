using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class Theif : LevelTract
    {/* start Theif class */

        public Theif(int[] stats)
            : base(stats)
        {/* start constructor */
        }/* end constructor */

        protected override void levelOne()
        {/* start levelOne */

            mStats[(int)StatEnum.AGILITY] = 25;
            mStats[(int)StatEnum.MAGIC] = 7;
            mStats[(int)StatEnum.STAMINA] = 15;
            mStats[(int)StatEnum.STRENGTH] = 10;

            mAbilities = AbilitiesFactory.getInstance().getBasicAbilities(ClassEnum.THEIF);

        }/* end levelOne */

        protected override void levelTwo()
        {/* start levelTwo */

            mStats[(int)StatEnum.AGILITY] += 25;
            mStats[(int)StatEnum.MAGIC] += 7;
            mStats[(int)StatEnum.STAMINA] += 15;
            mStats[(int)StatEnum.STRENGTH] += 10;

        }/* end levelTwo */

        protected override void levelThree()
        {/* start levelThree */

            mStats[(int)StatEnum.AGILITY] += 25;
            mStats[(int)StatEnum.MAGIC] += 7;
            mStats[(int)StatEnum.STAMINA] += 15;
            mStats[(int)StatEnum.STRENGTH] += 10;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.POUNCE));

        }/* end levelThree */

        protected override void levelFour()
        {/* start levelFour */

            mStats[(int)StatEnum.AGILITY] += 25;
            mStats[(int)StatEnum.MAGIC] += 7;
            mStats[(int)StatEnum.STAMINA] += 15;
            mStats[(int)StatEnum.STRENGTH] += 10;

        }/* end levelFour */

        protected override void levelFive()
        {/* start levelFive */

            mStats[(int)StatEnum.AGILITY] += 25;
            mStats[(int)StatEnum.MAGIC] += 7;
            mStats[(int)StatEnum.STAMINA] += 15;
            mStats[(int)StatEnum.STRENGTH] += 10;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.BACKSTAB));

        }/* end levelFive */

        protected override void levelSix()
        {/* start levelSix */

            mStats[(int)StatEnum.AGILITY] += 25;
            mStats[(int)StatEnum.MAGIC] += 7;
            mStats[(int)StatEnum.STAMINA] += 15;
            mStats[(int)StatEnum.STRENGTH] += 10;

        }/* end levelSix */

        protected override void levelSeven()
        {/* start levelSeven */

            mStats[(int)StatEnum.AGILITY] += 25;
            mStats[(int)StatEnum.MAGIC] += 7;
            mStats[(int)StatEnum.STAMINA] += 15;
            mStats[(int)StatEnum.STRENGTH] += 10;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.FEINT));

        }/* end levelSeven */

        protected override void levelEight()
        {/* start levelEight */

            mStats[(int)StatEnum.AGILITY] += 25;
            mStats[(int)StatEnum.MAGIC] += 7;
            mStats[(int)StatEnum.STAMINA] += 15;
            mStats[(int)StatEnum.STRENGTH] += 10;

        }/* end levelEight */

        protected override void levelNine()
        {/* start levelNine */

            mStats[(int)StatEnum.AGILITY] += 25;
            mStats[(int)StatEnum.MAGIC] += 7;
            mStats[(int)StatEnum.STAMINA] += 15;
            mStats[(int)StatEnum.STRENGTH] += 10;

            mAbilities.Add(AbilitiesFactory.getInstance().getAbility(AbilitesEnum.SLICETHROAT));

        }/* end levelNine */

        protected override void levelTen()
        {/* start levelTen */

            mStats[(int)StatEnum.AGILITY] += 25;
            mStats[(int)StatEnum.MAGIC] += 7;
            mStats[(int)StatEnum.STAMINA] += 15;
            mStats[(int)StatEnum.STRENGTH] += 10;

        }/* end levelTen */

    }/* end Theif class*/

}/* end Character_System namespace */
