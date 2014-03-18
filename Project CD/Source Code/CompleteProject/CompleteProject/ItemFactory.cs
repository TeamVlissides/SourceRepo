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

            Item items = null;

            if (item == ItemEnum.HEALTHPOTION)
                items = new Ability("Heals a character's health by 25%", "Health Potion", Ability.MAGIC, Ability.SINGLETARGET, Ability.HEALING, 25, 0, ItemType.ABILITY, item);

            if (item == ItemEnum.MANAPOTION)
            {/* start if */

                items = new Ability("Restores a character's mana by 25%", "Mana Potion", Ability.MAGIC, Ability.SINGLETARGET, Ability.HEALING, 25, 0, ItemType.ABILITY, item);
                items.IsMana = true;

            }/* end if */

            if (item == ItemEnum.GANDALFSSTAFF)
                items = new Weapon("Gandalf's Staff", "YOU SHALL NOT PASS!", 100, new int[Character.MAXSTATS] { 5, 100, 5, 20 }, ItemType.WEAPON);

            if (item == ItemEnum.UBERSWORD)
                items = new Weapon("Uber Sword", "Used to PWN noobs.", 100, new int[Character.MAXSTATS] { 100, 15, 30, 30 }, ItemType.WEAPON);

            if (item == ItemEnum.BOMB)
                items = new Ability("Blow up the enemy.", "Bomb", Ability.PHYSICAL, Ability.PARTYTARGET, Ability.DAMAGING, 500, 0, ItemType.ABILITY, item);

            return items;

        }/* end getItem */

    }/* end ItemFactory */

}/* end Character_System namespace */
