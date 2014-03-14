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
                " dragon. The monsters are under the dragons command to keep outsiders from getting the stash of goods that are in the cave, so be careful! ");

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

                DisplayDungeon();

            }/* end mutator */

        }/* end Dungeon property */

        public DirectionEnum getDirection()
        {/* start getDirecton */

            Console.WriteLine("Which direction would you like to go?");
            Console.WriteLine("1. Left");
            Console.WriteLine("2. Right");
            Console.WriteLine("3. Up");
            Console.WriteLine("4. Down");

            /* A LOT of faith in this line. If there's time, do exception handling. */
            return (DirectionEnum)int.Parse(Console.ReadLine());

        }/* end getDirection */

        public void updatePlayerLocation(int row, int column)
        {/* start updatePlayerLocation */

            mPartyColumn = column;
            mPartyRow = row;

            DisplayDungeon();

        }/* end updatePlayerLocation */

        public void DeclineMovement()
        {/* start DeclineMovement */

            Console.WriteLine("You can't go that way!");
            DisplayDungeon();

        }/* end DeclineMovement */

        public ClassEnum getClassChoice()
        {/* start getClassChoice */

            Console.WriteLine("Which class would you like a party memeber to be?");
            Console.WriteLine("1. Red Mage." );
            Console.WriteLine("2. White Mage." );
            Console.WriteLine("3. Black Mage." );
            Console.WriteLine("4. Warrior." );
            Console.WriteLine("5. Theif." );
            Console.WriteLine("6. Monk." );

            /* A LOT of faith in this line. If there's time, do exception handling. */
            return (ClassEnum)int.Parse(Console.ReadLine());

        }/* end getClassChoice */

        public string getCharacterName()
        {/* start getCharacterName */

            Console.Write("Please enter the name for the party memeber. : ");
            return Console.ReadLine();

        }/* end getCharacterName */

        public BattleSystem.BattleAction getPlayerAction(Character character, Party badGuys)
        {/* start getPlayerAction */

            Console.WriteLine("It's " + character.Name + "'s turn!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Attack.");
            Console.WriteLine("2. Ability.");
            Console.WriteLine("3. Item.");

            return CreateBattleAction((ActionEnum)int.Parse(Console.ReadLine()), character, badGuys);

        }/* end getPlayerAction */

        private BattleSystem.BattleAction CreateBattleAction(ActionEnum action,Character character, Party badGuys )
        {/* start CreateBattleAction */

            if (action == ActionEnum.ATTACK)
                return new AttackAction(getTarget(badGuys, BADGUYS));

            if (action == ActionEnum.ABILITY)
                return HandleAbilitySelection(character, badGuys);

            /* Will do this after Justin finishes implementing the ItemAction based on what I told him items will do */
            //if (action == ActionEnum.ITEM)
                
            return null;

        }/* end CreateBattleAction */

        private AbilityAction HandleAbilitySelection(Character character, Party badGuys)
        {/* start HandleAbilitySelection */

            Character target;
            Ability ability;
            int i = 0;

            Console.WriteLine("Which ability would you like to use?");

            foreach (Ability candidate in character.Abilities)
            {/* start loop */

                Console.WriteLine(i + ". " + candidate.Name);
                i++;

            }/* end loop */

            ability = character.Abilities.getAbilityAtIndex(int.Parse(Console.ReadLine()));

            if (ability.AffectEnemy)
                target = getTarget(badGuys, BADGUYS);
            else
                target = getTarget(mGoodGuys, GOODGUYS);

            return new AbilityAction(ability, target);

        }/* end HandleAbilitySelection */

        private Character getTarget(Party party, bool partyAlignment)
        {/* start getTarget */

            int i;
            if (partyAlignment == GOODGUYS)
                Console.WriteLine("Who would you like to heal?");
            else
                Console.WriteLine("Who would you like to damage?");

            for (i = 0; i < party.Size; i++)
                Console.WriteLine(i + ". " + party.getCharacter(i).Name);

            return party.getCharacter(int.Parse(Console.ReadLine()));

        }/* end getTarget */

        public void RecieveBattleOutput(BattleSystem.BattleEvent ourEvent)
        {/* start RecieveBattleOutput */

            Console.WriteLine(ourEvent.ToString());

        }/* end RecieveBattleOutput */

        public void NotifyFinalBattleStart()
        {/* start NotifyFinalBattleStart */

            Console.WriteLine("The final battle with the Dragon has started!");

        }/* end NotifyFinalBattleStart */

        public void NotifyBattleStart()
        {/* start NotifyBattleStart */

            Console.WriteLine("A battle has started!");

        }/* end NotifyBattleStart */

        public void FoundItem(Character_System.Item item)
        {/* start FoundItem */

            Weapon weapon;
            Ability ability;

            /* Dependency Inversion needs to happen here. If I have time, I'll design inventory properly */
            if (item.Type == ItemType.ABILITY)
            {/* start if */

                ability = (Ability)item;
                Console.WriteLine("You found a " + ability.Name + "! It'll be added to your inventory.");

            }/* end if */

            if (item.Type == ItemType.WEAPON)
            {/* start if */

                weapon = (Weapon)item;
                Console.WriteLine("You found " + weapon.Name + "! It'll be added to your inventory.");

            }/* end if */

            mGoodGuys.giveItem(item);

        }/* end FoundItem */

        private void DisplayDungeon()
        {/* start DisplayDungeon */

            int row, column;
            DungeonEnum spot;

            for( row = 0; row < mDungeon.NumRows; row++ )
            {/* start loop */

                Console.WriteLine();

                for (column = 0; column < mDungeon.NumColumns; column++)
                {/* start loop */

                    spot = mDungeon.getTileType(row, column);

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

    }/* end TextView */

}/* end View namespace */
