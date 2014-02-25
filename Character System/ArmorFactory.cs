using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */
    
    public class ArmorFactory
    {/* start ArmorFactory */

        private ArmorFactory()
        {/* start constructor */
        }/* end constructor */

        public static Armor[] getBasicRedMageArmor()
        {/* start getBasicRedMageArmor */

            Armor[] set = new Armor[ Armor.MAXARMOR ];

            set[(int)ArmorEnum.HEAD] = WeTriedHat();
            set[(int)ArmorEnum.CHEST] = WeTriedMail();
            set[(int)ArmorEnum.GLOVES] = WeTriedGloves();
            set[(int)ArmorEnum.FEET] = WeTriedShoes();

            return set;

        }/* end getBasicRedMageArmor */

        /* A database would be really nice for this stuff. */
        /* Feel like Template should be applied here */

        private static Armor WeTriedHat()
        {/* start WeTriedHat */

            int ArmorValue = 5;
            String Name = "We Tried Hat";
            String Description = "Well, at least it'll keep your head warm.";

            return new Armor( ArmorValue, Name, Description );

        }/* end WeTriedHat */

        private static Armor WeTriedMail()
        {/* start WeTriedMail */

            int ArmorValue = 15;
            String Name = "We Tried Mail";
            String Description = "Rusty chainlink mail made out of...metal?";

            return new Armor(ArmorValue, Name, Description);

        }/* end WeTriedMail */

        private static Armor WeTriedGloves()
        {/* start WeTriedGloves */

            int ArmorValue = 7;
            String Name = "We Tried Gloves";
            String Description = "You can feel the lack of \"try\" in these gloves.";

            return new Armor(ArmorValue, Name, Description);

        }/* end WeTriedGloves */

        private static Armor WeTriedShoes()
        {/* start WeTriedGloves */

            int ArmorValue = 2;
            String Name = "We Tried Shoes";
            String Description = "Wooden board with a strap. I guess that's techinically a shoe.";

            return new Armor(ArmorValue, Name, Description);

        }/* end WeTriedGloves */

    }/* end ArmorFactor */

}/* end Character_System namespace */
