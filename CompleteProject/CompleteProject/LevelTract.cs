using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System */

    public abstract class LevelTract : AbilitiesHolder
    {/* start LevelTract */

        protected int[] mStats;

        protected LevelTract( int[] stats )
        {/* start constructor */

            mStats = stats;

        }/* end constructor */

        public override sealed void LevelUp(int level)
        {/* start LevelUp */

            if (level < 1 || level > 10)
                throw new ArgumentOutOfRangeException("Level cannot be less than 1 or greater than 10.");

            if (level == 1)
                levelOne();

            if (level == 2)
                levelTwo();

            if (level == 3)
                levelThree();

            if (level == 4)
                levelFour();

            if (level == 5)
                levelFive();

            if (level == 6)
                levelSix();

            if (level == 7)
                levelSeven();

            if (level == 8)
                levelEight();

            if (level == 9)
                levelNine();

            if (level == 10)
                levelTen();

        }/* end LevelUp */

        protected abstract void levelOne();
        protected abstract void levelTwo();
        protected abstract void levelThree();
        protected abstract void levelFour();
        protected abstract void levelFive();
        protected abstract void levelSix();
        protected abstract void levelSeven();
        protected abstract void levelEight();
        protected abstract void levelNine();
        protected abstract void levelTen();

    }/* end LevelTract */

}/* end Character_System */
