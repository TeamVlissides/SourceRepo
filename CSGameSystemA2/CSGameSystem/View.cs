using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSGameSystem
{/* start Game_System namespace */

    public interface View
    {/* start View interface */

        // C# does not allow public/private as part of a declaration.

        /* For Dungeon System */
          DirectionEnum getDirection();

          void updatePlayerLocation(int row, int column);

          void DeclineMovement();

          /* For Character System */
          ClassEnum getClassChoice();

          String getCharacterName();

          /* For Battle System */
          //BattleAction getPlayerAction(Character character);

          /* For Battle System */
          BattleAction getPlayerAction(Character character, Party badGuys);


          void RecieveBattleOutput(BattleEvent ourEvent);

          /* For Game Controller */
          void NotifyFinalBattleStart();

          void NotifyBattleStart();

          void FoundItem(Item item);

          Party GoodGuys
          {/* start GoodGuys property */

              set;

          }/* end GoodGuys property */

          Object getInput(TypeEnum type);

          void sendOutput(IEnumerator enumerator, TypeEnum type);

          void sendOutput( String theString );

          void View_Paint(Graphics g);

          void setGraphicsObject(Graphics g);

          void DrawPartyCharacter();

          void drawTiles(Tile[,] tiles, Graphics g);

       //   void MovePartyRight();

         // void MovePartyLeft();

         // void MovePartyUp();

         // void MovePartyDown();


    }/* end View interface */

}/* end Game_System namespace */
