// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// Program.cs
// <TODO: Display the chess board.
// After running the program, the output will be shown on the chess board.>
using System.Text;
internal class Program {
   static void Main (string[] args) {
      Console.OutputEncoding = new UnicodeEncoding ();
      Console.Write ("\u250f");
      FirstTwoBlockLines ("\u2533");
      Console.WriteLine ("\u2513"); // 7 L shape unicode
      Console.WriteLine ("\u2503 \u265c ┃ \u265E ┃ \u265D ┃ \u265B ┃ \u265A ┃ \u265D ┃ \u265E ┃ \u265C ┃");
      Console.Write ("\u2523");
      FirstTwoBlockLines ("\u254B"); // plus heavy unicode
      Console.WriteLine ("\u252B"); // T shape unicode
      for (int i = 0; i < 8; i++) Console.Write ("\u2503 \u265F ");
      Console.WriteLine ("┃");
      Console.Write ("┣");
      FirstTwoBlockLines ("\u254B");
      Console.WriteLine ("\u252B");
      int j = 0;
      while (j != 4) {
         for (int i = 0; i < 9; i++) Console.Write ("┃   ");
         Console.WriteLine ();
         RemainingBlockLines ("┣", "\u254B");
         Console.WriteLine ("\u252B");
         j++;
      }
      for (int i = 0; i < 8; i++) Console.Write ("\u2503 \u2659 ");
      Console.WriteLine ("\u2503");
      RemainingBlockLines ("┣", "\u254B");
      Console.WriteLine ("┫");
      Console.WriteLine ("\u2503 \u2656 ┃ \u2658 ┃ \u2657 ┃ \u2655 ┃ \u2654 ┃ \u2657 ┃ \u2658 ┃ \u2656 ┃");
      RemainingBlockLines ("\u2517", "\u253B");
      Console.WriteLine ("\u251B");

      void FirstTwoBlockLines (string line) {
         for (int i = 0; i < 8; i++) {
            Console.Write ("\u2501\u2501\u2501");
            if (i != 7) Console.Write ($"{line}");
         }
      }

      void RemainingBlockLines (string a, string b) {
         for (int i = 0; i < 8; i++) {
            if (i == 0) Console.Write ($"{a}\u2501\u2501\u2501");
            else Console.Write ($"{b}\u2501\u2501\u2501");
         }
      }
   }
}