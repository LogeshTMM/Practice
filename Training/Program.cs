// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// <TODO: To form a multiplication table.
// Display the first 10 values of a multiplicatin table based on the user input.>
// ---------------------------------------------------------------------------------------
using System;
internal class Program {
   static void Main (string[] args) {
      Console.Write ("Enter the number to get the multiplication table upto 10: ");
      _ = int.TryParse (Console.ReadLine (), out int num);
      if (num < 1) {
         Console.WriteLine ("Invalid input");
         return;
      }
      for (int i = 1; i < 11; i++) Console.WriteLine ($"{num} * {i} = {num * i}");
   }
}