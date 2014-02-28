using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public enum StatEnum : int
    {/* start StatEnum */

        STRENGTH = 0,
        MAGIC = 1,
        AGILITY = 2,
        STAMINA = 3,
        ARMOR = 4

    }/* end StatEnum */

    public enum ClassEnum : int
    {/* start ClassEnum */

        REDMAGE = 0,
        WHITEMAGE = 1,
        BLACKMAGE = 2,
        WARRIOR = 3,
        THEIF = 4,
        MONK = 5

    }/* end ClassEnum */

    public enum ArmorEnum : int
    {/* start ArmorEnum */

        HEAD = 0,
        CHEST = 1,
        GLOVES = 2,
        FEET = 3

    }/* end ArmorEnum */

    public enum WeaponEnum : int
    {/* start WeaponEnum */

        WETIREDSWORD = 0,
        WETRIEDSTAFF = 1,
        WETRIEDKNIFE = 2

    }/* end WeaponEnum */

    public enum AbilitesEnum : int
    {/* start AbilitiesEnum */

        /* White Mage Heal */
        KISSBOOBOO = 0,
        PATONBACK = 1,
        PRAY = 2,
        MEND = 3,
        HEAL = 4,

        /* White Mage Attack */
        FLASHLIGHT = 5,
        SPARK = 6,
        SMITE = 7,
        CONSECRATE = 8,
        SANCTIFY = 9,

        /* Black Mage */
        BREEZE = 10,
        COOL = 11,
        COLD = 12,
        FREEZE = 13,
        BLIZZARD = 14,

        /* Warrior */
        POKE = 15,
        SLAP = 16,
        SMACK = 17,
        STRIKE = 18,
        BLUDGEON = 19,

        /* Monk */
        PALM = 20,
        BACKHAND = 21,
        JUDOCHOP = 22,
        PUNCH = 23,
        KICK= 24,

        /* Theif */
        TRIP = 25,
        POUNCE = 26,
        BACKSTAB = 27,
        FEINT = 28,
        SLICETHROAT = 29,

        /* Red Mage Heal */
        APPLYBANDAID = 30,
        SOOTH = 31,
        REGENERATE = 32,

        /* Red Mage Magic */
        LUKEWARM = 33,
        HOT = 34,
        BLAZE = 35,
        
        /* Red Mage Physical */
        FLAIL = 36,
        FLICK = 37,
        SLICE = 38

    }/* end AbilitiesEnum */

}/* end Character_System namespace */
