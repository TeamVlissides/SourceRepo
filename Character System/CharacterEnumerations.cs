using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */

    public enum StatEnum : int
    {/* start StatEnum */

        NULL = int.MinValue,
        STRENGTH = 0,
        MAGIC = 1,
        AGILITY = 2,
        STAMINA = 3,
        ARMOR = 4

    }/* end StatEnum */

    public enum ClassEnum : int
    {/* start ClassEnum */

        NULL = int.MinValue,
        REDMAGE = 0,
        WHITEMAGE = 1,
        BLACKMAGE = 2,
        WARRIOR = 3,
        THEIF = 4,
        MONK = 5

    }/* end ClassEnum */

    public enum ArmorEnum : int
    {/* start ArmorEnum */

        NULL = int.MinValue,
        HEAD = 0,
        CHEST = 1,
        GLOVES = 2,
        FEET = 3

    }/* end ArmorEnum */

    public enum WeaponEnum : int
    {/* start WeaponEnum */

        NULL = int.MinValue,
        WETIREDSWORD = 0,
        WETRIEDSTAFF = 1,
        WETRIEDKNIFE = 2

    }/* end WeaponEnum */

}/* end Character_System namespace */
