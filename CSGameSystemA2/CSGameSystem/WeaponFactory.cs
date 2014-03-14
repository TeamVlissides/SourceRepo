using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGameSystem
{/* start Character_System namespace */

    public class WeaponFactory
    {/* start WeaponFactory class */

        private WeaponFactory()
        {/* start constructor */
        }/* end constructor */

        public static Weapon getWeapon(WeaponEnum weapon)
        {/* start WeaponFactory */

            if (weapon == WeaponEnum.WETIREDSWORD)
                return getWeTriedSword();

            if (weapon == WeaponEnum.WETRIEDKNIFE)
                return getWeTriedKnife();

            if (weapon == WeaponEnum.WETRIEDSTAFF)
                return getWeTriedStaff();

            return null;

        }/* end WeaponFactory */

        /* Feel like Template should be applied here */

        private static Weapon getWeTriedSword()
        {/* start getWeTriedSword */

            String name = "We Tried Sword";
            String description = "Looks more just like a metal bar than a sword.";
            int damage = 20;

            int[] stats = new int[Character.MAXSTATS];

            stats[(int)StatEnum.AGILITY] = 1;
            stats[(int)StatEnum.MAGIC] = 1;
            stats[(int)StatEnum.STAMINA] = 3;
            stats[(int)StatEnum.STRENGTH] = 3;

            return new Weapon(name, description, damage, stats, ItemType.WEAPON);

        }/* end getWeTriedSword */

        private static Weapon getWeTriedKnife()
        {/* start getWeTriedKnife */

            String name = "We Tried Knife";
            String description = "It you jab someone with this metal toothpick...I'm sure that you'll be okay.";
            int damage = 10;

            int[] stats = new int[Character.MAXSTATS];

            stats[(int)StatEnum.AGILITY] = 3;
            stats[(int)StatEnum.MAGIC] = 0;
            stats[(int)StatEnum.STAMINA] = 1;
            stats[(int)StatEnum.STRENGTH] = 2;

            return new Weapon(name, description, damage, stats, ItemType.WEAPON);

        }/* end getWeTriedKnife */

        private static Weapon getWeTriedStaff()
        {/* start getWeTriedStaff */

            String name = "We Tried Staff";
            String description = "Speak softly...and carry something else that's not this.";
            int damage = 2;

            int[] stats = new int[Character.MAXSTATS];

            stats[(int)StatEnum.AGILITY] = 2;
            stats[(int)StatEnum.MAGIC] = 3;
            stats[(int)StatEnum.STAMINA] = 2;
            stats[(int)StatEnum.STRENGTH] = 2;

            return new Weapon(name, description, damage, stats, ItemType.WEAPON);

        }/* end getWeTriedStaff */

        public static Weapon NullWeapon()
        {/* start NullWeapon */

            String name = "No weapon.";
            String description = "No weapon.";
            int damage = 0;

            int[] stats = new int[Character.MAXSTATS];

            stats[(int)StatEnum.AGILITY] = 0;
            stats[(int)StatEnum.MAGIC] = 0;
            stats[(int)StatEnum.STAMINA] = 0;
            stats[(int)StatEnum.STRENGTH] = 0;

            return new Weapon(name, description, damage, stats, ItemType.WEAPON);

        }/* end NullWeapon */
        
    }/* end WeaponFactory class */

}/* end Character_System namespace */
