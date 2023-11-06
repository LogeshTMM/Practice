// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// Program.cs
// <TODO: Display the chess board.
// After running the program, the output will be shown on the chess board.>
using System.Text;
internal class Program {
   static void Main (string[] args) {
      Console.OutputEncoding = new UnicodeEncoding ();
      for (int i = 0; i < 8; i++) Console.Write ("\u250f\u2501\u2501\u2501");
      Console.WriteLine ("\u2513");
      Console.WriteLine ("\u2503 \u265c ┃ \u265E ┃ \u265D ┃ \u265B ┃ \u265A ┃ \u265D ┃ \u265E ┃ \u265C ┃");
      for (int i = 0; i < 8; i++) Console.Write ("\u2523\u2501\u2501\u2501");
      Console.WriteLine ("\u252B");
      for (int i = 0; i < 8; i++) Console.Write ("\u2503 \u265F ");
      Console.WriteLine ("┃");
      for (int i = 0; i < 8; i++) Console.Write ("┣\u2501\u2501\u2501");
      Console.WriteLine ("\u252B");
      int j = 0;
      while (j != 4) {
         for (int i = 0; i < 9; i++) Console.Write ("┃   ");
         Console.WriteLine ();
         for (int i = 0; i < 8; i++) Console.Write ("┣\u2501\u2501\u2501");
         Console.WriteLine ("\u252B");
         j++;
      }
      for (int i = 0; i < 8; i++) Console.Write ("\u2503 \u2659 ");
      Console.WriteLine ("\u2503");
      for (int i = 0; i < 8; i++) Console.Write ("┣\u2501\u2501\u2501");
      Console.WriteLine ("┫");
      Console.WriteLine ("\u2503 \u2656 ┃ \u2658 ┃ \u2657 ┃ \u2655 ┃ \u2654 ┃ \u2657 ┃ \u2658 ┃ \u2656 ┃");
      for (int i = 0; i < 8; i++) Console.Write ("\u2517\u2501\u2501\u2501");
      Console.WriteLine ("\u251B");
   }
}