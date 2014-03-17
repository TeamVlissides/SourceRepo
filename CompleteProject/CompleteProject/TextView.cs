using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_System;
using Character_System;
using Dungeon_System;
using BattleSystem;

namespace View_System
{/* start View namespace */

    public class TextView : View
    {/* start TextView */

        private const bool GOODGUYS = true;
        private const bool BADGUYS = false;

        private Party mGoodGuys;
        private Grid mDungeon;
        private int mPartyRow;
        private int mPartyColumn;

        public TextView()
        {/* start constructor */

            Console.WriteLine("You and your party are in a deep dark cave with a dragon who is the keeper of the cave. The dragon is watcher of the large " +
                "stash of gold and precious jewels. You and your party want to traverse the cave, defeat the dragon, and collect the loot. In the cave there are cave monsters and minions of the" +
                " dragon. The monsters are under the dragons command to keep outsiders from getting the stash of goods that are in the cave, so be careful! Thou MUST grind "+
                "to be strong enough to face the dragon. ");

            mPartyRow = 0;
            mPartyColumn = 0;

        }/* end constructor */

        public Party GoodGuys
        {/* start GoodGuys property */

            set
            {/* start mutator */

                mGoodGuys = value;

            }/* end mutator */

        }/* end GoodGuys property */

        public Grid Dungeon
        {/* start Dungeon property */

            set
            {/* start mutator */

                mDungeon = value;

            }/* end mutator */

        }/* end Dungeon property */

        public DirectionEnum getDirection()
        {/* start getDirecton */

            int choice = 5;

            while (choice == 5)
            {/* start loop */

                DisplayDungeon();
                Console.WriteLine();
                Console.WriteLine("Which direction would you like to go?");
                Console.WriteLine("1. Left");
                Console.WriteLine("2. Right");
                Console.WriteLine("3. Up");
                Console.WriteLine("4. Down");
                Console.WriteLine("5. Menu.");

                choice = sanitizeInput(1,5);

                if (choice == 5)
                    Menu();

            }/* end loop */

            return (DirectionEnum)choice;

        }/* end getDirection */

        public void updatePlayerLocation(int row, int column)
        {/* start updatePlayerLocation */

            mPartyColumn = row;
            mPartyRow = column;

        }/* end updatePlayerLocation */

        public void DeclineMovement()
        {/* start DeclineMovement */

            Console.WriteLine("You can't go that way!");

        }/* end DeclineMovement */

        public ClassEnum getClassChoice()
        {/* start getClassChoice */

            Console.WriteLine("Which class would you like a party memeber to be?");
            Console.WriteLine("1. Red Mage." );
            Console.WriteLine("2. White Mage." );
            Console.WriteLine("3. Black Mage." );
            Console.WriteLine("4. Warrior." );
            Console.WriteLine("5. Thief." );
            Console.WriteLine("6. Monk." );

            return (ClassEnum)sanitizeInput(1, 6);

        }/* end getClassChoice */

        public string getCharacterName()
        {/* start getCharacterName */

            Console.Write("Please enter the name for the party memeber. : ");
            return Console.ReadLine();

        }/* end getCharacterName */

        public BattleAction getPlayerAction(Character character, Party badGuys)
        {/* start getPlayerAction */

            BattleAction action = null;

            
            Console.WriteLine("It's " + character.Name + "'s turn!");
            Console.WriteLine(character.Name + " has " + character.CurrentHealth + " health and " + character.CurrentMana + " mana.");

            while (action == null)
            {/* start loop */

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Attack.");
                Console.WriteLine("2. Ability.");
                Console.WriteLine("3. Item.");

                action = CreateBattleAction((ActionEnum)sanitizeInput( 1, 3 ), character, badGuys);

            }/* end loop */

            return action;

        }/* end getPlayerAction */

        public void RecieveBattleOutput(BattleSystem.BattleEvent ourEvent)
        {/* start RecieveBattleOutput */

            Console.WriteLine(ourEvent.toString());
            Console.WriteLine(ourEvent.User.Name + " has " + ourEvent.User.CurrentHealth + " health and " + ourEvent.User.CurrentMana + " mana.");
            Console.WriteLine(ourEvent.Target.Name + " has " + ourEvent.Target.CurrentHealth + " health and " + ourEvent.Target.CurrentMana + " mana.");

        }/* end RecieveBattleOutput */

        public void NotifyFinalBattleStart()
        {/* start NotifyFinalBattleStart */

            Console.WriteLine("The final battle with the Dragon has started!");

        }/* end NotifyFinalBattleStart */

        public void NotifyBattleStart()
        {/* start NotifyBattleStart */

            Console.WriteLine("A battle has started!");

        }/* end NotifyBattleStart */

        public void notifyGameOver()
        {/* start notifyGameOver */

            Console.WriteLine("Your party has died! Game over! Enter any button to end the game.");
            Console.ReadLine();

        }/* end notifyGameOver */

        public void notifyUltimateVictory()
        {/* start notifyUltimateVictory */

            Console.WriteLine("You and your party defeated the Dragon! You have enough gold here to go to Hawaii (Just one of you)! Congrats! Enter any button to end the game");
            Console.ReadLine();

        }/* end notifyUltimateVictory */

        public void FoundItem(Character_System.Item item)
        {/* start FoundItem */

            Console.WriteLine("You found a " + item.Name + "! It'll be added to your inventory.");

        }/* end FoundItem */

        private int sanitizeInput(int lowerLimit, int upperLimit)
        {/* start sanitizeInput */

            int choice = upperLimit + 1;

            while (choice > upperLimit || choice < lowerLimit)
            {/* start loop */

                try
                {/* start try */

                    choice = int.Parse(Console.ReadLine());

                }/* end try */
                catch (FormatException exception)
                {/* start catch */

                    Console.WriteLine("INVALID INPUT! Try again.");

                }/* end catch */

                if (choice < lowerLimit || choice > upperLimit)
                    Console.WriteLine("INVALID INPUT! Try again.");

            }/* end loop */

            return choice;

        }/* end sanitizeInput */

        private BattleAction CreateBattleAction(ActionEnum action,Character character, Party badGuys )
        {/* start CreateBattleAction */

            if (action == ActionEnum.ATTACK)
                return new AttackAction(getTarget(badGuys, BADGUYS));

            if (action == ActionEnum.ABILITY)
                return HandleAbilitySelection(character, badGuys);

            if (action == ActionEnum.ITEM)
                return HandleItemSelection(character, badGuys);
                
            return null;

        }/* end CreateBattleAction */

        private ItemAction HandleItemSelection(Character character, Party badGuys)
        {/* start HandleItemSelection */

            Console.WriteLine("Which item would you like to use?");
            Ability[] items = mGoodGuys.Consumables;
            Ability choice;
            int i;

            if (items != null)
            {/* start if */

                for (i = 0; i < items.Length; i++)
                    Console.WriteLine(i + ". " + items[i].Name);

                choice = items[sanitizeInput(0,items.Length - 1)];

                mGoodGuys.removeItem(choice);

                if (choice.AffectEnemy)
                    return new ItemAction(choice);
                else
                    return new ItemAction(choice, getTarget(mGoodGuys, GOODGUYS));

            }/* end if */
            
            Console.WriteLine( "You have no items!" );
            return null;

        }/* end HandleItemSelection */

        private AbilityAction HandleAbilitySelection(Character character, Party badGuys)
        {/* start HandleAbilitySelection */

            Character target;
            Ability ability;
            int i = 0;

            Console.WriteLine("Which ability would you like to use?");

            foreach (Ability candidate in character.Abilities)
            {/* start loop */

                Console.WriteLine(i + ". " + candidate.Name + "-Mana Cost: " + candidate.Cost);
                i++;

            }/* end loop */

            ability = character.Abilities.getAbilityAtIndex(sanitizeInput(0,character.Abilities.Count - 1));

            if (ability.AffectEnemy)
                target = getTarget(badGuys, BADGUYS);
            else
                target = getTarget(mGoodGuys, GOODGUYS);

            return new AbilityAction(ability, target);

        }/* end HandleAbilitySelection */

        private Character getTarget(Party party, bool partyAlignment)
        {/* start getTarget */

            int i;
            bool dead = true;
            Character candidate = null;

            if (partyAlignment == GOODGUYS)
            {/* start if */

                Console.WriteLine("Who would you like to heal?");
                for (i = 0; i < party.Size; i++)
                    Console.WriteLine(i + ". " + party.getCharacter(i).Name + "-Health: " + party.getCharacter(i).CurrentHealth + " -Mana : " + party.getCharacter(i).CurrentMana);

                candidate = party.getCharacter(sanitizeInput( 0, party.Size - 1));

            }/* end if */
            else
            {/* start else */

                while (dead)
                {/* start loop */

                    Console.WriteLine("Who would you like to damage?");
                    for (i = 0; i < party.Size; i++)
                        if (!party.getCharacter(i).isDead)
                            Console.WriteLine(i + ". " + party.getCharacter(i).Name + "-Health: " + party.getCharacter(i).CurrentHealth + " -Mana : " + party.getCharacter(i).CurrentMana);

                    candidate = party.getCharacter(sanitizeInput(0, party.Size - 1));

                    dead = candidate.isDead;

                    if (dead)
                        Console.WriteLine("INVALID INPUT! Pick one that's alive!");

                }/* end loop */

            }/* end else */

            return candidate;

        }/* end getTarget */

        private void DisplayDungeon()
        {/* start DisplayDungeon */

            int row, column;
            DungeonEnum spot;

            for( row = 0; row < mDungeon.NumRows; row++ )
            {/* start loop */

                Console.WriteLine();

                for (column = 0; column < mDungeon.NumColumns; column++)
                {/* start loop */

                    spot = mDungeon.getTileType(column, row);

                    if (row == mPartyRow && column == mPartyColumn)
                        Console.Write("P");
                    else
                        printSpot(spot);
                    
                }/* end loop */

            }/* end loop */

            Console.WriteLine();

        }/* end DisplayDungeon */

        private void printSpot(DungeonEnum spot)
        {/* start printSpot */

            if (spot == DungeonEnum.DRAGON)
                Console.Write("D");

            if (spot == DungeonEnum.FREESPACE)
                Console.Write("F");

            if (spot == DungeonEnum.WALL)
                Console.Write("W");

            if (spot == DungeonEnum.ITEM)
                Console.Write("I");

            if (spot == DungeonEnum.NULL)
                Console.Write("N");

        }/* end printSpot */

        private void Menu()
        {/* start Menu */

            int choice = 0;

            while (choice != 5)
            {/* start loop */

                Console.WriteLine();
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Check Character stats.");
                Console.WriteLine("2. Check Inventory.");
                Console.WriteLine("3. Equip Weapons.");
                Console.WriteLine("4. Use Restortaion Items.");
                Console.WriteLine("5. Exit");

                choice = sanitizeInput(1, 5);

                if (choice == 1)
                    displayCharacterStats();

                if (choice == 2)
                    displayInventory();

                if (choice == 3)
                    equipWeapon();

                if (choice == 4)
                    useItem();

            }/* end loop */

        }/* end Menu */

        private void useItem()
        {/* start if */

            int i, choice;
            Ability[] potions;
            PlayerCharacter player = whichPlayer();

            if (inventoryIsEmpty())
                return;

            Console.WriteLine();
            Console.WriteLine("Which potion would you like to use?");

            potions = mGoodGuys.Potions;

            if (potions != null)
            {/* start if */

                for( i = 0; i < potions.Length; i++ )
                    Console.WriteLine( i + ". -Name : " + potions[ i ].Name + " -Description : " + potions[ i ].Description );

                choice = sanitizeInput(0, potions.Length - 1);

                mGoodGuys.usePotion(potions[choice], player);

            }/* end if */
            else
                Console.WriteLine("You have no potions!");

        }/* end if */

        private void equipWeapon()
        {/* start equipWeapon */

            int i, choice;
            Weapon[] weapons;

            Console.WriteLine();

            if (inventoryIsEmpty())
                return;

            PlayerCharacter player = whichPlayer();
            Console.WriteLine("Which weapon would you like to equip?");

            weapons = mGoodGuys.Weapons;

            if (weapons != null)
            {/* start if */

                for (i = 0; i < weapons.Length; i++)
                    Console.WriteLine(i + ". " + weapons[i].Name + " -Description : " + weapons[i].Description);

                choice = sanitizeInput(0, weapons.Length - 1);

                mGoodGuys.equipItem(weapons[choice], player);

            }/* end if */
            else
                Console.WriteLine("You got no weapons!");

        }/* end equipWeapon */

        private void displayInventory()
        {/* start displayInventory */

            Console.WriteLine();

            if (inventoryIsEmpty())
                return;

            foreach (Item item in mGoodGuys.Inventory)
                Console.WriteLine("-Name : " + item.Name + " -Description : " + item.Description);

        }/* end displayInventory */

        private bool inventoryIsEmpty()
        {/* start inventoryIsEmpty */

            if (mGoodGuys.Inventory.Count == 0)
            {/* start if */

                Console.WriteLine("You got nothing!");
                return true;

            }/* end if */

            return false;

        }/* end inventoryIsEmpty */

        private void displayCharacterStats()
        {/* start displayCharacterStats */

            PlayerCharacter player = whichPlayer();
            int i;
            Armor armor;

            Console.WriteLine();

            Console.WriteLine("-Name : " + player.Name + " -Class : " + player.ClassToString + " -Level : " + player.Level);
            Console.WriteLine("-Current Heatlh : " + player.CurrentHealth + " -Maximum Health : " + player.MaximumHealth );
            Console.WriteLine("-Current Mana : " + player.CurrentMana + " -Maximum Mana : " + player.MaximumMana);
            Console.WriteLine("-Weapon : " + player.Weapon.Name + " -Description : " + player.Weapon.Description);

            Console.WriteLine();
            for( i = 0; i < Character.MAXSTATS; i++ )
                Console.WriteLine( "-Stat : " + Character.statToString((StatEnum)i) + " - " + player.getStat((StatEnum)i));

            Console.WriteLine();
            Console.WriteLine("Armor : " );

            for (i = 0; i < Armor.MAXARMOR; i++)
            {/* start loop */

                armor = player.getArmor((ArmorEnum)i);

                Console.WriteLine("-Name : " + armor.Name + " -Description : " + armor.Description);
                Console.WriteLine("-Armor Value : " + armor.ArmorStat);

            }/* end loop */

            Console.WriteLine();
            Console.WriteLine("Abilities : ");

            foreach (Ability ability in player.Abilities)
            {/* start loop */

                Console.WriteLine("-Name : " + ability.Name + " -Description : " + ability.Description);
                Console.WriteLine("-Cost : " + ability.Cost + " -Power : " + ability.BaseDamage);

            }/* end loop */

        }/* end displayCharacterStats */

        private PlayerCharacter whichPlayer()
        {/* start whichPlayer */

            int i;

            Console.WriteLine("Who would you like?");
            for (i = 0; i < mGoodGuys.Size; i++)
                Console.WriteLine(i + ". " + mGoodGuys.getCharacter(i).Name + " Current Health : " + mGoodGuys.getCharacter(i).CurrentHealth + " Current Mana : " + mGoodGuys.getCharacter(i).CurrentMana);

            return (PlayerCharacter)mGoodGuys.getCharacter(sanitizeInput( 0, mGoodGuys.Size - 1));

        }/* end whichPlayer*/

    }/* end TextView */

}/* end View namespace */
