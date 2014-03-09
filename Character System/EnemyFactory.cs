using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class EnemyFactory
    {/* start EnemyFactory */

        private const int STATVARIANCE = 6;

        private static EnemyFactory mFactory;

        private Armor[] mArmor;
        private string mName;
        private int[] mStats;
        private Weapon mWeapon;
        private int mExperienceWorth;
        private AI mAi;
        private EnemyType mType;

        private EnemyFactory()
        {/* start constructor */
        }/* end constructor */

        public static EnemyFactory getInstance()
        {/* start getInstance */

            if (mFactory == null)
                mFactory = new EnemyFactory();

            return mFactory;

        }/* end getInstance */

        public Party getEnemyParty(int level)
        {/* start getEnemyParty */

            if (level < 1 || level > 10)
                throw new ArgumentOutOfRangeException("Level cannot be less than 1 or greater than 10.");

            Random random = new Random();
            int amountOfEnemies = random.Next(Party.MAXPARTY) + 1;
            int i, lower, upper;

            Enemy[] enemyParty = new Enemy[ amountOfEnemies ];

            for (i = 0; i < amountOfEnemies; i++)
            {/* start loop */

                lower = level - 1;
                upper = level + 1;

                if (level == 1)
                    lower = 1;

                if (level == 10)
                    upper = 10;

                enemyParty[i] = generateEnemy(random.Next(lower, upper + 1));

            }/* end loop */

            return new Party(enemyParty);

        }/* end getEnemyParty */

        private Enemy generateEnemy(int level)
        {/* start generateEnemy */

            setAI();

            if (level == 1)
                setSpider();

            if (level == 2)
                setBat();

            if (level == 3)
                setBear();

            if (level == 4)
                setLion();

            if (level == 5)
                setTroll();

            if (level == 6)
                setGoblin();

            if (level >= 7)
                setThePredator();

            return new Enemy( mArmor, mName, mStats, mWeapon, mExperienceWorth, mAi, mType );

        }/* end generateEnemy */

        private void setAI()
        {/* start setAI */

            Random random = new Random();
            int choice = random.Next(AI.AMOUNTOFAI);

            if (choice == 0)
                mAi = new Berserker();

            if (choice == 1)
                mAi = new Striker();

            if (choice == 2)
                mAi = new HealerAttacker();

        }/* end setAI */

        private void setSpider()
        {/* start setSpider */

            Random random = new Random();
            mArmor = null;
            mName = "Spider";
            mType = EnemyType.SPIDER;
            mWeapon = WeaponFactory.NullWeapon();
            mExperienceWorth = 25;

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 10 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.MAGIC] = 2 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STRENGTH] = 3 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STAMINA] = 1 + random.Next(STATVARIANCE);

        }/* end setSpider */

        private void setBat()
        {/* start setBat */

            Random random = new Random();
            mArmor = null;
            mName = "Bat";
            mType = EnemyType.BAT;
            mWeapon = WeaponFactory.NullWeapon();
            mExperienceWorth = 25;

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 20 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.MAGIC] = 4 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STRENGTH] = 6 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STAMINA] = 2 + random.Next(STATVARIANCE);

        }/* end setBat */

    }/* end EnemyFactory */

}/* end Character_System namespace */
