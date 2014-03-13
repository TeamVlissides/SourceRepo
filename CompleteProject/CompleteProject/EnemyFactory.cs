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
            mExperienceWorth = 50;

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 20 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.MAGIC] = 4 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STRENGTH] = 6 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STAMINA] = 2 + random.Next(STATVARIANCE);

        }/* end setBat */

        private void setBear()
        {/* start setBear */

            Random random = new Random();
            mArmor = null;
            mName = "Bear";
            mType = EnemyType.BEAR;
            mWeapon = WeaponFactory.NullWeapon();
            mExperienceWorth = 75;

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 5 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.MAGIC] = 4 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STRENGTH] = 9 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STAMINA] = 4 + random.Next(STATVARIANCE);

        }/* end setBear */

        private void setLion()
        {/* start setLion */

            Random random = new Random();
            mArmor = null;
            mName = "Lion";
            mType = EnemyType.LION;
            mWeapon = WeaponFactory.NullWeapon();
            mExperienceWorth = 125;

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 12 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.MAGIC] = 4 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STRENGTH] = 13 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STAMINA] = 6 + random.Next(STATVARIANCE);

        }/* end setLion */

        private void setTroll()
        {/* start setTroll */

            Random random = new Random();
            mArmor = null;
            mName = "Troll";
            mType = EnemyType.TROLL;
            mWeapon = WeaponFactory.getWeapon( WeaponEnum.WETIREDSWORD );
            mExperienceWorth = 150;

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 10 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.MAGIC] = 6 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STRENGTH] = 15 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STAMINA] = 8 + random.Next(STATVARIANCE);

            mAi.addAbility( AbilitiesFactory.getInstance().getAbility(AbilitesEnum.STRIKE) );

        }/* end setTroll */

        private void setGoblin()
        {/* start setGoblin */

            Random random = new Random();
            mArmor = ArmorFactory.getInstance().getBasicArmorSet(ClassEnum.WARRIOR);
            mName = "Goblin";
            mType = EnemyType.GOBLIN;
            mWeapon = WeaponFactory.getWeapon(WeaponEnum.WETIREDSWORD);
            mExperienceWorth = 250;

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 10 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.MAGIC] = 6 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STRENGTH] = 20 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STAMINA] = 10 + random.Next(STATVARIANCE);

        }/* end setGoblin */

        private void setThePredator()
        {/* start setThePredator */

            Random random = new Random();
            mArmor = ArmorFactory.getInstance().getBasicArmorSet(ClassEnum.WARRIOR);
            mName = "The Predator";
            mType = EnemyType.THEPREDATOR;
            mWeapon = WeaponFactory.getWeapon(WeaponEnum.WETIREDSWORD);
            mExperienceWorth = 250;

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 20 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.MAGIC] = 15 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STRENGTH] = 30 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STAMINA] = 20 + random.Next(STATVARIANCE);

        }/* end setThePredator */

        public Enemy getDragon()
        {/* start getDragon */

            Random random = new Random();
            mArmor = ArmorFactory.getInstance().getBasicArmorSet(ClassEnum.WARRIOR);
            mName = "The Dragon";
            mType = EnemyType.DRAGON;
            mWeapon = WeaponFactory.getWeapon(WeaponEnum.WETIREDSWORD);
            mExperienceWorth = 100000;

            mAi = new Striker();

            mStats = new int[Character.MAXSTATS];

            mStats[(int)StatEnum.AGILITY] = 50 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.MAGIC] = 50 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STRENGTH] = 50 + random.Next(STATVARIANCE);
            mStats[(int)StatEnum.STAMINA] = 50 + random.Next(STATVARIANCE);

            mAi.addAbility( AbilitiesFactory.getInstance().getAbility(AbilitesEnum.BLAZE));

            return new Enemy(mArmor, mName, mStats, mWeapon, mExperienceWorth, mAi, mType);

        }/* end getDragon */

    }/* end EnemyFactory */

}/* end Character_System namespace */
