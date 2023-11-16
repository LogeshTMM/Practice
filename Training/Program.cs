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
      if (num < 1 | num >= 100) Console.WriteLine ("Invalid input");
      else for (int i = 1; i <= 10; i++) Console.WriteLine ($"{num,2} x {i,2} = {num * i,3}");
   }
}