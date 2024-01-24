using System.Linq;
using System;
using System.Text;

internal class Program {
   static void Main (string[] args) {
      string[] Players = new string[2] { "Player_1", "Player_2" };
      char[] ticTac = new char[9] { '-', '-', '-', '-', '-', '-', '-', '-', '-', }, icon = { 'O', 'X' };
      int[] positionArr = new int[9];
      int playerIndicator = 0, indexer = 0, findplayer = 0, coinIndexer = 0;
      Console.WriteLine ("Demo Position for place your coin in TicTac Game. coin: O indicates player_1" +
         "and coin: X indicates player_2.\"\n" + "Finally '-' this symbol indicates free space.");
      for (int i = 1, count = 0; i < 10; i++) {
         Console.Write (i + " ");
         if (count++ == 2) {
            Console.WriteLine ();
            count = 0;
         }
      }
      for (; ; ) {
         Console.Write ($"{Players[playerIndicator++ % 2]}, Enter your position for your" +
            $" coin {icon[coinIndexer++ % 2]}: ");
         _ = int.TryParse (Console.ReadLine (), out int ticTacPosition);
         if (ticTacPosition > 0 && ticTacPosition <= 9 && !positionArr.Contains (ticTacPosition)) {
            positionArr[indexer++] = ticTacPosition;
            PositionPlacer (ref ticTac, ticTacPosition, findplayer++ % 2);
         } else {
            Console.WriteLine ($"You enter the wrong position {Players[--playerIndicator % 2]}, try again.");
            for (; ; ) {
               _ = int.TryParse (Console.ReadLine (), out ticTacPosition);
               if (ticTacPosition != 0 && !positionArr.Contains (ticTacPosition)) {
                  PositionPlacer (ref ticTac, ticTacPosition, findplayer++ % 2);
                  playerIndicator++;
                  break;
               }
            }
         }
         if (CheckWinner (ticTac).Item1) {
            if (CheckWinner (ticTac).Item2 == 'O') {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine ("\nPlayer 1 is winner");
               Console.ResetColor();
               break;
            } else if (CheckWinner (ticTac).Item2 == 'X') {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine ("\nPlayer 2 is winner");
               Console.ResetColor ();
               break;
            }
         }
      }
   }

   static void PositionPlacer (ref char[] arr1D, int position, int whichPlayer) {
      int count = 0;
      if (whichPlayer == 0) {
         arr1D[--position] = 'O';
         foreach (var item in arr1D) {
            Console.Write (item + " ");
            if (count++ == 2) {
               Console.WriteLine ();
               count = 0;
            }
         }
      } else {
         arr1D[--position] = 'X';
         foreach (var item in arr1D) {
            Console.Write (item + " ");
            if (count++ == 2) {
               Console.WriteLine ();
               count = 0;
            }
         }
      }
   }

   static (bool, char) CheckWinner (char[] chars) {
      if (chars[0] == chars[1] && chars[1] == chars[2]) return (true, chars[0]);//Horizontal
      else if (chars[3] == chars[4] && chars[4] == chars[5]) return (true, chars[3]);
      else if (chars[6] == chars[7] && chars[7] == chars[8]) return (true, chars[6]);

      else if (chars[0] == chars[3] && chars[3] == chars[6]) return (true, chars[0]);//Vertical
      else if (chars[1] == chars[4] && chars[4] == chars[7]) return (true, chars[1]);
      else if (chars[2] == chars[5] && chars[5] == chars[8]) return (true, chars[2]);


      else if (chars[0] == chars[4] && chars[4] == chars[8]) return (true, chars[0]);//Diagonal
      else if (chars[2] == chars[4] && chars[4] == chars[6]) return (true, chars[2]);

      return (false, ' ');
   }
}