using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public class ItemFactory
    {/* start ItemFactory */

        public static Item getItem(ItemEnum item)
        {/* start getItem */

            if (item == ItemEnum.HEALTHPOTION)
                return new Ability("Heals a character's health by 25%", "Health Potion", Ability.MAGIC, Ability.SINGLETARGET, Ability.HEALING, 25, 0, ItemType.POTION);

            if (item == ItemEnum.MANAPOTION)
                return new Ability("Restores a character's mana by 25%", "Mana Potion", Ability.MAGIC, Ability.HEALING, false, 25, 0, ItemType.POTION);

            if (item == ItemEnum.GANDALFSSTAFF)
                return new Weapon("Gandalf's Staff", "YOU SHALL NOT PASS!", 100, new int[Character.MAXSTATS] { 5, 100, 5, 20 }, ItemType.WEAPON);

            if (item == ItemEnum.UBERSWORD)
                return new Weapon("Uber Sword", "Used to PWN noobs.", 100, new int[Character.MAXSTATS] { 100, 15, 30, 30 }, ItemType.WEAPON);

            if (item == ItemEnum.BOMB)
                return new Ability("Blow up the enemy.", "Bomb", Ability.PHYSICAL, Ability.PARTYTARGET, Ability.DAMAGING, 25, 0, ItemType.DAMAGEITEM);

            return null;

        }/* end getItem */

    }/* end ItemFactory */

}/* end Character_System namespace */
