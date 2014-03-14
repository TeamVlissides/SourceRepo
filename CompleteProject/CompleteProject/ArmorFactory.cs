using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_System
{/* start Character_System namespace */
    
    public class ArmorFactory
    {/* start ArmorFactory */

        private static ArmorFactory mFactory;

        private Armor[] mArmorSet;

        private ArmorFactory()
        {/* start constructor */
        }/* end constructor */

        public static ArmorFactory getInstance()
        {/* start getInstance */

            if (mFactory == null)
                mFactory = new ArmorFactory();

            return mFactory;

        }/* end getInstance */

        public Armor[] getBasicArmorSet( ClassEnum classes )
        {/* start getArmorSet */

            if (classes == ClassEnum.REDMAGE)
                setBasicRedMageArmor();

            if (classes == ClassEnum.WHITEMAGE)
                setBasicWhiteMageArmor();

            if (classes == ClassEnum.BLACKMAGE)
                setBasicBlackMageArmor();

            if (classes == ClassEnum.WARRIOR)
                setBasicWarriorArmor();

            if (classes == ClassEnum.THEIF)
                setBasicTheifArmor();

            if (classes == ClassEnum.MONK)
                setBasicMonkArmor();

            return mArmorSet;

        }/* end getArmorSet */

        private void setBasicMonkArmor()
        {/* start getBasicMonkArmor */

            mArmorSet = new Armor[Armor.MAXARMOR];

            mArmorSet[(int)ArmorEnum.HEAD] = WeTriedHat();
            mArmorSet[(int)ArmorEnum.CHEST] = WeTriedTunic();
            mArmorSet[(int)ArmorEnum.GLOVES] = WeTriedGloves();
            mArmorSet[(int)ArmorEnum.FEET] = WeTriedBoots();

        }/* end getBasicMonkArmor */

        private void setBasicRedMageArmor()
        {/* start getBasicRedMageArmor */

            mArmorSet = new Armor[ Armor.MAXARMOR ];

            mArmorSet[(int)ArmorEnum.HEAD] = WeTriedHat();
            mArmorSet[(int)ArmorEnum.CHEST] = WeTriedMail();
            mArmorSet[(int)ArmorEnum.GLOVES] = WeTriedGloves();
            mArmorSet[(int)ArmorEnum.FEET] = WeTriedShoes();

        }/* end getBasicRedMageArmor */

        private void setBasicTheifArmor()
        {/* start getBasicTheifArmor */

            mArmorSet = new Armor[Armor.MAXARMOR];

            mArmorSet[(int)ArmorEnum.HEAD] = WeTriedHat();
            mArmorSet[(int)ArmorEnum.CHEST] = WeTriedTunic();
            mArmorSet[(int)ArmorEnum.GLOVES] = WeTriedGloves();
            mArmorSet[(int)ArmorEnum.FEET] = WeTriedShoes();

        }/* end getBasicTheifArmor */

        private void setBasicWhiteMageArmor()
        {/* start getBasicWhiteMageArmor */

            mArmorSet = new Armor[Armor.MAXARMOR];

            mArmorSet[(int)ArmorEnum.HEAD] = WeTriedHat();
            mArmorSet[(int)ArmorEnum.CHEST] = WeTriedRobe();
            mArmorSet[(int)ArmorEnum.GLOVES] = WeTriedGloves();
            mArmorSet[(int)ArmorEnum.FEET] = WeTriedShoes();

        }/* end getBasicWhiteMageArmor */

        private void setBasicBlackMageArmor()
        {/* start getBasicBlackMageArmor */

            mArmorSet = new Armor[Armor.MAXARMOR];

            mArmorSet[(int)ArmorEnum.HEAD] = WeTriedHat();
            mArmorSet[(int)ArmorEnum.CHEST] = WeTriedRobe();
            mArmorSet[(int)ArmorEnum.GLOVES] = WeTriedGloves();
            mArmorSet[(int)ArmorEnum.FEET] = WeTriedShoes();

        }/* end getBasicBlackMageArmor */

        private void setBasicWarriorArmor()
        {/* start getBasicWarriorArmor */

            mArmorSet = new Armor[Armor.MAXARMOR];

            mArmorSet[(int)ArmorEnum.HEAD] = WeTriedHelm();
            mArmorSet[(int)ArmorEnum.CHEST] = WeTriedPlate();
            mArmorSet[(int)ArmorEnum.GLOVES] = WeTriedGauntlets();
            mArmorSet[(int)ArmorEnum.FEET] = WeTriedBoots();

        }/* end getBasicWarriorArmor */

        /* A database would be really nice for this stuff. */

        private Armor WeTriedHat()
        {/* start WeTriedHat */

            int ArmorValue = 5;
            String Name = "We Tried Hat";
            String Description = "Well, at least it'll keep your head warm.";

            return new Armor( ArmorValue, Name, Description, ItemType.ARMOR );

        }/* end WeTriedHat */

        private Armor WeTriedMail()
        {/* start WeTriedMail */

            int ArmorValue = 8;
            String Name = "We Tried Mail";
            String Description = "Rusty chainlink mail made out of...metal???";

            return new Armor(ArmorValue, Name, Description, ItemType.ARMOR);

        }/* end WeTriedMail */

        private Armor WeTriedGloves()
        {/* start WeTriedGloves */

            int ArmorValue = 4;
            String Name = "We Tried Gloves";
            String Description = "You can feel the lack of \"try\" in these gloves.";

            return new Armor(ArmorValue, Name, Description, ItemType.ARMOR);

        }/* end WeTriedGloves */

        private Armor WeTriedShoes()
        {/* start WeTriedGloves */

            int ArmorValue = 2;
            String Name = "We Tried Shoes";
            String Description = "Wooden board with a strap. I guess that's techinically a shoe.";

            return new Armor(ArmorValue, Name, Description, ItemType.ARMOR);

        }/* end WeTriedGloves */

        private Armor WeTriedRobe()
        {/* start WeTriedRobe */

            int ArmorValue = 4;
            String Name = "We Tried Robe";
            String Description = "This walks the fine line between robe and a piece of cloth.";

            return new Armor(ArmorValue, Name, Description, ItemType.ARMOR);

        }/* end WeTriedRobe */

        private Armor WeTriedPlate()
        {/* start WeTriedPlate */

            int ArmorValue = 10;
            String Name = "We Tried Plate";
            String Description = "Tape this piece of metal to your chest. It'll stop bee stings.";

            return new Armor(ArmorValue, Name, Description, ItemType.ARMOR);

        }/* end WeTriedPlate */

        private Armor WeTriedHelm()
        {/* start WeTriedHelm */

            int ArmorValue = 8;
            String Name = "We Tried Helm";
            String Description = "Doubles as a leaky bucket.";

            return new Armor(ArmorValue, Name, Description, ItemType.ARMOR);

        }/* end WeTriedHelm */

        private Armor WeTriedGauntlets()
        {/* start WeTriedGauntlets */

            int ArmorValue = 6;
            String Name = "We Tried Gauntlets";
            String Description = "Leather straps around your hands and wrist will protect your from chaffing.";

            return new Armor(ArmorValue, Name, Description, ItemType.ARMOR);

        }/* end WeTriedGauntlets */

        private Armor WeTriedBoots()
        {/* start WeTriedBoots */

            int ArmorValue = 4;
            String Name = "We Tried Boots";
            String Description = "Leather bags tied around your feet. They count as boots.";

            return new Armor(ArmorValue, Name, Description, ItemType.ARMOR);

        }/* end WeTriedBoots */

        private Armor WeTriedTunic()
        {/* start WeTriedTunic */

            int ArmorValue = 6;
            String Name = "We Tried Tunic";
            String Description = "A piece of leath with a hole cut in the middle for your head.";

            return new Armor(ArmorValue, Name, Description, ItemType.ARMOR);

        }/* end WeTriedTunic */

    }/* end ArmorFactor */

}/* end Character_System namespace */
